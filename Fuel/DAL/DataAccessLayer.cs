using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.DAL
{
    class DataAccessLayer
    {
        SqlConnection sqlcon;

        public DataAccessLayer()
        {
            sqlcon = new SqlConnection("Data Source=" + Properties.Settings.Default.ServerIp.ToString() + ";initial Catalog=" + Properties.Settings.Default.DBName.ToString() + "; persist Security info=True; user id=" + Properties.Settings.Default.DBUserName.ToString() + ";password=" + Properties.Settings.Default.DBPassword.ToString() + "");
        }
        //open and close connection for Our
        public void open()
        {
            if (sqlcon.State != ConnectionState.Open)
            {
                sqlcon.Open();
            }
        }

        public void close()
        {
            if (sqlcon.State != ConnectionState.Closed)
            {
                sqlcon.Close();
            }
        }

        //execute stored procedure for Our
        public DataTable SelectingData(string stored_Procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_Procedure;
            sqlcmd.Connection = sqlcon;


            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);

                }
            }
            SqlDataAdapter Da = new SqlDataAdapter(sqlcmd);
            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            return Dt;
        }

        public void ExecuteCommand(string Stored_Procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = Stored_Procedure;
            sqlcmd.Connection = sqlcon;

            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);

                }
            }
            sqlcmd.ExecuteNonQuery();
        }


        //create backup database
        public void createBackup(string path)
        {
            sqlcon.Open();
            SqlCommand cmd1 = new SqlCommand("ALTER DATABASE [" + Properties.Settings.Default.DBName.ToString() + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE ", sqlcon);
            cmd1.ExecuteNonQuery();

            string cmd = "BACKUP DATABASE [" + Properties.Settings.Default.DBName.ToString() + "] TO DISK='" + path + "\\" + Properties.Settings.Default.DBName.ToString() +
                "-" + DateTime.Now.ToShortDateString().Replace("/", "-") + "_" + DateTime.Now.ToShortTimeString().Replace(":", "-") + ".bak'";
            SqlCommand command = new SqlCommand(cmd, sqlcon);
            command.ExecuteNonQuery();

            SqlCommand cmd3 = new SqlCommand("ALTER DATABASE [" + Properties.Settings.Default.DBName.ToString() + "] SET MULTI_USER", sqlcon);
            cmd3.ExecuteNonQuery();
            sqlcon.Close();
        }


        //recovery database from bak file
        public void Restore(string path)
        {
            sqlcon.Open();
            SqlCommand cmd1 = new SqlCommand("ALTER DATABASE [" + Properties.Settings.Default.DBName.ToString() + "] SET SETOFFLINE WITH ROLLBACK IMMEDIATE ", sqlcon);
            cmd1.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand("USE MASTER RESTORE DATABASE [" + Properties.Settings.Default.DBName.ToString() + "] FROM DISK=N'" + path + "' WITH REPLACE", sqlcon);
            cmd2.ExecuteNonQuery();
            SqlCommand cmd3 = new SqlCommand("ALTER DATABASE [" + Properties.Settings.Default.DBName.ToString() + "] SET ONLINE WITH ROLLBACK IMMEDIATE", sqlcon);
            cmd3.ExecuteNonQuery();
            sqlcon.Close();
        }

    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIA
{
    class Base
    {
        private MySqlConnection getConection()
        {
            MySqlConnection conexion = new MySqlConnection("host=localhost;" +
                "port=3306; " +
                "database=pia_progra; Uid=root; pwd=susana15;");

            return conexion;
        }
        public MySqlDataReader select(string sql)
        {
            MySqlConnection mySqlConnection = getConection();
            mySqlConnection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
            MySqlDataReader rdr = cmd.ExecuteReader();

            return rdr;
        }


        public int create_or_update(string sql)
        {
            MySqlConnection mySqlConnection = getConection();
            mySqlConnection.Open();

            MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
            int retorno = 0;
            try
            {
                retorno = cmd.ExecuteNonQuery();
                mySqlConnection.Close();
            }
            catch (Exception e)
            {
                if (e.Message.Contains("Duplicate entry"))
                {
                    return 4;
                }
            }
            
            return retorno;
        }

    }
}

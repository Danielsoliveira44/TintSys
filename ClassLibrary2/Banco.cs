using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TintSysClass
{
    internal static class Banco
    {
        private static string strConn;

        public static MySqlCommand Abrir()
        {
            strConn = @"server=127.0.0.1;database=ti93sysdb;port3307,user id=root;password=usbw";
            MySqlCommand cmd = new MySqlCommand();
            try // tentar abrir
            {
                MySqlConnection cn = new MySqlConnection(strConn);
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                }
                cmd.Connection = cn;
            }
            catch(Exception)
            {

                throw;
            }
            return cmd;
        }

        internal static void Fechar(MySqlCommand cmd)
        {
            throw new NotImplementedException();
        }
    }
}

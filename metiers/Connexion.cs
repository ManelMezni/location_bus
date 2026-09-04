using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//normalment fil dao

namespace metiers
{
    public class Connexion
    {
        // ou string chainecnx
        static string url = @"Server=DESKTOP-5DK0TQB\SQLEXPRESS;Database=BDAgence;Trusted_Connection=True";

        static SqlConnection cnx = new SqlConnection(url);
        public static SqlConnection GetInstance()
        {
            try
            {
                if (cnx != null && cnx.State == System.Data.ConnectionState.Closed)
                    cnx.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Vente: Pb de connexion\n " + ex.Message);
            }
            return cnx;
        }

    }
}

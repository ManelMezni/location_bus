using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using metiers;
using System.Windows.Forms;
namespace DAO
    //data table fi wst data set
    //fil controller l recherche
{
    public class BusDAO
    {
        public static DataSet DSBus=new DataSet();
        private SqlConnection cnx;

        public void chargerBus()
        {
            try
            {
                cnx=Connexion.GetInstance();
                SqlDataAdapter da = new SqlDataAdapter("select * from bus",cnx);
                da.Fill(DSBus, "TLBus");


            }
            catch(Exception ex) {
                MessageBox.Show("Erreur charge : " + ex.Message);

            }
            finally
            {
                cnx.Close();
            }
        }
        public void ajouter(Bus bus)
        {
            //jibna l datatable
            DataTable dtbus = DSBus.Tables["TLBus"];
            DataRow dr=dtbus.NewRow();
            dr[0] = bus.Immat; //dr['immat']
            dr[1] = bus.Marque;
            dr[2] = bus.DateAchat;
            dr[3] = bus.Capacite;
            dr[4] = bus.PrixAchat;
            dr[5] = bus.PrixJour;
            dtbus.Rows.Add(dr);
        }
        public void supprimer(Bus bus)
        {
           //mahalitch cnx n5dm 3al datatable
            //3andy des ligne mouch object
            DataTable dtbus = DSBus.Tables["TLBus"];
            foreach (DataRow row in dtbus.Rows)
            {
                if (row[0].Equals(bus.Immat))
                {
                    row.Delete();
                    break;

                }
            }
            //bech datatable tmodifi rou7ha
            //enregister fil data table
            dtbus.AcceptChanges();
    
        }
        public void Enregistrer()
        {
            //data table w7da
            try
            {
                cnx = Connexion.GetInstance();
                SqlDataAdapter da = new SqlDataAdapter("select * from bus",cnx);
                SqlCommandBuilder cmdBui = new SqlCommandBuilder(da);

                //bech t9arin bin local w l 7a9aniya w tbidl
                //yhiz mil data table w ybdl fil table
                da.Update(DSBus, "TLBus");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erreur enregistrement : " + ex.Message);
            }
            finally
            {
                cnx.Close();
            }

        }


    }
}

using metiers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class LocationDAO
    {
            public static DataSet DSLoc = new DataSet();
            private SqlConnection cnx;

            public void chargerBusLocation()
            {
                try
                {
                    cnx = Connexion.GetInstance();                    
                        SqlDataAdapter daBus = new SqlDataAdapter("select * from bus", cnx);
                        daBus.Fill(DSLoc, "TLBus");
                                       
                        SqlDataAdapter daLoc = new SqlDataAdapter("select * from location", cnx);
                        daLoc.Fill(DSLoc, "TLLocation");
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur chargement locations : " + ex.Message);
                }
                finally { cnx.Close(); }
            }

            public void ajouterLocation(Location loc)
            {
                DataTable dtLoc = DSLoc.Tables["TLLocation"];
                DataRow dr = dtLoc.NewRow();
                dr[0] = loc.DateDebLoc;
                dr[1] = loc.ImmatBus.Immat;//lina lezemaaa immat 5tr n5abi fil base 9e3da !!!!!
                //rodbelik thot ken bus
                dr[2] = loc.DateFinLoc;
                dr[3] =(float)loc.Montant;
                dr[4] = loc.Client;
                dtLoc.Rows.Add(dr);
            }

        public bool enregistrerLocation()
        {
            try
            {
                cnx = Connexion.GetInstance();
                SqlDataAdapter da = new SqlDataAdapter("select * from location", cnx);
                //5tr 3ndy update
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(DSLoc, "TLLocation");
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erreur enregistrement locations : " + ex.Message);
                return false;
            }
            finally { cnx.Close(); }
        }
    }
    }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using metiers;
using DAO;
using System.Data;
using System.Net;

namespace controller
{
    public class BusController
    {

        public static List<Bus> LesBus = new List<Bus>();
        public static List<Bus> GetBus()
        {
            if (BusDAO.DSBus.Tables["TLBus"] == null)
            {
                BusDAO busDAO = new BusDAO();
                busDAO.chargerBus();
            }
            LesBus.Clear();
            //or n3awd nisn3ha
            //LesBus = new List<Bus>();
            foreach (DataRow dr in BusDAO.DSBus.Tables["TLBus"].Rows) {
                Bus b = new Bus(dr[0].ToString(), dr[1].ToString(), Convert.ToDateTime(dr[2]),
                    Convert.ToInt32(dr[3]), Convert.ToDouble(dr[4]), Convert.ToDouble(dr[5]));
                LesBus.Add(b);
            }
            return LesBus;
            
        }
        public static bool AjouterBus(Bus bus)
        {
            BusDAO b = new BusDAO();
            if (LesBus.Contains(bus))
            {
                return false;
            }
            b.ajouter(bus);
            LesBus.Add(bus);
            return true;

        }
        public static void enregister()
        {
            BusDAO b = new BusDAO();
            b.Enregistrer();
        }
        //chercher par capacite
        //lina bech nist3ml l datatable donc lezem nthabit
        public static List<Bus>  chercherCap(int capacite)
        {
             List<Bus> LesBusC = new List<Bus>();
            if (BusDAO.DSBus.Tables["TLBus"] == null)
            {
                BusDAO busDAO = new BusDAO();
                busDAO.chargerBus();
            }
            foreach (DataRow dr in BusDAO.DSBus.Tables["TLBus"].Rows)
            {
                if (Convert.ToInt32(dr[3]) == capacite)
                {
                    Bus b = new Bus(dr[0].ToString(), dr[1].ToString(), Convert.ToDateTime(dr[2]),
                        Convert.ToInt32(dr[3]), Convert.ToDouble(dr[4]), Convert.ToDouble(dr[5]));
                    LesBusC.Add(b);
                }
            }
            return LesBusC;
        }
    }
}

using DAO;
using metiers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controller
{
    //3 cas fil date
    public class LocController
    {
        public static List<Location> LesLocations = new List<Location>();

        public static List<Location> GetLocations()
        {
            if (LocationDAO.DSLoc.Tables["TLLocation"]==null) { 
                LocationDAO loc = new LocationDAO();
                loc.chargerBusLocation(); 
            }


              //LesLocations.Clear();
              List<Bus>lesbus=BusController.GetBus();
            LesLocations = new List<Location>();
            DataTable dtLoc = LocationDAO.DSLoc.Tables["TLLocation"];

                foreach (DataRow dr in dtLoc.Rows)
                {
                Bus bus = null;
                foreach (Bus b in lesbus)
                {
                    if (b.Immat.Equals(dr[1].ToString()))
                    { 
                        bus = b; 
                        break;
                    }

                }
                //lina rodbelik l ajout t3mlo fi wst l foreach
                    LesLocations.Add(new Location(
                        Convert.ToDateTime(dr[0].ToString()), bus,
                        Convert.ToDateTime(dr[2].ToString()), dr[4].ToString()));
          

            }
            return LesLocations;
        }


        public static bool AjouterLocation(Location location)
        {
            if (LocationDAO.DSLoc.Tables["TLLocation"] == null)
            {
                LesLocations = GetLocations();
            }
            //car je vais faire un parcour lezmha mouch vide 
            //fi lo5ra miselch vide

            var result = from l in LesLocations
                         where l.ImmatBus.Immat.Equals(location.ImmatBus.Immat) && 
                         (
                             (location.DateDebLoc >= l.DateDebLoc && location.DateDebLoc <= l.DateFinLoc)
                             ||
                             (location.DateFinLoc >= l.DateDebLoc && location.DateFinLoc <= l.DateFinLoc)
                             ||
                             (location.DateDebLoc <= l.DateDebLoc && location.DateFinLoc >= l.DateFinLoc)
                         )
                         select l;

            if (result.Count() > 0)
                return false;

            new LocationDAO().ajouterLocation(location);
            LesLocations.Add(location);
            return true;
        }


        //from idara where stylo select stylo 
        public static bool EnregistrerLocation()
            {
               if( new LocationDAO().enregistrerLocation())
                { return true; }
               return false;
            }

        public static void EnregistrerLocationn()
        {
            new LocationDAO().enregistrerLocation();
           // w heki tkoun void zeda
         //  kenhy bool compile
         // mais le true/false est ignoré !

        }
        //sans linq
        public static List<Location> ChercherParJour(DateTime jour)
            {
                List<Location> result = new List<Location>();
                foreach (Location loc in LesLocations)
                    if (loc.DateDebLoc.Date == jour.Date)
                        result.Add(loc);
                return result;
            }
        //avec linq
        public static List<Location> ChercherParJourr(DateTime jour)
        {
            if (LocationDAO.DSLoc.Tables["TLLOC"] == null)
            {
                LesLocations = GetLocations();
            }
            var LocationsBus = from l in LesLocations
                               where l.DateDebLoc.Date.Equals((jour))
                               select l;

            return LocationsBus.ToList();
        }

        //sans linq
        public static List<Location> ChercherParBuss(Bus b)
            {
                List<Location> result = new List<Location>();
                foreach (Location loc in LesLocations)
                    if (loc.ImmatBus.Equals(b)) 
                    result.Add(loc);
                return result;
            }
        //avec linq
        public static List<Location> ChercherParBus(Bus bus)
        {
            if (LocationDAO.DSLoc.Tables["TLLOC"] == null)
            {
                LesLocations = GetLocations();
            }
            var LocationsBus = from l in LesLocations
                               where l.ImmatBus.Equals(bus)
                               select l;
            return LocationsBus.ToList();
        }
    }
    }

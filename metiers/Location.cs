using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metiers
{
        public class Location
        {
            // Attributs privés (clés en lecture seule)
            private DateTime dateDebLoc;
            private Bus  immatBus;

            // Autres attributs
            private DateTime dateFinLoc;
            private double montant;
            private string client;

            public Location(DateTime dateDebLoc, Bus immatBus, DateTime dateFinLoc, string client)

            {
            if (immatBus == null)
                throw new ArgumentNullException(nameof(immatBus), "Le bus ne peut pas être null.");
            this.dateDebLoc = dateDebLoc;
                this.immatBus = immatBus;
                this.dateFinLoc = dateFinLoc;
                this.client = client;
               this.montant=(double)(dateFinLoc -dateDebLoc ).TotalDays*immatBus.PrixJour;
            }

        public DateTime DateDebLoc { get => dateDebLoc; set => dateDebLoc = value; }
        public Bus ImmatBus { get => immatBus; set => immatBus = value; }
        public DateTime DateFinLoc { get => dateFinLoc; set => dateFinLoc = value; }
        public double Montant { get => montant; set => montant = value; }
        public string Client { get => client; set => client = value; }

        public override bool Equals(object obj)
        {
            return obj is Location location &&
                   dateDebLoc == location.dateDebLoc &&
                   immatBus == location.immatBus;
        }
    }
    }


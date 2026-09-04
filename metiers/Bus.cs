using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metiers
{
        public class Bus
        {
            // Attributs privés
            private string immat;
            private string marque;
            private DateTime dateAchat;
            private int capacite;
            private double prixAchat;
            private double prixJour;

        public string Immat { get => immat; set => immat = value; }
        public string Marque { get => marque; set => marque = value; }
        public DateTime DateAchat { get => dateAchat; set => dateAchat = value; }
        public int Capacite { get => capacite; set => capacite = value; }
        public double PrixAchat { get => prixAchat; set => prixAchat = value; }
        public double PrixJour { get => prixJour; set => prixJour = value; }



        // Constructeur
        public Bus(string immat, string marque, DateTime dateAchat, int capacite, double prixAchat, double prixJour)
            {
                this.immat = immat;
                this.marque = marque;
                this.dateAchat = dateAchat;
                this.capacite = capacite;
                this.prixAchat = prixAchat;
                this.prixJour = prixJour;
            }

       /* public override string ToString()
        {
            return immat;
        }*/
       //bil data source ki naffichi bus tji obj 5tr ma3ndich tostring 
       //fil rows tji 5tr n3ml l obj.immat
       //sinon direct obj w n3ml to string
        public override bool Equals(object obj)
        {
            return obj is Bus bus &&
                   immat == bus.immat &&
                   marque == bus.marque;
        }
    }
    }


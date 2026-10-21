using System;
using System.Collections.Generic;
using System.Text;

namespace patronBuilder
{
    //Classe qui represente un ordinateur
    public class Ordinateur
    {
        private int ram;
        private string carteGraphique = "";
        private int memoire;

        public int Ram
        {
            get {  return ram; }
            set { ram = value; }
        }

        public string CarteGraphique
        {
            get { return carteGraphique; }
            set {  carteGraphique = value; }
        }

        public int Memoire
        {
            get { return memoire; }
            set {  memoire = value; }

        }
    }
}

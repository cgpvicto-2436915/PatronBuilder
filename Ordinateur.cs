using System;
using System.Collections.Generic;
using System.Text;

namespace patronBuilder
{
    //Classe qui represente un ordinateur
    public class Ordinateur
    {
        //quantite de memoire vive en Go
        private int ram;

        //nom de la carte graphique
        private string carteGraphique = "";

        //quantite de memoire en Go
        private int memoire;

        /// <summary>
        /// aceesseur a la quantite de memoire vive
        /// </summary>
        public int Ram
        {
            get {  return ram; }
            set { ram = value; }
        }

        /// <summary>
        /// aceesseur a la carte graphique
        /// </summary>
        public string CarteGraphique
        {
            get { return carteGraphique; }
            set {  carteGraphique = value; }
        }

        /// <summary>
        /// aceesseur a la quantite de memoire
        /// </summary>
        public int Memoire
        {
            get { return memoire; }
            set {  memoire = value; }

        }
    }
}

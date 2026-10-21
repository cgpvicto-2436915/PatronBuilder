using System;
using System.Collections.Generic;
using System.Text;

namespace patronBuilder
{
    public class MonteurPCBureau:MonteurPC
    {
        private Ordinateur ordinateur = new Ordinateur();
        public void AjouterCarteGraphique()
        {
            ordinateur.CarteGraphique = "integree";
        }

        public void AjouterMemoire()
        {
            ordinateur.Memoire = 500;
        }

        public void AjouterRam()
        {
            ordinateur.Ram = 16;
        }

        public Ordinateur AvoirOrdinateur()
        {
            return ordinateur;
        }
    }
}

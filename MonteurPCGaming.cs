using System;
using System.Collections.Generic;
using System.Text;

namespace patronBuilder
{
    public class MonteurPCGaming : MonteurPC
    {
        private Ordinateur ordinateur = new Ordinateur();
        public void AjouterCarteGraphique()
        {
            ordinateur.CarteGraphique = "RTX 4070";
        }

        public void AjouterMemoire()
        {
            ordinateur.Memoire = 2000;
        }

        public void AjouterRam()
        {
            ordinateur.Ram = 64;
        }

        public Ordinateur AvoirOrdinateur()
        {
            return ordinateur;
        }
    }
}

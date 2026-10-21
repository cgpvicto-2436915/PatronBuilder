using System;
using System.Collections.Generic;
using System.Text;

namespace patronBuilder
{
    public class DirecteurPC
    {
        private MonteurPC monteurPC;

        public void setOrdinateur(MonteurPC monteur)
        {
            monteurPC = monteur;
        }

        public void assembler()
        {
            if (monteurPC != null) {
                monteurPC.AjouterCarteGraphique();
                monteurPC.AjouterMemoire();
                monteurPC.AjouterRam();
            }
        }

         public Ordinateur getOrdinateur()
        {
            return monteurPC.AvoirOrdinateur();
        }

    }
}

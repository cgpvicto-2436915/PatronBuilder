using System;
using System.Collections.Generic;
using System.Text;

namespace patronBuilder
{
    public interface MonteurPC
    {
        void AjouterRam();
        void AjouterCarteGraphique();
        void AjouterMemoire();
        Ordinateur AvoirOrdinateur();
    }
}

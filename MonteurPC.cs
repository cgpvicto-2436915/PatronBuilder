using System;
using System.Collections.Generic;
using System.Text;

namespace patronBuilder
{
    public interface MonteurPC
    {
        /// <summary>
        /// Signature de la methode qui ajoute la 
        /// memoire vive a l'ordinateur en construction
        /// </summary>
        void AjouterRam();

        /// <summary>
        /// Signature de la methode qui ajoute la 
        /// carte graphique a l'ordinateur en construction
        /// </summary>
        void AjouterCarteGraphique();

        /// <summary>
        /// Signature de la methode qui ajoute la 
        /// memoire a l'ordinateur en construction
        /// </summary>
        void AjouterMemoire();

        /// <summary>
        /// Signature de la methode qui retourne 
        /// l'ordinateur qui a été construit
        /// </summary>
        Ordinateur AvoirOrdinateur();
    }
}

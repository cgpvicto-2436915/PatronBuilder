using System;
using System.Collections.Generic;
using System.Text;

namespace patronBuilder
{
    public class MonteurPCGaming : MonteurPC
    {
        private Ordinateur ordinateur = new Ordinateur();

        /// <summary>
        /// Étape d'ajout de la carte graphique au pc en construction
        /// pour un pc gaming
        /// </summary>
        public void AjouterCarteGraphique()
        {
            ordinateur.CarteGraphique = "RTX 4070";
        }

        /// <summary>
        /// Étape d'ajout de la mémoire au pc en construction
        /// pour un pc gaming
        /// </summary>
        public void AjouterMemoire()
        {
            ordinateur.Memoire = 2000;
        }

        /// <summary>
        /// Étape d'ajout de la mémoire vive au pc en construction
        /// pour un pc gaming
        /// </summary>
        public void AjouterRam()
        {
            ordinateur.Ram = 64;
        }

        /// <summary>
        /// Retourne l'ordinateur de jeu construit.
        /// </summary>
        /// <returns>Ordinateur construit</returns>
        public Ordinateur AvoirOrdinateur()
        {
            return ordinateur;
        }
    }
}

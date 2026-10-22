using System;
using System.Collections.Generic;
using System.Text;

namespace patronBuilder
{
    public class MonteurPCBureau:MonteurPC
    {
        private Ordinateur ordinateur = new Ordinateur();

        /// <summary>
        /// Étape d'ajout de la carte graphique au pc en construction
        /// pour un pc de bureau
        /// </summary>
        public void AjouterCarteGraphique()
        {
            ordinateur.CarteGraphique = "integree";
        }

        /// <summary>
        /// Étape d'ajout de la mémoire au pc en construction
        /// pour un pc de buerau
        /// </summary>

        public void AjouterMemoire()
        {
            ordinateur.Memoire = 500;
        }


        /// <summary>
        /// Étape d'ajout de la mémoire vive au pc en construction
        /// pour un pc de bureau
        /// </summary>

        public void AjouterRam()
        {
            ordinateur.Ram = 16;
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

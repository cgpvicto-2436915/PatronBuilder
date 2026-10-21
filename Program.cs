namespace patronBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirecteurPC directeur = new DirecteurPC();

            MonteurPC monteurPcGaming = new MonteurPCGaming();
            MonteurPC monteurPcBureau = new MonteurPCBureau();

            directeur.setOrdinateur(monteurPcGaming);
            directeur.assembler();
            Ordinateur ordiGaming = directeur.getOrdinateur();

            afficher(ordiGaming);


            Console.WriteLine("---------------------------------------");

            directeur.setOrdinateur(monteurPcBureau);
            directeur.assembler();
            Ordinateur ordiBureau = directeur.getOrdinateur();

            afficher(ordiBureau);

            void afficher(Ordinateur ordi)
            {
                Console.WriteLine("Ordinateur :");
                Console.WriteLine("Ram : " + ordi.Ram + "go");
                Console.WriteLine("Memoire : " + ordi.Memoire + "go");
                Console.WriteLine("Carte graphique : " + ordi.CarteGraphique);
            }

        }
    }
}

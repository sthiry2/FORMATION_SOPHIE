using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;


namespace CreationThread
{
    class Program
    {
        #region Methodes A Executer dans un autre thread car trop gourmande
        private static void MethodeTresLente()
        {
            Console.WriteLine(DateTime.Now.ToString() + " --- MethodeTresLente: Je vais faire quoi?");
            Thread.Sleep(3000);
            Console.WriteLine(DateTime.Now.ToString() + " --- MethodeTresLente: Je sais toujours pas..");
            Thread.Sleep(1000);
            Console.WriteLine(DateTime.Now.ToString() + " --- MethodeTresLente: Les autres ont qu'a m'attendre..");
            Thread.Sleep(2000);

        }


        private static void Telecharger(object urls)
        {
            string[] mesurls = (string[])urls;


            int i = 0;
            foreach (string url in mesurls)
            {

                try
                {
                    WebClient wc = new WebClient();
                    wc.DownloadFile(url, System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/doc" + i++ + ".pdf");
                    wc.Dispose();
                    Thread.Sleep(4000);
                    Console.WriteLine(DateTime.Now.ToString() + " --- Telecharger: Téléchargement de " + url + " dans le thread " + Thread.CurrentThread.GetHashCode());
                }
                catch (Exception e)
                {
                    Console.WriteLine(DateTime.Now.ToString() + " --- Telecharger: Impossible  de télécharger le fichier" + url + " dans le thread " + Thread.CurrentThread.GetHashCode());
                }
            }

            

        }



        #endregion

        //static void Main(string[] args)
        //{
        //    int valeur = Thread.CurrentThread.GetHashCode();


        //    Program.MethodeTresLente();

        //    Console.WriteLine("il a enfin fini! Je vais pouvoir télécharger mes documents");


        //    string[] urls = new string[]
        //        {
        //         @"https://www.arfp.asso.fr/medias/orientation-formation/Fiches%20Com/1.Offres%20du%20SOFP.pdf",
        //         @"https://www.arfp.asso.fr/medias/orientation-formation/Fiches%20Com/CHIFFRES%20OFP%202019.pdf"
        //        };

        //    Program.Telecharger(urls);

        //    Console.WriteLine("les telechargement sont finis..Je peux aller me promener");

        //    Console.ReadKey();
        //}


        static void Main(string[] args)
        {
            int valeur = Thread.CurrentThread.GetHashCode();

            //Lancement de MethodeTresLente dans un Thread
            Thread threadNeNecessitantPasDeParametre = new Thread(new ThreadStart(Program.MethodeTresLente));
            threadNeNecessitantPasDeParametre.Start();


            Console.WriteLine(DateTime.Now.ToString() + " ThreadPrincipale: MethodeTresLente a surement pas encore fini! Je vais quand meme pouvoir télécharger mes documents");


            string[] urls = new string[]
                {
                 @"https://www.arfp.asso.fr/medias/orientation-formation/Fiches%20Com/1.Offres%20du%20SOFP.pdf",
                 @"https://www.arfp.asso.fr/medias/orientation-formation/Fiches%20Com/CHIFFRES%20OFP%202019.pdf"
                };

            //Lancement de Telecharger dans un Thread
            Thread thNecessitantUnParametre = new Thread(new ParameterizedThreadStart(Program.Telecharger));
            thNecessitantUnParametre.Start(urls);

            Console.WriteLine(DateTime.Now.ToString() + " --- ThreadPrincipale: Fin de tous les telechargements!");

            //Attente que le Thread thNecessitantUnParametre se termine
            bool fini = thNecessitantUnParametre.Join(5000); // 5000 ms

            Console.WriteLine(DateTime.Now.ToString() + " ThreadPrincipale: J'ai attendu pendant 5 secondes la fin des telechargement réalisé dans le  thread " + thNecessitantUnParametre.GetHashCode());

            if (!fini) // si pas fini
            {
                Console.WriteLine(DateTime.Now.ToString() + " ThreadPrincipale: Comme il a pas fini, je continue a attendre indefiniment!");
                thNecessitantUnParametre.Join();
            }

            Console.WriteLine(DateTime.Now.ToString() + " ThreadPrincipale: C'est terminé!");
            Console.ReadKey();
        }



    }
}

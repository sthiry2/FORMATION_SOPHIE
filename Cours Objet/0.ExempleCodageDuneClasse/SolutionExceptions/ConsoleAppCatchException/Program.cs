using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCatchException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                string chemin = @".\test.txt";
                Console.WriteLine(LireDsFichier(chemin));
            }
            catch (Exception e)
            {
                //tracer l'erreur dans un fichier Log
                Console.WriteLine("Une erreur est survenu! Veuillez contacter l'editeur");
            }
            
        }
        static string LireDsFichier(string _cheminDuFichier)
        {
            string alire = null;

            StreamReader file = null;

            try
            {
                file = new StreamReader(_cheminDuFichier);
                alire = file.ReadLine();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Error founding file {0}. Message = {1}", _cheminDuFichier, e.Message);
                throw new FileNotFoundException("plus d'info" + e.Message,e);
            }
            catch (IOException e)
            {
                Console.WriteLine("Error accessing to file {0}. Message = {1}", _cheminDuFichier, e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error reading file {0}. Message = {1}", _cheminDuFichier, e.Message);
            }
            finally
            {
                if (file != null)
                {
                    file.Close();
                }
            }

            return alire;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMUE5Uebung
{
    class Program
    {
        // darf nicht verändert werden!
        static List<string> obstListe = new List<string>() { "Pflaume", "Honigmelone", "Birne", "Traube", "Limone", "Birne", "Pflaume", "Birne", "Mango", "Limone", "Mango", "Birne", "Dattel", "Mango", "Apfel", "Kirsche", "Kirsche", "Birne", "Limone", "Apfel", "Apfel", "Dattel", "Birne", "Traube", "Kirsche", "Erdbeere", "Feigen", "Birne", "Apfel", "Erdbeere", "Erdbeere", "Feigen", "Limone", "Apfel", "Birne", "Erdbeere", "Mango", "Mango", "Honigmelone", "Erdbeere", "Limone", "Zitrone", "Honigmelone", "Erdbeere", "Apfel", "Feigen", "Birne", "Traube", "Apfel", "Pflaume" };
        // darf nicht verändert werden!
        static string obstSchüssel = "Pflaumen;Apfel;Limonen;Brombeere;Brombeere;Apfel;Mango;Limone;Erdbeer;Apfel;Birnen;Wassermelone;Feigen;Apfel;Trauben;Birnen;Zitronen;Apfel;Birnen;Feigen;;;";

        // hier implementieren
        internal static int DateiLesen1()
        {
            // aktuelles Verzeichnis ist /bin/debug ... daher 2 Verzeichnisse hinauf
            StreamReader stream = new StreamReader(@"../../uebung01.csv");
            // solange nicht "end of stream" erreicht ist ... führe den folgenden Block aus
            while (stream.EndOfStream == false)
            {
                string line = stream.ReadLine();
            }
            // den stream am Ende des Lesens wieder schliessen!
            stream.Close();
            return 0;
        }

        // hier implementieren
        private static List<string> ListeOhneBirnen(List<string> obstL)
        {
            throw new NotImplementedException();
        }


        // Implementiere eine Funktion: ObstKlein
        // diese Funktion bekommt einen string obst
        // wenn das obst ein Apfel, Birnen oder Brombere ist, dann gibt die Funktion das Obst als Mus zurück .. dh aus "Apfel" wird "Apfelmus"
        // für alle anderen Obstsorten werden Würfel zurückgegeben z.B. Feigenwürfel

        // Implementiere eine Funktion: MacheObstSalat
        // Diese Funktion bekommt einen String ObstSchüssel - der Obst durch ; getrennt enthält
        // Schreibt den Code der den übergebenen String nach ";" aufteilt und für jedes Obst die Funktion ObstKlein aufruft und das Ergebnis am 
        // Bildschirm ausgibt. Achtung das Ende der ObstSchüssel ist etwas, das ihr beachten müsst.


        // hier ObstKlein implementieren
        // hier MacheObstSalat implementieren



        static void Main(string[] args)
        {
            Console.WriteLine($"Summe 1: {DateiLesen1()}"); // Summe 1: 11643
            Console.ReadKey();
            Console.WriteLine($"Liste ohne Birnen: {ListeOhneBirnen(obstListe).Count}"); // Liste ohne Birnen: 41
            Console.ReadKey();
            // MacheObstSalat(obstSchüssel);
            // PflaumenwürfelApfelmusLimonenwürfelBrombeerewürfelBrombeerewürfelApfelmusMangowürfelLimonewürfelErdbeerwürfelApfelmusBirnenmusWassermelonewürfelFeigenwürfelApfelmusTraubenwürfelBirnenmusZitronenwürfelApfelmusBirnenmusFeigenwürfel
            Console.ReadKey();
        }


    }
}

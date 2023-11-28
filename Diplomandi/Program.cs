using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplomandi
{
    internal class Program
    {
        static void Main()
        {
            List<Diplomato> elencoDiplomati = new List<Diplomato>();

            while (true)
            {
                Console.WriteLine("1. Inserisci diplomato");
                Console.WriteLine("2. Stampa tutti i diplomati");
                Console.WriteLine("3. Stampa diplomati abili ai concorsi");
                Console.WriteLine("4. Esci");

                Console.Write("Scelta: ");
                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        InserisciDiplomato(elencoDiplomati);
                        break;

                    case "2":
                        StampaTuttiDiplomati(elencoDiplomati);
                        break;

                    case "3":
                        StampaDiplomatiAbili(elencoDiplomati);
                        break;

                    case "4":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Scelta non valida. Riprova.");
                        break;
                }
            }
        }

        static void InserisciDiplomato(List<Diplomato> elencoDiplomati)
        {
            Console.Write("Inserisci nome: ");
            string nome = Console.ReadLine();

            Console.Write("Inserisci cognome: ");
            string cognome = Console.ReadLine();

            Console.Write("Inserisci voto: ");
            int voto = int.Parse(Console.ReadLine());

            Diplomato nuovoDiplomato = new Diplomato(nome, cognome, voto);
            elencoDiplomati.Add(nuovoDiplomato);

            Console.WriteLine("Diplomato inserito con successo!");
        }

        static void StampaTuttiDiplomati(List<Diplomato> elencoDiplomati)
        {
            Console.WriteLine("Elenco di tutti i diplomati:");

            foreach (Diplomato diplomato in elencoDiplomati)
            {
                Console.WriteLine(diplomato);
            }
        }

        static void StampaDiplomatiAbili(List<Diplomato> elencoDiplomati)
        {
            Console.WriteLine("Diplomati abili ai concorsi:");

            foreach (Diplomato diplomato in elencoDiplomati)
            {
                if (diplomato.EligibileConcorso())
                {
                    Console.WriteLine(diplomato);
                }
            }
        }
    }

    class Diplomato
    {
        public string Nome { get; }
        public string Cognome { get; }
        public int Voto { get; }

        public Diplomato(string nome, string cognome, int voto)
        {
            Nome = nome;
            Cognome = cognome;
            Voto = voto;
        }

        public override string ToString()
        {
            return $"{Nome} {Cognome} - Voto: {Voto}";
        }

        public bool EligibileConcorso()
        {
            if (Voto >= 42 && Voto <= 60)
            {
                return true; // Vecchi diplomati abili ai concorsi
            }
            else if (Voto >= 70 && Voto <= 100)
            {
                return true; // Nuovi diplomati abili ai concorsi
            }

            return false; // Non abili ai concorsi
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplomandi
{
    internal class Program
    {
        class Diplomati
        {
            protected string _nome;
            protected string _cognome;
            protected int _voto;

            public void SetNome(string nome)
            {
                _nome = nome;
            }

            public void SetCognome(string cognome)
            {
                _cognome = cognome;
            }

            public void SetVoto(int voto)
            {
                if (voto >= 36 && voto <= 100) this._voto = voto;
                else Console.WriteLine("Il voto deve essere compreso tra 36 e 100");

            }

            public void Stampa(Diplomati[] myArr, int counter)
            {
                for (int i = 0; i < counter; i++)
                {
                    Console.WriteLine(myArr[i]._nome + " " + myArr[i]._cognome + " " + myArr[i]._voto);
                }
            }

            public void StampaAbili(Diplomati[] myArr, int counter)
            {
                for (int i = 0; i < counter; i++)
                {
                    //VECCHI
                    if (myArr[i]._voto >= 36 && myArr[i]._voto <= 60)
                    {
                        if (myArr[i]._voto >= 42)
                        {
                            Console.WriteLine($"Il vecchio diplomato {myArr[i]._nome} {myArr[i]._cognome} con un voto di {myArr[i]._voto} è abile ai concorsi");
                        }
                        else
                        {
                            Console.WriteLine($"Il vecchio diplomato {myArr[i]._nome} {myArr[i]._cognome} con un voto di {myArr[i]._voto} non è abile ai concorsi");
                        }

                    }
                    else //NUOVI
                    {
                        if (myArr[i]._voto >= 70)
                        {
                            Console.WriteLine($"Il nuovo diplomato {myArr[i]._nome} {myArr[i]._cognome} con un voto di {myArr[i]._voto} è abile ai concorsi");
                        }
                        else
                        {
                            Console.WriteLine($"Il nuovo diplomato {myArr[i]._nome} {myArr[i]._cognome} con un voto di {myArr[i]._voto} non è abile ai concorsi");
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int voto = 0;
            int counter = 0;
            Diplomati[] diplomati = new Diplomati[100];
            for (int i = 0; i < 5; i++)
            {
                Diplomati dip = new Diplomati();
                Console.WriteLine("Inserire il Nome: ");
                dip.SetNome(Console.ReadLine());
                Console.WriteLine("Inserire il Cognome: ");
                dip.SetCognome(Console.ReadLine());
                do
                {
                    Console.WriteLine("Inserire il Voto: ");
                    voto = int.Parse(Console.ReadLine());
                    dip.SetVoto(voto);
                } while (voto < 36 || voto > 100);

                diplomati[i] = dip;
                counter++;

            }
            Diplomati dip1 = new Diplomati();
            dip1.Stampa(diplomati, counter);
            dip1.StampaAbili(diplomati, counter);
            Console.ReadLine();
        }
    }
}

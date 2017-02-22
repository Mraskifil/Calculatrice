using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Tina.Saceanu
{
    class Program
    {
        public static int nr1;
        public static int nr2;

        public struct Operation
        {
            public int Addition(int nr1, int nr2)
            {
                return nr1 + nr2;
            }

            public int Soustraction(int nr1, int nr2)
            {
                return nr1 - nr2;
            }

            public int Multiplication(int nr1, int nr2)
            {
                return nr1 * nr2;
            }

            public int Division(int nr1, int nr2)
            {
                return nr1 / nr2;
            }

        }


        static void Main(string[] args)
        {


            //A - Créer une calculatrice


            bool reponse = true;
            List<string> Calculs = new List<string>();
            while (reponse)
            {
                Console.WriteLine("Que voulez-vous faire: 1.Nouveau calcul; 2.Afficher tous les calculs. ");
                int choix;
                int.TryParse(Console.ReadLine(), out choix);
                List<char> ListeCalc = new List<char>();

                if (choix == 1)
                {
                    Operation oper = new Operation();
                    Console.WriteLine("Entrez votre calcul ");
                    string calcul = Console.ReadLine();
                    char[] calc = calcul.ToCharArray();
                    int operation = 0;
                    char op = ' ';
                    string nr1s = " ";
                    string nr2s = " ";
                    foreach (char item in calc)
                    {
                        if (item != ' ')
                        {
                            ListeCalc.Add(item);
                        }
                    }
                    for (int a = 0; a < ListeCalc.Count; a++)
                    {
                        if (!char.IsDigit(ListeCalc[a]))
                        {
                            operation = a;
                            op = ListeCalc[a];
                        }
                    }
                    for (int b = 0; b < operation; b++)
                    {
                        nr1s = string.Concat(nr1s, ListeCalc[b]);
                        int.TryParse(nr1s, out nr1);
                    }
                    for (int c = operation + 1; c <= ListeCalc.Count - 1; c++)
                    {
                        nr2s = string.Concat(nr2s, ListeCalc[c]);
                        int.TryParse(nr2s, out nr2);
                    }
                    if (op == '+')
                    {
                        Console.WriteLine("Le resultat est: " + oper.Addition(nr1, nr2));
                        string plus = string.Concat(nr1 + "+" + nr2 + "= ", oper.Addition(nr1, nr2));
                        Calculs.Add(plus);
                    }
                    else if (op == '-')
                    {
                        Console.WriteLine("Le resultat est: " + oper.Soustraction(nr1, nr2));
                        string min = string.Concat(nr1 + "+" + nr2 + "= ", oper.Soustraction(nr1, nr2));
                        Calculs.Add(min);
                    }
                    else if (op == '*')
                    {
                        Console.WriteLine("Le resultat est: " + oper.Multiplication(nr1, nr2));
                        string fois = string.Concat(nr1 + "+" + nr2 + "= ", oper.Multiplication(nr1, nr2));
                        Calculs.Add(fois);
                    }
                    else if (op == '/')
                    {
                        Console.WriteLine("Le resultat est: " + oper.Division(nr1, nr2));
                        string div = string.Concat(nr1 + "+" + nr2 + "= ", oper.Division(nr1, nr2));
                        Calculs.Add(div);
                    }
                }
                else if (choix == 2)
                {
                    foreach (string item in Calculs)
                    {
                        Console.WriteLine(item);
                    }
                }
                else
                {
                    reponse = false;
                }
            }


                Console.ReadLine();
        }
    }
}

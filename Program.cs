using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stunde_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string nochmal = "J";
            do
            {
                Console.WriteLine("Zahlen Systeme:");
                Console.WriteLine("1- Umwandlung von dezimal zu binär.");
                Console.WriteLine("2- Umwandlung von binäer zu dezimal.");
                Console.WriteLine("3- Umwandlung von dezimal zu hexadezimal.");
                Console.WriteLine("4- Umwandlung von hexadezimal zu dezimal.");
                Console.Write("Auswahl: ");
                int auswahl = Convert.ToInt32(Console.ReadLine());

                int dezimaleingabe;
                string binäreingabe;
                string hexadezimaleingabe;

                switch (auswahl)
                {
                    
                    case 1:

                        Console.WriteLine("Dezimalzahl eingeben:");
                        dezimaleingabe = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("[" + dezimaleingabe + "]_10 = [" + dezimalZuBinär(dezimaleingabe) + "]_2");

                        break;

                    case 2:

                        Console.WriteLine("Binärzahl eingeben:");
                        binäreingabe = Console.ReadLine();
                        Console.WriteLine("[" + binäreingabe + "]_2 = [" + binärZuDezimal(binäreingabe) + "]_10");

                        break;

                    case 3:

                        Console.WriteLine("Dezimalzahl eingeben:");
                        dezimaleingabe = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("[" + dezimaleingabe + "]_10 = [" + dezimalZuHexadezimal(dezimaleingabe) + "]_16");

                        break;

                    case 4:

                        Console.WriteLine("Hexadezimalzahl eingeben:");
                        hexadezimaleingabe = Console.ReadLine();
                        Console.WriteLine("[" + hexadezimaleingabe + "]_16 = [" + hexadezimalZuDezimal(hexadezimaleingabe) + "]_10");

                        break;

                    default:

                        Console.WriteLine("Auswahl ungültig.");

                        break;

                }

                Console.WriteLine("Nochmal? (J/N)");
                nochmal = Console.ReadLine();
            } while (nochmal == "J" || nochmal == "j");

        }

        static int binärZuDezimal(string binärzahl)
        {
            int dezimalzahl = 0;

            for (int i = 0; i < binärzahl.Length; i++)
            {
                int l = binärzahl.Length;

                int intBinär = Convert.ToInt32(binärzahl[i].ToString());

                dezimalzahl += intBinär * (int)Math.Pow(2, l - i - 1); //i-1 weil i als 0 anfängt
            }

            return dezimalzahl;
        }

        static string dezimalZuBinär(int dezimalzahl)
        {
            string binärzahl = "";

            int Rest;
            int Quocient = dezimalzahl;

            while (Quocient != 0)
            {
                Rest = Quocient % 2;

                Quocient /= 2; // Quocient = Quocient / 2

                binärzahl = Rest + binärzahl; //entgegengesetze Reihenfolge!! (als binärzahl += Rest;)
                                              // Konkatenation ist nicht kommutativ

            }

            return binärzahl;
        }

        static int BuchstabeZuZahl(string buchstabe)
        {
            int zahl;
            //if (Convert.ToInt32(buchstabe) < 10)
            //{
            //    zahl = Convert.ToInt32(buchstabe);
            //}

            //else
            //{
                switch (buchstabe.ToUpper())
                {
                    case "A":
                        zahl = 10;
                        break;
                    case "B":
                        zahl = 11;
                        break;
                    case "C":
                        zahl = 12;
                        break;
                    case "D":
                        zahl = 13;
                        break;
                    case "E":
                        zahl = 14;
                        break;
                    case "F":
                        zahl = 15;
                        break;
                    default:
                        
                        zahl = Convert.ToInt32(buchstabe); 
                        break;
                }

           // }

            return zahl;
        }

        static string ZahlZuBuchstabe(int zahl)
        {
            string buchstabe = "";

            if(zahl < 10)
            {
                buchstabe = zahl.ToString();
            }

            else
            {
                switch (zahl)
                {
                    case 10:
                        buchstabe = "A";
                        break;
                    case 11:
                        buchstabe = "B";
                        break;
                    case 12:
                        buchstabe = "C";
                        break;
                    case 13:
                        buchstabe = "D";
                        break;
                    case 14:
                        buchstabe = "E";
                        break;
                    case 15:
                        buchstabe = "F";
                        break;
                    default:
                        buchstabe = "X";
                        break;

                }
            }
            return buchstabe;
        }

        static string dezimalZuHexadezimal(int dezimalzahl)
        {
            string hexadezimalZahl = "";

            int Rest;
            int Quocient = dezimalzahl;

            while (Quocient != 0)
            {

                Rest = Quocient % 16;

                Quocient /= 16;

                
                hexadezimalZahl = ZahlZuBuchstabe(Rest) + hexadezimalZahl;

            }
            return hexadezimalZahl;
        }

        static int hexadezimalZuDezimal(string hexadezimalzahl)
        {

            int dezimalzahl = 0;
            for(int i = 0; i < hexadezimalzahl.Length; i++)
            {
                int l = hexadezimalzahl.Length;
                int stelle = BuchstabeZuZahl(hexadezimalzahl[i].ToString());
                
                int intHexal = Convert.ToInt32(stelle);
                dezimalzahl += intHexal * (int)Math.Pow(16, l - i - 1);

            }
            return dezimalzahl;
        }

        static int Summe(int a, int b)
        {
            int summe = a + b;
            return summe;
        }
    }
}

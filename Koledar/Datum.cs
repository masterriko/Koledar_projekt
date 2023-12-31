﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koledar
{
    public class Datum : IEquatable<Datum>
    {
        private int dan;
        private int mesec;
        private int leto;
        private static readonly Dictionary<string, int> mesecStevilo = new Dictionary<string, int>()
            {
                {"januar", 1 },
                {"februar", 2 },
                {"marec", 3 },
                {"april", 4 },
                {"maj", 5 },
                {"junij", 6 },
                {"julij", 7 },
                {"avgust", 8 },
                {"september", 9 },
                {"oktober", 10 },
                {"november", 11 },
                {"december", 12 },
            };

        /// <summary>
        /// Poljuben datum
        /// </summary>
        /// <param name="dan"></param>
        /// <param name="mesec"></param>
        /// <param name="leto"></param>
        public Datum(int dan, string mesec, int leto)
        {
            Dan = dan;
            Mesec = PretvoriMesec(mesec);
            Leto = leto;
        }

        public int Dan
        {
            get { return dan; }
            private set { dan = value; }
        }
        public int Mesec
        {
            get { return mesec; }
            private set { mesec = value; }
        }
        public int Leto
        {
            get { return leto; }
            set {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Leto ne sme biti negativno");
                }
                leto = value; }
        }

        /// <summary>
        /// Odstejemo mesec, če je pogoj true, oziroma prištejemo mesec, če je pogoj false.
        /// </summary>
        /// <param name="pogoj"></param>
        public void OdstejMesec(bool pogoj)
        {
            if (pogoj)
            {
                if (Mesec == 1)
                {
                    Mesec = 12;
                    Leto -= 1;
                }
                else
                {
                    Mesec -= 1;
                }
            }
            else
            {
                if (Mesec == 12)
                {
                    Mesec = 1;
                    Leto += 1;
                }
                else
                {
                    Mesec += 1;
                }
            }
        }


        /// <summary>
        /// Funkcija pretvori mesec tipa string v število
        /// </summary>
        /// <returns>številko meseca</returns>
        public static int PretvoriMesec(string mesec)
        {

            return mesecStevilo[mesec];
        }

        /// <summary>
        /// Funkcija pretvori mesec tipa string v število
        /// </summary>
        /// <returns>številko meseca</returns>
        public static string PretvoriSteviloVMesec(int mesec)
        {
            Dictionary<int, string> steviloMesec = mesecStevilo.ToDictionary(kv => kv.Value, kv => kv.Key);
            return steviloMesec[mesec];
        }


            /// <summary>
            /// Funkcija vsebuje tabelo imen dnevov
            /// </summary>
            /// <returns>tabelo imen dnevov</returns>
            public static string[] TabelaDni()
        {
            string[] dnevi = new string[] { "ponedeljek", "torek", "sreda", "četrtek", "petek", "sobota", "nedelja"};

            return dnevi;
        }


        /// <summary>
        /// Funkcija preveri, ali je leto prestopno, ali ne
        /// </summary>
        /// <param name="leto"></param>
        /// <returns>true ali false, če je leto prestopno</returns>
        public static bool JePrestopno(int leto)
        {
            return (leto % 4 == 0 && leto % 100 != 0) || leto % 400 == 0;
        }

        /// <summary>
        /// Funkcija preveri dolžino vseh mesecev v danem letu
        /// </summary>
        /// <param name="leto"></param>
        /// <returns>tabelo dolžin mesecev za dano leto</returns>
        public static int[] DolzineMesecev(int leto)
        {
            bool jePrestopno = JePrestopno(leto);

            return new int[]
            {
                31, (jePrestopno ? 29 : 28), 31, 30, 31, 30,
                31, 31, 30, 31, 30, 31
            };
        }

        /// <summary>
        /// Funkcija za dan datum vrne kateri dan v tednu je (Zellerjev obrazec)
        /// </summary>
        /// <returns>število od 0 - 6, ki predstavlja dan v tednu. Začnemo s ponedeljkom</returns>
        public int PrviDanVMesecu()
        {
            int dan = 1;
            int mesec = Mesec;
            int leto = Leto; 

            if (mesec == 1)
            {
                mesec = 13;
                leto--;
            }
            if (mesec == 2)
            {
                mesec = 14;
                leto--;
            }

            int l = leto % 100;
            int ll = leto / 100;
            int h = dan + 13 * (mesec + 1) / 5 + l + l / 4 + ll / 4 + 5 * ll;

            return (h - 2) % 7;
        }

        /// <summary>
        /// Pogledamo koliko dni ima en mesec prej
        /// </summary>
        /// <returns>Število dni prejšnjega mesca.</returns>
        public static int PrejsnjiMesec(int mesec, int leto)
        {
            if (mesec == 0)
            {
                return Datum.DolzineMesecev(leto)[11];
            }
            
            return Datum.DolzineMesecev(leto)[mesec - 1];
        }

        /// <summary>
        /// Ali sta dva datuma enaka. Dnevov ne preverja samo leto in mesec.
        /// </summary>
        /// <param name="datum"></param>
        /// <returns></returns>
        public bool Equals(Datum datum)
        {
            return (this.Mesec == datum.Mesec && this.Leto == datum.Leto);
        }

        /// <summary>
        /// Vrnemo datum v obliki niza
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Datum: {Dan}.{Mesec}.{Leto}";
        }
    }
}

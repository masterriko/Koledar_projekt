using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koledar
{
    public class Praznik : Datum, IComparable<Datum>
    {
        private bool ponavljajoc;

        /// <summary>
        /// Praznik je extended verzija Datuma
        /// </summary>
        /// <param name="dan"></param>
        /// <param name="mesec"></param>
        /// <param name="leto"></param>
        /// <param name="ponavljajoc"></param>
        public Praznik(int dan, string mesec, int leto, bool ponavljajoc) : base(dan, mesec, leto)
        {
            this.ponavljajoc = ponavljajoc;
        }
        public bool Ponavljajoc
        {
            get { return ponavljajoc; }
        }


        /// <summary>
        /// Primerjamo Datum in Praznik. 
        /// </summary>
        /// <param name="other"></param>
        /// <returns>Če je praznik enak vrnemo 0 v nasprotnem primeru pa -1.
        /// Ostalih vrednosti ne potrebujemo zaenkrat. Lahko pa jih v prihodnosti dodamo.</returns>
        public int CompareTo(Datum other)
        {
            if (this.Ponavljajoc)
            {
                if (other.Dan == this.Dan && other.Mesec == this.Mesec)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (other.Dan == this.Dan && other.Mesec == this.Mesec && other.Leto == this.Leto)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koledar
{
    public class Praznik : Datum
    {
        private bool ponavljajoc;
        public Praznik(int dan, string mesec, int leto, bool ponavljajoc) : base(dan, mesec, leto)
        {
            this.ponavljajoc = ponavljajoc;
        }
        public bool Ponavljajoc
        {
            get { return ponavljajoc; }
        }
    }
}

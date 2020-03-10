using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balkezesek
{
    class adatok
    {
        public string nev { get; set;}
        public string elso { get; set; }
        public string utolso { get; set; }
        public int suly { get; set; }
        public int magassag { get; set; }

        public adatok(string n, string e, string u, int s, int m)
        {
            this.nev = n;
            this.elso = e;
            this.utolso = u;
            this.suly = s;
            this.magassag = m;
        }
    }
}

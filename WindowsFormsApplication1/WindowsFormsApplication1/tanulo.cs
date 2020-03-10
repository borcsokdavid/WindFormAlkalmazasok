using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class tanulo
    {
        public string Nev { get; set; }
        public string Igazolt { get; set; }
        public string Igazolatlan { get; set; }

        public tanulo(string nev, string ig, string iga)
        {
            this.Nev = nev;
            this.Igazolt = ig;
            this.Igazolatlan = iga;
        }
    }
}

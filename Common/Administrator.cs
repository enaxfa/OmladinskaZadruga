using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Administrator
    {
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String Sifra { get; set; }
        public String KorisnickoIme { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Administrator k)
                return k.KorisnickoIme == this.KorisnickoIme && k.Sifra == this.Sifra;
            return false;
        }
    }
}

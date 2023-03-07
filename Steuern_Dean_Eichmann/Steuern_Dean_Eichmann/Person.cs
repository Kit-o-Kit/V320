using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steuern_Dean_Eichmann
{
    internal class Person : ISteuerzahler
    {
        protected int einkommen;
        public bool bank;

        public int berechneSteuer()
        {
            if (bank)
            {
                return (this.einkommen / 4 + 1000);
            }
            return (this.einkommen / 4);
        }
    }
}

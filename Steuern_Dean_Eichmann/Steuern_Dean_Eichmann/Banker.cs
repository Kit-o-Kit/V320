using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steuern_Dean_Eichmann
{
    internal class Banker : Person
    {
        public bool bank;
        public int ErmittleZuVersteuerndesEinkommen()
        {
            bank = true;
            return this.einkommen;

        }
    }
}

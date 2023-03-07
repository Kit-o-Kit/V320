using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steuern_Dean_Eichmann
{
    internal class Arbeiter : Person
    {
        public int ErmittleZuVersteuerndesEinkommen()
        {
            return (this.einkommen - 2400);
        }
    }
}

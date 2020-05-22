using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfataUtilizatorv2
{
    [Flags]
    public enum CodEroare
    {
        CORECT = 0,
        NUME_VANZATOR_INCORECT = 1,
        NUME_CUMPARTOR_INCORECT = 2,
        MODEL_INCORECT = 4,
        PRET_INCORECT = 8,
        CULOARE_NESELECTATA =16,
        DOTARI_NESELCTATE = 32


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesEnums
{
    [Flags]
    internal enum Permissions
    {
        Aucune = 0,
        Lecture = 1,
        Ecriture = 2,
        Execution = 4,
        Suppression = 8,
        Tout = Lecture | Ecriture | Execution | Suppression

    }
}

using IsTakipYonetimSistemi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakipYonetimSistemi.Class.Projects
{
    internal class CallProjects
    {

        internal static List<Proejeler> OngoingProjects()
        {
            return DB_Connection.db.Proejeler.Where(x => x.IsDone == false).ToList();
        }
        internal static List<Proejeler> FinishedProjects()
        {
            return DB_Connection.db.Proejeler.Where(x => x.IsDone == true).ToList();
        }
    }
}

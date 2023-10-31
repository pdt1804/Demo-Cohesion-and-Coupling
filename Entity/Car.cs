using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohesion_Coupling_Concern.Entity
{
    public class Car
    {
        public DateTime ProductionDate { get; set; }

        public bool IsExpired()
        {
            DateTime currentDate = DateTime.Now;
            TimeSpan timeSpan = currentDate - ProductionDate;
            return timeSpan.TotalDays > (365 * 20);
        }
    }
}

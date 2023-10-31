using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohesion_Coupling_Concern.Entity
{
    public class CarService
    {
        public bool CheckCarExpiration(Car car)
        {
            return car.IsExpired();
        }
    }
}

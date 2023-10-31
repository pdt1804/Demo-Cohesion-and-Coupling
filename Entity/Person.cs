using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohesion_Coupling_Concern.Entity
{
    public class Person
    {
        public Car Car { get; set; }

        public bool CheckCarExpiration()
        {
            CarService carService = new CarService();
            return carService.CheckCarExpiration(Car);
        }
    }
}



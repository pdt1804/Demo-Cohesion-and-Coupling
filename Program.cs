using Cohesion_Coupling_Concern.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohesion_Coupling_Concern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car
            {
                ProductionDate = new DateTime(2010, 1, 1)
            };

            // Tạo một đối tượng Person và gán Car cho nó
            Person person = new Person
            {
                Car = car
            };

            // Kiểm tra xem Car có hết hạn sử dụng hay không qua đối tượng Person và CarService
            bool isExpired = person.CheckCarExpiration();

            if (isExpired)
            {
                Console.WriteLine("The car has expired.");
            }
            else
            {
                Console.WriteLine("The car is still within the usage period.");
            }

            Console.ReadLine();
        }
    }
}

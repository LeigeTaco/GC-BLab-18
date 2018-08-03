using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{

    class Program
    {

        static void Main(string[] args)
        {

            CarLot VictoryMotors = new CarLot(10);      //I'm big bob!

            char row = 'A';
            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 10; j++)
                {

                    VictoryMotors.AddCar(row, new Car());

                }

                row++;

            }

            VictoryMotors.ListAll();

        }

    }

}

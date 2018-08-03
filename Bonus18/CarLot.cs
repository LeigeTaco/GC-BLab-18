using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{

    class CarLot
    {

        private Dictionary<char, List<Car>> lot;

        public Dictionary<char, List<Car>> Lot
        {
            
            get
            {

                return lot;

            }

        }

        public void AddCar(char index, Car car)
        {

            lot[index].Add(car);

        }

        public void ReplaceCar(char row, int index, Car replacement)
        {

            lot[row].RemoveAt(index);
            lot[row].Insert(index, replacement);

        }

        public void BuyCar(char row, int index)
        {

            lot[row].RemoveAt(index);

        }

        public void ListAll()
        {

            char index = 'A';

            for (int i = 0; i < lot.Count; i++)
            {

                try
                {

                    Console.WriteLine(index);
                    ListRow(index);

                }
                catch (Exception)
                {

                    Console.WriteLine();

                }
                index++;

            }

        }

        public void ListRow(char row)
        {

            foreach (Car c in lot[row])
            {

                try
                {

                    Console.WriteLine(c.ToString());

                }
                catch (Exception)
                {


                    Console.WriteLine();

                }

            }

        }

        public void Details(char row, int index)
        {

            lot[row][index].ToString();

        }

        public CarLot(int length)
        {

            lot = new Dictionary<char, List<Car>>();

            char key = 'A';

            for (int i = 0; i < length; i++)
            {

                lot.Add(key, new List<Car>());
                key++;

            }

        }

    }

}

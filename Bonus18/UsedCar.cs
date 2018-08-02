using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{

    class UsedCar:Car
    {

        private double mileage;

        public double Mileage
        {

            set { mileage = value; }
            get { return mileage; }

        }

        public UsedCar():base()
        {

            Mileage = 20000;
            Make = "Honda";
            Model = "Civic";
            Year = 2008;
            Price = 15000;

        }

        public UsedCar(Car c, double mi)
        {

            Mileage = mi;
            Make = c.Make;
            Model = c.Model;
            Year = c.Year;
            Price = c.Price - 10000 - (mi / 10);

        }

        public UsedCar(string ma, string mo, int ye, double pr, double mi)
            :base(ma, mo, ye, pr)
        {
            
            Mileage = mi;

        }

        public override string ToString()
        {
            return base.ToString() + $" ({Mileage} mi)";
        }

    }

}

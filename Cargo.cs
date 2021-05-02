using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Cargo
    {
        private string cargoType;
        private double cargoWeight;

        public Cargo(string cargoType, double cargoWeight)
        {
            CargoType = cargoType;
            CargoWeight = cargoWeight;
        }

        public string CargoType
        {
            get { return cargoType; }
            set { cargoType = value; }
        }

       
        public double CargoWeight
        {
            get { return cargoWeight; }
            set { cargoWeight = value; }
        }

    }
}

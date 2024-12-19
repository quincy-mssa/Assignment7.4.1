using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7._4._1
{
    internal class ParkingSystem
    {
        private bool[] bigSlots;
        private bool[] mediumSlots;
        private bool[] smallSlots;

        public ParkingSystem(int big, int medium, int small)
        {
            bigSlots = new bool[big];
            mediumSlots = new bool[medium];
            smallSlots = new bool[small];
        }

        public bool AddCar(int carType)
        {
            bool[] targetArray = carType switch
            {
                1 => bigSlots,
                2 => mediumSlots,
                3 => smallSlots,
                _ => null
            };

            if (targetArray == null) return false;

            for (int i = 0; i < targetArray.Length; i++)
            {
                if (!targetArray[i])
                {
                    targetArray[i] = true;
                    return true;
                }
            }
            return false;
        }
    }
}

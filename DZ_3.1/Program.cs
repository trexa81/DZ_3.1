using System;

namespace DZ_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        class House
        {
            //Поля
            public int porchCount;
            public int floorCount;
            private int roomsOnFloor;
            private double meterCost;

            //Свойства
            public int Porchs
            {
                get { return porchCount; }
                set { porchCount = value; }
            }

            public int Floors
            {
                get { return floorCount; }
                set { floorCount = value; }
            }

            public int RoomsOnFloor
            {
                get { return roomsOnFloor; }
                set { roomsOnFloor = value; }
            }

            public double Cost
            {
                get { return meterCost; }
                set { meterCost = value; }
            }

            //Конструкторы
            public House()
            {
            }

            public House(int porchCount, int floorCount, int roomsOnFloor, double cost)
            {
                this.porchCount = porchCount;
                this.floorCount = floorCount;
                this.roomsOnFloor = roomsOnFloor;
                this.meterCost = cost;
            }
            //Методы

            public int GetRoomsCountInPorch()
            {
                return roomsOnFloor * floorCount;
            }

            public int GetRoomsCountInHouse()
            {
                return GetRoomsCountInPorch() * porchCount;
            }

            public double HouseCost()
            {
                return (double)GetRoomsCountInHouse() * Cost;
            }

            public override string ToString()
            {
                return string.Format("Количество этажей: {0} \nКоличество подъездов: {1} \nЦена за квадратный метр: {2}", Floors, Porchs, Cost);
            }
        }
    }
}

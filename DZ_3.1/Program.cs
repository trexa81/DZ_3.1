using System;

namespace DZ_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House[] houses = new House[]
           {
                new House(3, 5, 4, 1000),
                new House(4, 9, 5, 2000),
                new House(5, 3, 2, 700),
                new House(1, 2, 3, 500),
                new House(6, 9, 5, 2500),
           };

            foreach (House house in houses)
                Console.WriteLine(house.ToString());
            Console.ReadKey();

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
                return string.Format("Номер здания: {2} \n Количество этажей: {0} \n Количество подъездов: {1} {3}", Floors, Porchs, Cost);
            }
        }
    }
}

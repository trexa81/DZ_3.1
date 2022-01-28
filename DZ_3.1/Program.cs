using System;

namespace DZ_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House[] houses = new House[]
           {
                new House(3, 5, 4/*, 1000*/),
                new House(4, 9, 5/*, 2000*/),
                new House(5, 3, 2/*, 700*/),
                new House(1, 2, 3/*, 500*/),
                new House(6, 9, 5/*, 2500*/),
           };

            foreach (House house in houses)
                Console.WriteLine(house.ToString());
            Console.ReadKey();

        }

        class House
        {
            //Поля

            /// <summary>
            /// подъездов
            /// </summary>
            private int _porchCount;
            /// <summary>
            /// этажей
            /// </summary>
            private int _floorCount;
            /// <summary>
            /// квартир на этаже
            /// </summary>
            private int _roomsOnFloor;
            private int _numberHouse = 1;
            
            //Конструкторы
            public House(int porchCount, int floorCount, int roomsOnFloor/*, int numberHouse*/)
            {
                _porchCount = porchCount;
                _floorCount = floorCount;
                _roomsOnFloor = roomsOnFloor;
                //_numberHouse = numberHouse;
            }

            //Свойства

            /// <summary>
            /// подъезд
            /// </summary>
            public int Porchs
            {
                get { return _porchCount; }
                set { _porchCount = value; }
            }
            /// <summary>
            /// количество этажей
            /// </summary>
            public int Floors
            {
                get { return _floorCount; }
                set { _floorCount = value; }
            }
            /// <summary>
            /// квартир в доме
            /// </summary>
            public int RoomsOnFloor
            {
                get { return GetRoomsCountInHouse(); }
                set { _roomsOnFloor = value; }
            }

            public int HouseNumber
            {
                get { return ++_numberHouse; }
                set { _numberHouse = value; }
            }

                                   
            //Методы

            /// <summary>
            /// квартир в подъезде
            /// </summary>
            /// <returns></returns>
            public int GetRoomsCountInPorch()
            {
                return _roomsOnFloor * _floorCount;
            }

            /// <summary>
            /// квартир в доме
            /// </summary>
            /// <returns></returns>
            public int GetRoomsCountInHouse()
            {
                return GetRoomsCountInPorch() * _porchCount;
            }

            /// <summary>
            /// стоимость дома
            /// </summary>
            /// <returns></returns>
            public double HouseCost()
            {
                return (double)GetRoomsCountInHouse() * 100000;
            }

            // уникальный номер здания, высота, этажность, количество квартир, подъездов
            public override string ToString()
            {
                return string.Format("Номер здания: {2} \n Количество этажей: {0} \n Количество подъездов: {1} \n Количество квартир: {3}\n",
                    Floors, Porchs, HouseNumber, RoomsOnFloor);
            }
        }
    }
}

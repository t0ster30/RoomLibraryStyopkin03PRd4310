using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomLibraryStyopkin03PRd4310
{
    public class Room
    {
        double roomLength;
        double roomWidth;

        public double RoomLength
        {
            get { return roomLength; }
            set { roomLength = value; }
        }

        public double RoomWidth
        {
            get { return roomWidth; }
            set { roomWidth = value; }
        }

        /// <summary>
        /// метод вычисляет периметр комнаты
        /// </summary>
        /// <returns>значение периметра</returns>
        public double RoomPerimetr()
        {
            return 2 * (roomLength + roomWidth);
        }
        /// <summary>
        /// метод вычисляет площадь комнаты
        /// </summary>
        /// <returns>значение площади</returns>
        public double RoomArea()
        {
            return roomLength * roomWidth;
        }
        /// <summary>
        /// метод вычисляет число людей на квадратный метр площади
        /// </summary>
        /// <param name="np">число человек</param>
        /// <returns>число квадратных метров на человека</returns>
        public double PersonArea(int np)
        {
            return RoomArea() / np;
        }
    }

}

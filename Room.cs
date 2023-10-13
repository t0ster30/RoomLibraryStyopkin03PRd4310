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
            get { roomLength = value; }
        }

        public double RoomWidth
        {
            get { return roomWidth; }
            get { roomWidth = value; }
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
        public double PersonArea(int np)
        {
            return RoomArea() / np;
        }
    }

}

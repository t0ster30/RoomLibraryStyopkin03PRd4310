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
        public string Info()
        {
            return "Комната площадью " + RoomArea() + "кв.м";
        }
    }

    public class LivingRoom : Room
    {
        int numWin;
        public int NumWin
        {
            get { return numWin; }
            set { numWin = value; }
        }
        /// <summary>
        /// метод возвращает информацию о комнате
        /// </summary>
        /// <returns>строка с информацией о комнате</returns>
        public string Info()
        {
            return "Жилая комната площадью " + RoomArea() + " кв.м, с " + numWin + " окнами";
        }
    }
    public class Office : Room
    {
        int numSockets;
        public int NumSockets
        {
            get { return numSockets; }
            set { numSockets = value; }
        }
        /// <summary>
        /// возвращает максимальное число рабочих мест
        /// </summary>
        /// <returns>число мест</returns>
        public int NumWorkplaces()
        {
            int num = Convert.ToInt32(Math.Truncate(RoomArea() / 4.5));
            return Math.Min(numSockets, num);
        }
        /// <summary>
        /// метод возвращает информацию об офисе
        /// </summary>
        /// <returns>строка с информацией</returns>
        public string Info()
        {
            return "Офис на " + NumWorkplaces() + " рабочих мест";
        }
    }
}
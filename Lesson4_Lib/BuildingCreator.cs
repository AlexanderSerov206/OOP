using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Lib
{
    public class BuildingCreator
    {
        /// <summary>
        /// Хэш-таблица для хранения созданных зданий.
        /// </summary>
        public static Hashtable Buildings { get; private set; } = new Hashtable();

        /// <summary>
        /// Закрываем конструктор класса.
        /// </summary>
        private BuildingCreator() { }

        /// <summary>
        /// Создать здание с заданными аттрибутами и поместить в хэш-таблицу для хранения.
        /// </summary>
        /// <param name="height"> Высота здания. </param>
        /// <param name="floorsCount"> Количество этажей. </param>
        /// <param name="appartmentsCount"> Количество квартир. </param>
        /// <param name="porchesCount"> Количество подъездов. </param>
        public static void CreateBuilding(double height, int floorsCount, int appartmentsCount, int porchesCount)
        {
            Building building = new Building(height, floorsCount, appartmentsCount, porchesCount);
            Buildings.Add(building.ID, building);
        }

        /// <summary>
        /// Удаление здания, хранящегося в хэш-таблице.
        /// </summary>
        /// <param name="uniqueID"> Уникальный идентификатор здания. </param>
        /// <returns> Результат удаления. true - успешно, false - не успешно. </returns>
        public static bool DeleteBuilding(int uniqueID)
        {
            if (!Buildings.Contains(uniqueID))
                return false;

            Buildings.Remove(uniqueID);
            return true;
        }
    }
}

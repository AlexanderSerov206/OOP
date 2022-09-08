namespace Lesson4_Lib
{
    public class Building
    {
        #region fields
        /// <summary>
        /// Статическая переменная для корректной нумерации домов.
        /// </summary>
        private static int idCounter = 1;
        #endregion

        #region properties
        /// <summary>
        /// Уникальный номер дома. Задаётся автоматически при создании экземпляра.
        /// </summary>
        public int ID { get; init; } = idCounter++;

        /// <summary>
        /// Высота.
        /// </summary>
        public double Height { get; init; }

        /// <summary>
        /// Количество этажей.
        /// </summary>
        public int FloorsCount { get; init; }

        /// <summary>
        /// Количество квартир.
        /// </summary>
        public int AppartmentsCount { get; init; }

        /// <summary>
        /// Количество подъездов.
        /// </summary>
        public int PorchesCount { get; init; }
        #endregion

        /// <summary>
        /// Конструктор здания. Закрыт для создания извне. Экземпляры создаются с помощью BuildingCreator.CreateBuilding()
        /// </summary>
        /// <param name="height"> Высота здания. Не может быть меньше или равна нулю. </param>
        /// <param name="floorsCount"> Количество этажей. Не может быть меньше и равным нулю. </param>
        /// <param name="apparmentsCount"> Количество квартир. Не может быть меньше или равным нулю. </param>
        /// <param name="porchesCount"> Количество подъездов. Не может быть меньше или равным нулю. </param>
        /// <exception cref="ArgumentException"></exception>
        internal Building(double height, int floorsCount, int apparmentsCount, int porchesCount)
        {
            if (height <= 0)
                throw new ArgumentException("Высота здания не может быть меньше или равна нулю.");

            if (floorsCount <= 0)
                throw new ArgumentException("Количество этажей не может быть меньше или равным нулю.");

            if (apparmentsCount <= 0)
                throw new ArgumentException("Количество квартир не может быть меньше или равным нулю.");

            if (porchesCount <= 0)
                throw new ArgumentException("Количество подъездов не может быть меньше или равным нулю.");

            Height = height;
            FloorsCount = floorsCount;
            AppartmentsCount = apparmentsCount;
            PorchesCount = porchesCount;
        }

        /// <summary>
        /// Подсчитывает высоту этажа в здании.
        /// </summary>
        /// <returns> Высота этажа. </returns>
        public double GetFloorHeight()
        {
            return Height / Convert.ToDouble(FloorsCount);
        }

        /// <summary>
        /// Подсчитывает количество квартир на подъезд.
        /// </summary>
        /// <returns> Количество квартир на подъезд. </returns>
        public double GetAppartsPerPorch()
        {
            return AppartmentsCount / Convert.ToDouble(PorchesCount);
        }

        /// <summary>
        /// Подсчитывает количество квартир на этаж.
        /// </summary>
        /// <returns> Количество квартир на этаж. </returns>
        public double GetAppartsPerFloor()
        {
            return AppartmentsCount / Convert.ToDouble(FloorsCount);
        }
    }
}
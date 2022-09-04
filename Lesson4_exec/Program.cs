using Lesson4_Lib;

namespace Lesson4_exec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BuildingCreator.CreateBuilding(25d, 7, 70, 3);
            BuildingCreator.CreateBuilding(30d, 9, 90, 4);
            BuildingCreator.CreateBuilding(50d, 15, 250, 8);

            try
            {
                BuildingCreator.CreateBuilding(0, 15, 250, 8); // попытка создать здание с нулевой высотой. Исключение ArgumentException.
            }
            catch (Exception)
            {

            }

            BuildingCreator.DeleteBuilding(5); // не успешно, здания с таким ID нет в хэш-таблице.
            BuildingCreator.DeleteBuilding(2); // успешно.

            Building building = (Building)BuildingCreator.Buildings[3];
            double floorHeight = building.GetFloorHeight();
            double appartsPerFloor = building.GetAppartsPerFloor();
            double appartsPerPorch = building.GetAppartsPerPorch();

            Console.WriteLine($"Здание с ID: {building.ID}. " +
                              $"\n\rВысота: {building.Height}. " +
                              $"\n\rКол-во этажей: {building.FloorsCount}. " +
                              $"\n\rКол-во квартир: {building.AppartmentsCount}. " +
                              $"\n\rКол-во подъездов: {building.PorchesCount}. " +
                              $"\n\rВысота этажа: {String.Format("{0:0.00}", floorHeight)}. " +
                              $"\n\rКвартир на этаж: {String.Format("{0:0.00}", appartsPerFloor)}. " +
                              $"\n\rКвартир в подъезде: {String.Format("{0:0.00}", appartsPerPorch)}. ");
        }
    }
}
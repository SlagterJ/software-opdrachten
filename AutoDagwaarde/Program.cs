using AutoDagwaarde.Car;
using static AutoDagwaarde.Types;

Car car1 = new("AA-AA-00", FuelType.gasoline);
car1.Drive(40);

Car car2 = new("BB-BB-11", FuelType.diesel);
car2.Drive(80);

Car car3 = new("CC-CC-22", FuelType.electric);
car3.Drive(150);

List<Car> cars = new()
{
    car1,
    car2,
    car3
};

cars.ForEach((car) =>
{
    Console.WriteLine(car.ToString());
});
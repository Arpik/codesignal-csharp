class Program
{
    static void Main()
    {
        // Create a Car using CarCreator and call its Drive method.
        CarCreator carCreator = new CarCreator();
        Car car = carCreator.CreateVehicle();
        car.Drive();

        // Create a Bike using BikeCreator and call its Drive method.
        BikeCreator bikeCreator = new BikeCreator();
        Bike bike = bikeCreator.CreateVehicle();
        bike.Drive();
    }
}
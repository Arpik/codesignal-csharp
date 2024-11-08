class CarCreator : VehicleCreator
{
    public override Car CreateVehicle() => new Car();
}

// Create a class named BikeCreator that inherits from VehicleCreator and implements the 'CreateVehicle' method to return a new Bike.
class BikeCreator : VehicleCreator
{
    public override Bike CreateVehicle() => new Bike();
}
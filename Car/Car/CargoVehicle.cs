using System;

public class CargoVehicle : Automobile
{
    public double CarryingCapacity;
    public double CurrentLoad;

    protected const double fuelRangeDecreaseForNKg = 0.04;
    protected const double n = 200;

    public CargoVehicle(double averageFuelConsumption, double fuelTankCapacity, double currentFuel, double speed,
        double carryingCapacity, double currentLoad)
        : base(VehicleСategories.C, averageFuelConsumption, fuelTankCapacity, currentFuel, speed)
    {
        CarryingCapacity = carryingCapacity;
        CurrentLoad = currentLoad;

        if (CurrentLoad > CarryingCapacity)
        {
            throw new ArgumentException($"Загруженность не может быть больше {CarryingCapacity}");
        }
    }

    protected override double CalcFuelRange(double fuel)
    {
        return base.CalcFuelRange(fuel) * (1 - CurrentLoad * (fuelRangeDecreaseForNKg / n));
    }
}

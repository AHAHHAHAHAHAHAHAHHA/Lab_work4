using System;

interface ITransporter
{
    double EstimateTime(double distance);
    double EstimateCost(double distance);
}

abstract class CargoTransporter : ITransporter
{
    public abstract double EstimateTime(double distance);
    public abstract double EstimateCost(double distance);
    public virtual double LoadCapacity() => 1000; 
}

abstract class PassengerTransporter : ITransporter
{
    public abstract double EstimateTime(double distance);
    public abstract double EstimateCost(double distance);
}

class Truck : CargoTransporter
{
    public override double EstimateTime(double distance)
    {
        return distance / 60.0;  
    }

    public override double EstimateCost(double distance)
    {
        return distance * 2;  
    }

    public override double LoadCapacity()
    {
        return 20000; 
    }
}

class Train : CargoTransporter
{
    public override double EstimateTime(double distance)
    {
        return distance / 80.0; 
    }

    public override double EstimateCost(double distance)
    {
        return distance * 1.5; 
    }
}

class Bus : PassengerTransporter
{
    public override double EstimateTime(double distance)
    {
        return distance / 50.0;  
    }

    public override double EstimateCost(double distance)
    {
        return distance * 0.8;  
    }
}

class Trolleybus : PassengerTransporter
{
    public override double EstimateTime(double distance)
    {
        return distance / 40.0;  
    }

    public override double EstimateCost(double distance)
    {
        return distance * 0.5;  
    }
}

class Plane : CargoTransporter
{
    public override double EstimateTime(double distance)
    {
        return distance / 800.0;  
    }

    public override double EstimateCost(double distance)
    {
        return distance * 5;  
    }

    public override double LoadCapacity()
    {
        return 50000;  
    }
}


class Program
{
    static void Main(string[] args)
    {
        ITransporter myTruck = new Truck();
        Console.WriteLine("Truck: Time to travel 300 km: " + myTruck.EstimateTime(300) + " hours");
        Console.WriteLine("Truck: Cost to travel 300 km: $" + myTruck.EstimateCost(300));
        
        ITransporter myBus = new Bus();
        Console.WriteLine("Bus: Time to travel 200 km: " + myBus.EstimateTime(200) + " hours");
        Console.WriteLine("Bus: Cost to travel 200 km: $" + myBus.EstimateCost(200));
    }
}

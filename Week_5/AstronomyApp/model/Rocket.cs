class Rocket : SpaceShip
{
    public Rocket(string name, double mass, double fuel, int crewCapacity, double thrust, double specificImpulse) 
    : base(name, mass, fuel, crewCapacity, thrust, specificImpulse)
    {
    }

    public override void Land()
    {
        System.Console.WriteLine($"{Name} Rocket is landed");
    }

    public override void Launch()
    {
        System.Console.WriteLine($"{Name} Rocket is launched");
    }

     public new void TravelTo(Planet planet){
        var travelTime = 
        planet.Distance / CalculateTravelDistance(CalculateDeltaV(planet.Gravity));
        System.Console.WriteLine($"Travel Time to {planet.Name} : {travelTime}");
    }

    protected new double CalculateDeltaV(double Gravity){
        var deltaV = SpecificImpulse * Gravity * Math.Log((Mass+Fuel)/Mass);
        return deltaV;

    }
    protected new double CalculateTravelDistance(double deltaV){
        
        var travelDistance = 2*deltaV/(Thrust*1000);
        return travelDistance;
    }
}
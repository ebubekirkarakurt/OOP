class Moon : CelestialBody{

    public Planet ParentPlanet { get; set; }

    public Moon(string Name, double Mass, double Radius, Planet parentPlanet) : base(Name, Mass, Radius)
    {
        ParentPlanet = parentPlanet;
    }



    public override void Describe()
    {
       System.Console.WriteLine($"{Name}\n{Mass}\n{Radius}\n{ParentPlanet.Name}\n");
    }

}
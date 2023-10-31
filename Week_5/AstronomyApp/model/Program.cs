Planet planet1 = new Planet("Earth", 5000,15000,25000,9.18);
Moon moon1 = new Moon("Moon", 1500, 2500, planet1);
Rocket rocket1 = new Rocket("XPG-15", 50,150,4,100,50);


planet1.Describe();
System.Console.WriteLine("**********************");
moon1.Describe();
System.Console.WriteLine("**********************");


rocket1.Launch();
rocket1.TravelTo(planet1);
rocket1.Land();
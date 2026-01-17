using System;

namespace RoverControlCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            // ===== Create Rovers and Satellites =====
            MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
            MoonRover apollo = new MoonRover("Apollo 15", 1971);
            MarsRover sojourner = new MarsRover("Sojourner", 1997);
            Satellite sputnik = new Satellite("Sputnik", 1957); 

            // Store rovers in an array
            Rover[] rovers = { lunokhod, apollo, sojourner };

            // Direct all rovers
            DirectAll(rovers);

            // Store all probes in an object array
            Object[] probes = { lunokhod, apollo, sojourner, sputnik };

            // Print the type of each probe
            foreach (Object probe in probes)
            {
                Console.WriteLine($"Tracking a {probe.GetType()}");
            }

            Console.WriteLine();

            // Store directable objects in an interface array
            IDirectable[] directables = { lunokhod, apollo, sojourner, sputnik };

            // Direct all directable objects
            DirectAll(directables);
        }

        // Helper method to operate an array of IDirectable objects
        public static void DirectAll(IDirectable[] directables)
        {
            foreach (IDirectable directable in directables)
            {
                Console.WriteLine(directable.GetInfo());   // show info
                Console.WriteLine(directable.Explore());   // simulate exploring
                Console.WriteLine(directable.Collect());   // simulate collecting
                Console.WriteLine();
            }
        }
    }
}
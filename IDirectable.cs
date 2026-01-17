namespace RoverControlCenter
{
    // Interface for objects that can be directed
    interface IDirectable
    {
        string GetInfo();   // Return info about the object
        string Explore();   // Simulate exploring
        string Collect();   // Simulate collecting items
    }
}
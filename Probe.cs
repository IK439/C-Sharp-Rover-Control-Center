namespace RoverControlCenter
{
    // Base class for all probes
    abstract class Probe
    {
        // Derived classes will provide their own implementation
        public abstract string GetInfo();
        public abstract string Explore();
        public abstract string Collect();
    }
}
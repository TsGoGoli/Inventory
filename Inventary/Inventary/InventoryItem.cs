namespace InventoryManagement
{
    // Base class for inventory items
    public abstract class InventoryItem
    {
        public double Weight { get; }
        public double Volume { get; }

        protected InventoryItem(double weight, double volume)
        {
            Weight = weight;
            Volume = volume;
        }
    }
}

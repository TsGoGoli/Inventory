namespace InventoryManagement
{
    // Pack class to manage items
    public class Pack
    {
        private readonly List<InventoryItem> _items = new List<InventoryItem>();
        private readonly int _maxItems;
        private readonly double _maxWeight;
        private readonly double _maxVolume;

        public Pack(int maxItems, double maxWeight, double maxVolume)
        {
            _maxItems = maxItems;
            _maxWeight = maxWeight;
            _maxVolume = maxVolume;
        }

        public int CurrentItemCount => _items.Count;
        public double CurrentWeight => CalculateCurrentWeight();
        public double CurrentVolume => CalculateCurrentVolume();

        public int MaxItems => _maxItems;
        public double MaxWeight => _maxWeight;
        public double MaxVolume => _maxVolume;

        public bool Add(InventoryItem item)
        {
            if (_items.Count >= _maxItems ||
                CurrentWeight + item.Weight > _maxWeight ||
                CurrentVolume + item.Volume > _maxVolume)
            {
                return false;
            }

            _items.Add(item);
            return true;
        }

        private double CalculateCurrentWeight()
        {
            double totalWeight = 0;
            foreach (var item in _items)
            {
                totalWeight += item.Weight;
            }
            return totalWeight;
        }

        private double CalculateCurrentVolume()
        {
            double totalVolume = 0;
            foreach (var item in _items)
            {
                totalVolume += item.Volume;
            }
            return totalVolume;
        }
    }
}

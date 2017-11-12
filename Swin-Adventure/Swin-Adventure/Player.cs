using System;

namespace Swin_Adventure
{
    public class Player : GameObject, IHaveInventory
    {
        private Inventory _inventory;
        private Location _location; //Players are in a location

        public Player(string name, string desc) : base(new string[] { "me", "inventory"}, name, desc)
        {
            _inventory = new Inventory();
            _location = new Location("", "");
        }

        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }
            else if (_inventory.HasItem(id))
            {
                return _inventory.Fetch(id);
            }
            else return _location.Locate(id);
        }
      
        public override string FullDescription
        {
            get
            {
                string desc = "You are carrying\n";
                desc += _inventory.ItemList;
                return desc;
            }
        }

        public Inventory Inventory { get => _inventory; }
        
        public Location Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
            }
        }

    }
}

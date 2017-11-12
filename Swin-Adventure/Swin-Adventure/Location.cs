using System;

namespace Swin_Adventure
{
    public class Location : GameObject, IHaveInventory
    {
        private Inventory _inventory;

        public Location(string name, string desc) : base(new string[] { "look" }, name, desc)
        {
            _inventory = new Inventory();
        }

        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }
            else
            {
                return _inventory.Fetch(id);
            }

        }
        public override string FullDescription
        {
            get
            {
                return "You are in the " + Name + "\n" + base.FullDescription + "In this room you can see:\n" + _inventory.ItemList;
            }
        }
        public Inventory Inventory { get => _inventory; }
    }
}

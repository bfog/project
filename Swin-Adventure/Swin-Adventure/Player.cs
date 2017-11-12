using System;

namespace Swin_Adventure
{
    public class Player : GameObject
    {
        private Inventory _inventory;

        public Player(string name, string desc) : base(new string[] { "me", "inventory"}, name, desc)
        {
            _inventory = new Inventory();
        }

        public GameObject Locate(string id)
        {
            if(AreYou(id))
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
                string desc = "You are carrying\n";
                desc +=  _inventory.ItemList;
                return desc;
            }
        }

        public Inventory Inventory { get => _inventory; }
    }
}

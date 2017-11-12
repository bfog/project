using System;
using NUnit.Framework; 

namespace Swin_Adventure
{
    [TestFixture]
    public class LocationUnitTest
    {
        Player myPlayer;
        Inventory myInventory, locInventory;
        Item gem;
        LookCommand look;
        Location location;

        [SetUp]
        public void SetUp()
        {
            myPlayer = new Player("me", "inventory");
            myInventory = myPlayer.Inventory;
            gem = new Item(new string[] { "gem" }, "a gem", "A shiny red gem");
            look = new LookCommand(new string[] { "look" });
            location = new Location("Hallway", "This is a long well lit hallway.\nThere are exits to the south.\n");

            myPlayer.Location = location;

            locInventory = location.Inventory;

            locInventory.Put(gem);
        }

        [Test]
        public void LocateSelf ()
        {
            Assert.AreEqual("You are in the Hallway\nThis is a long well lit hallway.\nThere are exits to the south.\nIn this room you can see:\n\ta gem (gem)\n", look.Execute(myPlayer, new string[] { "look" }));
        }

        [Test]
        public void LocateItem()
        {
            Assert.AreEqual("A shiny red gem", look.Execute(myPlayer, new string[] { "look", "at", "gem" }));
        }

        [Test]
        public void LocateOwnItems()
        {
            Assert.AreEqual(gem, location.Locate("gem"));
        }
    }
}

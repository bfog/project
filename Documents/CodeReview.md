#Code Review

##Program.cs
+ Main program used to execute the game.

##Bag.cs
+ Acts like an inventory.
+ A player can have a bag.
+ Items can be added to the bag and retrieved.

##GameObject.cs
+ Each game object must have an name, description and id.
+ Can return the short description, name and full description of a game object.
+ Passes up the object id to IdentifiableObject.

##IdentifiableObject.cs
+ Used to identify a game object.
+ Passed up id's are stored in a list which can be retrieved manipulated.

##Player.cs
+ A player has an inventory and location by default.
+ Is able to locate itself and other items in it's inventory.
+ Has its own full description.
+ It's current location can be retrieved and modified.

##Inventory.cs
+ Stores a list of items.
+ Can check if an item exists.
+ Can fetch, remove and put items.
+ Returns a list of all the items it holds.

##Item.cs
+ An object within the game that the player can interact with.
+ Has a name, description and id.

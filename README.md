Note/Disclaimer:

•	I noticed that ”Aged Brie” quality increased by 2 after the sell by date has passed. It was never specified in the requirements. I do not know if I should fix it but I decided to leave it in as a feature. 

•	The requirements for “Conjured” specifies that the quality degrade twice as fast as a normal item. Then I assume that if the sell date has passed, it will degrade 4 times as fast which is in regards to the other requirement: “Once the sell by date has passed, Quality degrades twice as fast”

•	In the requirements, it mention “Aged Brie”, “Sulfures”, “Backstage passed” and “Conjured” as it is a type. However, in the existing code it is part of a longer name. As a result, I have changed UpdateQuality to look for the “words” rather than explicit matching the long name in the code.

•	I wanted to design the solution to follow SOLID design principle and make it more testable and maintainable. I could not archive that because the requirements explicit mentions that I am not allowed to alter Item class or Items property. If I was allowed to alter it, I would have implemented “BusinessLogic”, “Interfaces” and “DependencyInjectionConfiguration” as a project and put “Item” in “Interfaces”. It is because “Item” should be a shared DTO.

After refactor:

•	The GiledRose is now easier to maintain and expand with new feature. There are now separate class to handle each specific type item.

•	It is also easier to add feature as well. Just simple created a new class by using “IGildedRoseItem” interface and register it in a IoC cointainer. 

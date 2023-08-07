## Vending Machine Project
This project simulates the activity of a vending machine for snacks and drinks. It uses five types of Design Patterns:

 - Factory Pattern is used to create different types of vending machine products.
 - Singleton Pattern is used to ensure that there is only one instance of the vending machine.
 - Observer Pattern is used to notify listeners when the vending machine's inventory changes.
 - Strategy Pattern is used to determine how to dispense a product, depending on the type of product.
 - State Pattern is used to represent the different states of the vending machine, such as "no coins inserted", "sufficient funds", and "product dispensed".
The project also includes a UML diagram that shows the relationships between the different classes in the project. The diagram is available in the docs folder.

The project is made with WinForm technology. It can be run on Windows 10 or later.

# To Run the Project
 - Open a command prompt and navigate to the project directory.
 - Run the following command:
 - dotnet run
 - The project will start up and you will be able to interact with the vending machine.

# Design Patterns
The following Design Patterns are used in this project:

Factory Pattern is used to create different types of vending machine products. The ProductFactory class is responsible for creating products. The Product interface defines the methods that all products must implement. The Snack and Drink classes implement the Product interface.
Singleton Pattern is used to ensure that there is only one instance of the vending machine. The VendingMachine class is a singleton. This means that there can only be one instance of the VendingMachine class in the entire application.
Observer Pattern is used to notify listeners when the vending machine's inventory changes. The VendingMachine class is the subject. The InventoryListener interface defines the methods that listeners must implement. The InventoryChangedEventArgs class is used to pass information about inventory changes to listeners.
Strategy Pattern is used to determine how to dispense a product, depending on the type of product. The DispensingStrategy interface defines the methods that all dispensing strategies must implement. The CoinDispensingStrategy class implements the DispensingStrategy interface. It dispenses coins when a product is purchased. The ItemDispensingStrategy class implements the DispensingStrategy interface. It dispenses an item when a product is purchased.
State Pattern is used to represent the different states of the vending machine, such as "no coins inserted", "sufficient funds", and "product dispensed". The VendingMachineState enumeration defines the different states of the vending machine. The VendingMachine class maintains a VendingMachineState variable. This variable is used to determine the current state of the vending machine.
# UML Diagram
The following UML diagram shows the relationships between the different classes in the project:

![Vending Machine UML Diagram](https://github.com/pessiMargalit/design-pattern-automatic-machine/blob/master/UML%20Class%20Diagram.vpd.jpg)
# License
This project is licensed under the MIT License.

# Contact
If you have any questions about this project, please contact me at pessimargalit@gmail.com


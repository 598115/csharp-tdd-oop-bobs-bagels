# Domain Model


| Classes         | Methods/Properties                                 | Scenario                                                                     | Outputs                                  |
|-----------------|----------------------------------------------------|------------------------------------------------------------------------------|-------------------------------------------
|Basket.cs        |AddItem(Item item)                                  |add a new item to the basket                                                  |the added item or null if basket full     |
|Basket.cs        |RemoveItem(string id)                               |remove an item from the basket                                                |the removed item  or null if not found    |
|Basket.cs        |ChangeBasketCapacity(int capacity)                  |change capacity of basket                                                     |true if success or false if invalid       |
|Basket.cs        |GetBasketTotalPrice()                               |get the summed cost of the bagels in the basket                               |string with total cost formatted in USD   |
|Item.cs          |GetPrice()                                          |get the price of an item                                                      |string with total cost formatted in USD   |
|Filling.cs       |ChooseFillings(Fillings fillings)                   |select the fillings of a bagel                                                |the selected fillings                     |


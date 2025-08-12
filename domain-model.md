# Domain Model


| Classes         | Methods/Properties                                 | Scenario                                                                     | Outputs                                  |
|-----------------|----------------------------------------------------|------------------------------------------------------------------------------|-------------------------------------------
|Basket.cs        |AddItem(Item item)                                  |add a new item to the basket                                                  |the added item or null if basket full     |
|Basket.cs        |RemoveItem(Guid id)                                 |remove an item from the basket                                                |the removed item  or null if not found    |
|Basket.cs        |ChangeBasketCapacity(int capacity)                  |change capacity of basket                                                     |true if success or false if invalid       |
|Basket.cs        |GetBasketTotalPrice()                               |get the summed cost of the bagels in the basket                               |float                                     |
|Product.cs       |GetPrice()                                          |get the price of an item                                                      |float                                     |
|Filling.cs       |ChooseFillings(Fillings fillings)                   |select the fillings of a bagel                                                |the selected fillings                     |
|Product.cs       |ChangePrice(float nprice)                           |change the price of a product                                                 |the new price (float)                     |
|Coffee.cs        |CalculatePrice()                                    |set price of item depending on type                                           |the price (float)                         |
|Bagel.cs         |CalculatePrice()                                    |set price of item depending on type                                           |the price (float)                         |
|Filling.cs       |CalculatePrice()                                    |set price of item depending on type                                           |the price (float)                         |
|PriceLookup.cs   |LookupPriceByType(Enum)                             |look up the price of an item                                                  |the price (float)                         |
|Basket.cs        |PrintReceipt()                                      |print a receipt that shows all basket items, their price and total cost       |the price (float)                         |
|ProductBundle.cs |BagelDeal6()                                        |create a discount deal with 6 bagels                                          |void                                      |
|ProductBundle.cs |BagelDeal12()                                       |create a discount deal with 12 bagels                                         |void                                      |
|ProductBundle.cs |CoffeeAndBagelDeal()                                |create a discount deal with a black coffee and bagel                          |void                                      |
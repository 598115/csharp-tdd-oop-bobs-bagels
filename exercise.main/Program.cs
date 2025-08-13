
using exercise.main;

Basket basket = new(7, Role.Customer);

Bagel PlainBaconBagel = new(new Filling(FillingType.Bacon) ,BagelType.Plain);
Bagel OnionHamBagel = new(new Filling(FillingType.Ham), BagelType.Onion);
Coffee cappucino = new(CoffeeType.Capuccino);


ProductBundle bundle = new(BundleType.coffeeBagel);
bundle.CoffeeAndBagelDeal(new Filling(FillingType.Bacon), BagelType.Onion);



ProductBundle bundle2 = new(BundleType.bagel6);



Filling filling = new Filling(FillingType.Ham);
bundle2.BagelDeal6(BagelType.Sesame, filling, filling, filling, filling, filling, filling);

basket.AddItem(PlainBaconBagel);
basket.AddItem(OnionHamBagel);
basket.AddItem(bundle2);
basket.AddItem(cappucino);
basket.AddItem(bundle);

basket.PrintReceipt();


basket.
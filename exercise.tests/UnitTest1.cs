using exercise.main;
using System.ComponentModel;

namespace exercise.tests;

public class Tests
{
    [Test]
    public void TestItemAdded()
    {
        Basket basket = new(1);
        Filling filling = new Filling(FillingType.Bacon);
        Bagel bagel = new(filling, BagelType.Plain);
        basket.AddItem(bagel);

        Assert.That(basket.Count, Is.EqualTo(1));

    }
    [Test]
    public void TestItemRemoved()
    {
        Basket basket = new(1);
        Filling filling = new Filling(FillingType.Bacon);
        Bagel bagel = new(filling, BagelType.Sesame);
        basket.AddItem(bagel);
        basket.RemoveItem(bagel.Id);

        Assert.That(basket.Count, Is.EqualTo(0));

    }

    [Test]
    public void CantRemoveNonExistentItem()
    {
        Basket basket = new(1);
        Filling filling = new Filling(FillingType.Bacon);
        Bagel bagel = new(filling, BagelType.Sesame);
        basket.AddItem(bagel);
        Guid nonExist = new Guid();
        Bagel? rmbagel = (Bagel?) basket.RemoveItem(nonExist);

        Assert.That(rmbagel, Is.Null);

    }

    [Test]
    public void CheckPriceIsRight()
    {
        float price = 5.99f;
        Filling filling = new Filling(FillingType.Bacon);
        Bagel bagel = new(filling, BagelType.Sesame);

        bagel.changePrice(5.99f); // Inflation..

        Assert.That(price, Is.EqualTo(bagel.Price));
    }

    [Test]
    public void ChangedCapacityIsChanged()
    {
        int capacity = 5;

        Basket basket = new(1, Role.Manager);

        basket.ChangeCapacity(capacity);

        Assert.That(capacity, Is.EqualTo(basket.Capacity));
    }

    [Test]
    public void OnlyManagerCanChangeCapacity()
    {
        int capacity = 5;

        Basket basket = new(1, Role.Customer);

        bool didChange = basket.ChangeCapacity(capacity);

        Assert.That(didChange, Is.False);
    }


    public void CantOverCapacity()
    {
        int capacity = 1;

        Basket basket = new(capacity);
        Filling filling = new Filling(FillingType.Bacon);

        Bagel bagel1 = new(filling, BagelType.Plain);
        Bagel bagel2 = new(filling, BagelType.Plain);

        Bagel? result1 = (Bagel?) basket.AddItem(bagel1);
        Bagel? result2 = (Bagel?) basket.AddItem(bagel2);

        Assert.That(result1, Is.InstanceOf(typeof(Bagel))); //Return added bagel upon succesfull add
        Assert.That(result2, Is.Null); //Return null when basket full
    }

    [Test]
    public void BasketTotalCostCorrect()
    {
        float price1 = 0.39f + 0.12f;
        float price2 = 0.49f + 0.12f;
        float price3 = 0.49f + 0.12f;

        Filling filling = new Filling(FillingType.Bacon);

        Bagel bagel1 = new(filling, BagelType.Plain);
        Bagel bagel2 = new(filling, BagelType.Onion);
        Bagel bagel3 = new(filling, BagelType.Everything);

        Basket basket = new(3);

        basket.AddItem(bagel1);
        basket.AddItem(bagel2);
        basket.AddItem(bagel3);

        float totalPrice = basket.GetBasketTotalPrice();

        Assert.That(price1 + price2 + price3, Is.EqualTo(totalPrice));

    }

    [Test]
    public void GotChosenFilling()
    {
        Bagel bagel = new Bagel(null, BagelType.Plain);

        Filling filling = new(FillingType.Bacon);

        bagel.ChooseFillings(filling);

        Assert.That(bagel.Filling.Type, Is.EqualTo(FillingType.Bacon));
    }

    [Test]
    public void TestDiscountDealCoffeeDiscount()
    {

        ProductBundle bundle = new(BundleType.coffeeBagel);
        bundle.CoffeeAndBagelDeal(new Filling(FillingType.Bacon),BagelType.Onion);


        Assert.That(bundle.Discount, Is.EqualTo(0.23f));
    }

    [Test]
    public void Plain6BagelDealCorrectDiscount()
    {

        ProductBundle bundle = new(BundleType.bagel6);
        Filling filling = new(FillingType.Bacon);

        bundle.BagelDeal6(BagelType.Plain, filling, filling, filling, filling, filling, filling);

        Assert.That(bundle.Discount, Is.EqualTo(0.0f));
    }

    [Test]
    public void Bagel12DealCorrectPrice()
    {

        ProductBundle bundle = new(BundleType.bagel12);
        Filling filling = new(FillingType.Bacon);

        bundle.BagelDeal12(BagelType.Plain, filling, filling, filling, filling, filling, filling, filling, filling, filling, filling, filling, filling);

        Assert.That(bundle.Price, Is.EqualTo(3.99f));
    }
}
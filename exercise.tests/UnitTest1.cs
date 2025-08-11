using exercise.main;
using System.ComponentModel;

namespace exercise.tests;

public class Tests
{
    [Test]
    public void TestItemAdded()
    {
        Basket basket = new(1);
        Filling filling = new Filling(1, FillingType.Plain);
        Bagel bagel = new(1.0f, filling);
        basket.AddItem(bagel);

        Assert.That(basket.Count, Is.EqualTo(1));

    }
    [Test]
    public void TestItemRemoved()
    {
        Basket basket = new(1);
        Filling filling = new Filling(1, FillingType.Plain);
        Bagel bagel = new(0.49f, filling);
        basket.AddItem(bagel);
        basket.RemoveItem(bagel.Id);

        Assert.That(basket.Count, Is.EqualTo(0));

    }

    [Test]
    public void CantRemoveNonExistentItem()
    {
        Basket basket = new(1);
        Filling filling = new Filling(1, FillingType.Plain);
        Bagel bagel = new(0.49f, filling);
        basket.AddItem(bagel);
        Bagel rmbagel = basket.RemoveItem(bagel.Id);

        Assert.That(rmbagel, Is.Null);

    }

    [Test]
    public void CheckPriceIsRight()
    {
        float price = 5.99f;
        Filling filling = new Filling(1, FillingType.Plain);
        Bagel bagel = new(0.49f, filling);

        bagel.changePrice(5.99f); // Inflation..

        Assert.That(price, Is.EqualTo(bagel.Price));
    }

    [Test]
    public void ChangedCapacityIsChanged()
    {
        int capacity = 5;

        Basket basket = new(1);

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
        Filling filling = new Filling(1, FillingType.Plain);

        Bagel bagel1 = new(0.2f, filling);
        Bagel bagel2 = new(0.5f, filling);

        Bagel result1 = basket.AddItem(bagel1);
        Bagel result2 = basket.AddItem(bagel2);

        Assert.That(result1, Is.InstanceOf(typeof(Bagel))); //Return added bagel upon succesfull add
        Assert.That(result2, Is.Null); //Return null when basket full
    }

    [Test]
    public void BasketTotalCostCorrect()
    {
        float price1 = 0.50f;
        float price2 = 0.70f;
        float price3 = 1.0f;

        Filling filling = new Filling(1, FillingType.Plain);

        Bagel bagel1 = new(price1, filling);
        Bagel bagel2 = new(price2, filling);
        Bagel bagel3 = new(price3, filling);

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
        Bagel bagel = new Bagel(0.50f);

        Filling filling = new(0.12f, FillingType.Onion);

        bagel.ChooseFillings(filling);

        Assert.That(bagel.Filling.Type, Is.EqualTo(FillingType.Onion));
    }

}
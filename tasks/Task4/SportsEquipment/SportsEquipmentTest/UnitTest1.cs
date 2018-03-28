using NUnit.Framework;
using System;
using Sports_equipment;

namespace Tests
{
    [TestFixture]
    public class SportEquipmentTests
    {
        [Test]
        public void canCreateNewEquipment()
        {
            var x = new SportsItem("Basketball", "1556-SPAL-89", "Spalding", 39.99m, Currency.EUR);

            Assert.IsTrue(x.Description == "Basketball");
            Assert.IsTrue(x.Brand == "Spalding");
            Assert.IsTrue(x.Price.Amount == 39.99m);
            Assert.IsTrue(x.Price.Unit == Currency.EUR);
            Assert.IsTrue(x.ArticleNumber == "1556-SPAL-89");
        }

        [Test]
        public void cannotCreateItemWithNegativePrice()
        {
            Assert.Catch(() =>
            {
                var x = new SportsItem("Basketball", "Spalding", "1556-SPAL-89", -39.99m, Currency.USD);
            });
        }

        [Test]
        public void canUpdatePrice()
        {
            var x = new SportsItem("Volleyball", "Hannahwald", "14879-Han-32", 39.99m, Currency.JPY);

            x.UpdatePrice(25.75m, Currency.JPY);
            Assert.IsTrue(x.Price.Amount == 25.75m);
            Assert.IsTrue(x.Price.Unit == Currency.JPY);
        }

       
    }

    [TestFixture]
    public class GameItemTest
    {
        [Test]
        public void canCreateNewGameItem()
        {
            var g = new GameItem("Luftballon", "78-LUF-788421", "Ballonmaker", 9.99m, Currency.CHR);

            Assert.IsTrue(g.Description == "Luftballon");
            Assert.IsTrue(g.Price.Amount == 9.99m);
            Assert.IsTrue(g.Price.Unit == Currency.CHR);
        }

        [Test]
        public void cannotCreateItemWithNegativePrice()
        {
            Assert.Catch(() =>
            {
                var g = new GameItem("Luftballon", "78-LUF-788421", "Ballonmaker", -9.99m, Currency.EUR);
            });
        }
    }

    [TestFixture]
    public class SaleSportsTest
    {
        [Test]
        public void canCreateSaleItem()
        {
            var s = new SaleSports(25.0, "Football", "455-FOOT-987", "Spalding", 23.95m, Currency.USD);
            Assert.IsTrue(s.Description == "Football");
            Assert.IsTrue(s.Brand == "Spalding");
            Assert.IsTrue(s.Price.Amount == (23.95m * (1 - 25.0m/100)));
            Assert.IsTrue(s.ArticleNumber == "455-FOOT-987");
            Assert.IsTrue(s.Price.Unit == Currency.USD);

        }
    }

    [TestFixture]
    public class SerializeTest
    {
        [Test]
        public void canSerializeToDisk()
        {
            var x = new SportsItem("Volleyball", "Hannahwald", "14879-Han-32", 39.99m, Currency.JPY);

            IPrint[] xColl = { x };

            var filename = "test.json";
            Serialize.serializeToDisk(xColl, filename);

            SportsItem[] g = Serialize.deserializeSportsItemFromFilename(filename);


            Assert.IsTrue(g[0].Description == "Volleyball");
            Assert.IsTrue(x.Price.Amount == 39.99m);
            Assert.IsTrue(x.Price.Unit == Currency.JPY);

            // Delete file after use
            Serialize.deleteFile(filename);
        }
    }
}

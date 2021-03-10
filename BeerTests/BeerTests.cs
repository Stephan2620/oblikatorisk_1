using Microsoft.VisualStudio.TestTools.UnitTesting;
using Beer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Beer.Tests
{
    [TestClass()]
    public class BeerTests
    {
        Beer ol = new Beer(1,"øller",25,1);
        [TestMethod()]
        public void id()
        {

            
            ol.Id = 1;

            Assert.AreEqual(expected: 1, actual: ol.Id);

        }
        [TestMethod()]
        public void Name()
        {


            ol.Name = "øller";

            Assert.AreEqual(expected: "øller", actual: ol.Name);

            Assert.ThrowsException<ArgumentException>(() => ol.Name = "abc");

        }
        [TestMethod()]
        public void Price()
        {

           

            ol.Price = 25;
       
            Assert.AreEqual(expected: 25, actual: ol.Price);
            Assert.ThrowsException<ArgumentException>(() => ol.Price = 0);

        }
        [TestMethod()]
        public void Abv()
        {

          

            ol.Abv = 0;
            Assert.AreEqual(expected: 0, actual: ol.Abv);
            ol.Abv = 100;
            Assert.AreEqual(expected: 100, actual: ol.Abv);
            ol.Abv = 50;
            Assert.AreEqual(expected: 50, actual: ol.Abv);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ol.Abv = -1);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ol.Abv = 101);

        }
    }
}
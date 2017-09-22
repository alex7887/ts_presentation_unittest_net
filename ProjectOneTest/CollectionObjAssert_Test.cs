using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ru.psit.ms.presentation.test;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProjectOneTest
{
    [TestClass]
    public class CollectionObjAssert_Test
    {

        private static List<Product> products;

        [ClassInitialize()]
        public static void initClassInitialize(TestContext testContext)
        {

            Debug.WriteLine("Init");

            products = new List<Product>();

            Product product1 = new Product();
            product1.Name = "spice";
            product1.Price = 10;
            products.Add(product1);

            Product product2 = new Product();
            product2.Name = "apple";
            product2.Price = 20;
            products.Add(product2);

            Product product3 = new Product();
            product3.Name = "rice";
            product3.Price = 30;
            products.Add(product3);



        }

        [TestMethod]
        public void testCollectionNull()
        {
            CollectionAssert.AllItemsAreNotNull(products, "products are null");
        }

        [TestMethod]
        public void testCollectionUnique()
        {
            CollectionAssert.AllItemsAreUnique(products, "values from products aren't uniq");
        }

        [TestMethod]
        public void testSubset()
        {

            List<Product> tempProducts = new List<Product>();

            //Product product = new Product();
            //product.Name = "spice";
            //product.Price = 10;
            //tempProducts.Add(product);

            tempProducts.Add(products[0]);

            CollectionAssert.IsSubsetOf(tempProducts, products, "product doesn't exist in collection");

        }

        [TestMethod]
        public void testContains()
        {
            
            Product product = new Product();
            product.Name = "spice";
            product.Price = 10;
            
            //CollectionAssert.Contains(products, product, "product doesn't exist");
            CollectionAssert.Contains(products, products[0], "product doesn't exist");

        }
    }
}

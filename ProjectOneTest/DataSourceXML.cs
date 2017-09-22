using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using ru.psit.ms.presentation.test;

namespace ProjectOneTest
{
    /// <summary>
    /// Summary description for DataSourceXML
    /// </summary>
    [TestClass]
    public class DataSourceXML
    {
       

        private TestContext testContextInstance;
                
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        private List<Product> products = new List<Product>();

        #region Additional test attributes
       
        #endregion
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Products.xml",
            "product", DataAccessMethod.Sequential)]
        [TestMethod]
        public void init()
        {
            //Microsoft.VisualStudio.TestTools.Resources.
            Debug.WriteLine("Init");

            String name = Convert.ToString(testContextInstance.DataRow["name"]);
            Double price = Convert.ToDouble(testContextInstance.DataRow["price"]);

            Product product = new Product();
            product.Name = name;
            product.Price = price;
            Debug.WriteLine("while");
            products.Add(product);
           

        }



        [TestMethod]
        public void testCheckProducts()
        {
            Debug.WriteLine("check");

            Product product = new Product();
            product.Name = "apple";
            product.Price = 20;
                       
            CollectionAssert.DoesNotContain(products, product, "product doesn't exist");

        }

       
       
    }
}

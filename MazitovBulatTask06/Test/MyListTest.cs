﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiblarySrtykt;

namespace Test
{
    [TestClass]
    public class MyListTest
    {
        [TestMethod]
        public void MyListArrayTest()
        {
            ListTest(LiblaryType.Array);
        }

        [TestMethod]
        public void MyListRefTest()
        {
            ListTest(LiblaryType.References);
        }

        private void ListTest(LiblaryType collectionType)
        {
            try
            {
                var ma = Choise.CreateAList<int>(collectionType, 10);
                ma.Insert(5, 0);
                ma.Insert(10, 1);
                ma.Insert(15, 2);

                int a = ma.Get(0);
                int b = ma.Get(1);
                int c = ma.Get(2);

                Assert.AreEqual(a, 5);
                Assert.AreEqual(b, 10);
                Assert.AreEqual(c, 15);

                ma.Remove(1);
                a = ma.Get(1);

                Assert.AreEqual(a, 15);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Assert.AreEqual(0, 1);
            }
        }
    }
}

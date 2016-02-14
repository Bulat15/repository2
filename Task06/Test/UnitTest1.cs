using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_03;

namespace DynamicArrayTest
{
    [TestClass]
    public class Tas_03_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                DynamicArray<int> m1 = new DynamicArray<int>();
                DynamicArray<int> m2 = new DynamicArray<int>(9);

                int[] arr = new[] { 1, 2, 3, 4, 5 };
                DynamicArray<int> m3 = new DynamicArray<int>(arr);

                var a = m3.Length;
                Assert.AreEqual(a, 5);
                var b = m3.Capacity;
                Assert.AreEqual(b, 5);

                m3.Add(6);
                var a1 = m3.Length;
                Assert.AreEqual(a1, 6);
                var b1 = m3.Capacity;
                Assert.AreEqual(b1, 10);

                int[] arr1 = new[] { 7, 8, 9, 10, 11, 12 };
                m3.AddRange(arr1);
                var a3 = m3.Length;
                Assert.AreEqual(a3, 12);
                var b3 = m3.Capacity;
                Assert.AreEqual(b3, 20);

                var flag1 = m3.Remove(7);
                var a4 = m3.Length;
                Assert.AreEqual(a4, 11);
                Assert.AreEqual(flag1, true);

                //m3.Insert(26,14); //Попытка вставить вне границ массива
                m3.Insert(6, 7);
                var b4 = m3[6];
                Assert.AreEqual(b4, 7);

                int k = 1;
                foreach (var elem in m3)
                {
                    var a5 = elem;
                    Assert.AreEqual(a5, k);
                    k++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Assert.AreEqual(0, 1);

            }
        }
    }
}

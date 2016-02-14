using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiblarySrtykt;

namespace Test
{
    [TestClass]
    public class MyStackTest
    {
        [TestMethod]
        public void MyQueueArrayTest()
        {
            QueueTest(LiblaryType.Array);
        }

        [TestMethod]
        public void MyQueueRefTest()
        {
            QueueTest(LiblaryType.References);
        }

        [TestMethod]
        public void QueueTest(LiblaryType collectionType)
        {
            try
            {
                var queue = Choise.CreateAQueue<int>(collectionType, 10);

                queue.Enqueue(3);
                queue.Enqueue(6);

                int a = queue.Dequeue();
                int b = queue.Dequeue();

                Assert.AreEqual(a, 3);
                Assert.AreEqual(b, 6);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Assert.AreEqual(0, 1);
            }
        }
    }
}

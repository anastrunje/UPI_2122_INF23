using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using Kviz;

namespace KvizTests.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBubbleSort()
        {
            List<string[]> niz1 = new List<string[]>();
            List<string[]> ocekivaniIzlaz1 = new List<string[]>();

            string[] temp = { "a", "1" };
            niz1.Add(temp);
            string[] temp2 = { "b", "4" };
            niz1.Add(temp2);
            string[] temp3 = { "c", "2" };
            niz1.Add(temp3);
            string[] temp4 = { "d", "5" };
            niz1.Add(temp4);
            string[] temp5 = { "e", "3" };
            niz1.Add(temp5);

            ocekivaniIzlaz1.Add(temp4);
            ocekivaniIzlaz1.Add(temp2);
            ocekivaniIzlaz1.Add(temp5);
            ocekivaniIzlaz1.Add(temp3);
            ocekivaniIzlaz1.Add(temp);

            Rang r = new Rang();
            List<string[]> izlaz1 = new List<string[]>();
            izlaz1 = r.BubbleSort(niz1);
            for (int i=0; i<izlaz1.Count;i++)
            {
                Assert.AreEqual(ocekivaniIzlaz1[i], izlaz1[i]);
            }
        }
    
    }
}

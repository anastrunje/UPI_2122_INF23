using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using Kviz;


namespace KvizTests
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
            ocekivaniIzlaz1.Add(temp);
            temp[0] = "b";
            temp[1] = "4";
            niz1.Add(temp);
            temp[0] = "c";
            temp[1] = "2";
            niz1.Add(temp);
            ocekivaniIzlaz1.Add(temp);
            temp[0] = "d";
            temp[1] = "5";
            niz1.Add(temp);
            temp[0] = "e";
            temp[1] = "3";
            niz1.Add(temp);
            ocekivaniIzlaz1.Add(temp);

            temp[0] = "b";
            temp[1] = "4";
            ocekivaniIzlaz1.Add(temp);
            temp[0] = "d";
            temp[1] = "5";
            ocekivaniIzlaz1.Add(temp);

            Rang r = new Rang();
            List<string[]> izlaz1 = new List<string[]>();
            izlaz1 = r.BubbleSort(niz1);
            Assert.AreEqual(ocekivaniIzlaz1, izlaz1);
        }
    }
}

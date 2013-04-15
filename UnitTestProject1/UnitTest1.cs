using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1() //volume true calc
        {
            int a = 5, b = 3, c = 10;

            Box bb = new Box(a,b,c);
            int v = bb.Volume2();

            Assert.AreEqual(a * b * c, v);
        }

        [TestMethod]
        public void TestMethod2() //box not equal?
        {
            int a1 = 5, b1 = 3, c1 = 10;
            Box box1 = new Box(a1, b1, c1);

            int a2 = 6, b2 = 4, c2 = 11;
            Box box2 = new Box(a2, b2, c2);

            Assert.AreNotEqual(box1, box2);
        }

        [TestMethod]
        public void TestMethod3()  //true?
        {
            int a = 5, b = 3, c = 10;

            Box bb = new Box(a, b, c);

            Assert.IsTrue(bb.Volume3());
        }

        [TestMethod]
        
        public void TestMethod4()  //wtf?)
        {
            int a = -2, b = 3, c = 10;

            try { new Box(a, b, c); Assert.Fail(); }
            catch ( BoxException e ) {}
        }

        [TestMethod]
        public void TestMethod5() //fatbox
        {
            int a1 = 5, b1 = 3, c1 = 10;
            Box box1 = new Box(a1, b1, c1);

            int a2 = 6, b2 = 4, c2 = 11;
            Box box2 = new Box(a2, b2, c2);

            Assert.IsTrue(box1.Width<box2.Width);
        }
    }
}

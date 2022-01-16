using Microsoft.VisualStudio.TestTools.UnitTesting;
using homework2Remake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2Remake.Tests
{
    [TestClass()]
    public class DeatAntTests
    {
        [TestMethod]
        public void testNullOrEmpty()
        {
            Assert.AreEqual(0, DeatAnt.DeadAntCount(null));
            Assert.AreEqual(0, DeatAnt.DeadAntCount(""));
        }
        [TestMethod]
        public void testNoDead()
        {
            Assert.AreEqual(0, DeatAnt.DeadAntCount("ant ant ant ant"));
        }
        [TestMethod]
        public void testNormal()
        {
            Assert.AreEqual(2, DeatAnt.DeadAntCount("ant anantt aantnt"));
        }
        [TestMethod]
        public void testNotNormal()
        {
            Assert.AreEqual(3, DeatAnt.DeadAntCount("...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t"));
        }
    }
}
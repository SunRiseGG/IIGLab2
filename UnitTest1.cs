using Microsoft.VisualStudio.TestTools.UnitTesting;
using IIG.BinaryFlag;
using System;

namespace Lab2 {
    [TestClass]
    public class UnitTest1 {

        [TestMethod]
        public void TestFlagTrue() {
            ulong tmp = 42069;
            MultipleBinaryFlag test1 = new MultipleBinaryFlag(tmp, true);
            Assert.IsTrue(test1.GetFlag());
        }

        [TestMethod]
        public void TestFlagFalse() {
            ulong tmp = 42069;
            MultipleBinaryFlag test1 = new MultipleBinaryFlag(tmp, false);
            Assert.IsFalse(test1.GetFlag());
        }

        [TestMethod]
        public void TestMinValue() {
            ulong tmp = UInt64.MinValue;
            MultipleBinaryFlag test1 = new MultipleBinaryFlag(tmp, true);
            Assert.IsTrue(test1.GetFlag());
        }

        [TestMethod]
        public void TestMaxValue() {
            ulong tmp = UInt64.MaxValue;
            MultipleBinaryFlag test1 = new MultipleBinaryFlag(tmp, true);
            Assert.IsTrue(test1.GetFlag());
        }

        [TestMethod]
        public void TestReset() {
            ulong tmp1 = 42069;
            ulong position = 420;
            MultipleBinaryFlag test1 = new MultipleBinaryFlag(tmp1, true);
            test1.ResetFlag(position);
            Assert.IsFalse(test1.GetFlag());
        }

        [TestMethod]
        public void TestSetOnFalse() {
            ulong tmp = 42069;
            ulong position = 420;
            MultipleBinaryFlag test1 = new MultipleBinaryFlag(tmp, false);
            test1.SetFlag(position);
            Assert.IsFalse(test1.GetFlag());
        }

        [TestMethod]
        public void TestSetOnTrue() {
            ulong tmp = 42069;
            ulong position = 420;
            MultipleBinaryFlag test1 = new MultipleBinaryFlag(tmp, true);
            test1.SetFlag(position);
            Assert.IsTrue(test1.GetFlag());
        }

        [TestMethod]
        public void TestAllSets() {
            ulong tmp = 2;
            ulong position1 = 0;
            ulong position2 = 1;
            MultipleBinaryFlag test1 = new MultipleBinaryFlag(tmp, false);
            test1.SetFlag(position1);
            test1.SetFlag(position2);
            Assert.IsTrue(test1.GetFlag());
        }
        
        [TestMethod]
        public void TestSet2() {
            ulong tmp = 2;
            ulong position = 0;
            MultipleBinaryFlag test1 = new MultipleBinaryFlag(tmp, false);
            test1.SetFlag(position);
            Assert.IsFalse(test1.GetFlag());
        }

        [TestMethod]
        public void TestMultipleReset() {
            ulong tmp = 2;
            ulong position1 = 0;
            ulong position2 = 1;
            MultipleBinaryFlag test1 = new MultipleBinaryFlag(tmp, false);
            test1.ResetFlag(position1);
            test1.ResetFlag(position2);
            Assert.IsFalse(test1.GetFlag());
        }

        [TestMethod]
        public void TestDisposeExcep() {
            ulong tmp = 42;
            Exception ex = null;
            MultipleBinaryFlag test1 = new MultipleBinaryFlag(tmp, false);
            test1.Dispose();
            try {
                test1.GetFlag();
            } catch(Exception e) {
                ex = e;
            }
            Assert.IsNotNull(ex);
        }

        [TestMethod]
        public void TestDispose() {
            ulong tmp = 42069;
            Exception ex = null;
            MultipleBinaryFlag test1 = new MultipleBinaryFlag(tmp, false);
            test1.Dispose();
            try {
                test1.GetFlag();
            } catch(Exception e) {
                ex = e;
            }
            Assert.IsNotNull(ex);
        }

        [TestMethod]
        public void TestMultipleDispose() {
            ulong tmp = 42069;
            Exception ex = null;
            MultipleBinaryFlag test1 = new MultipleBinaryFlag(tmp, false);
            test1.Dispose();
            try {
                test1.Dispose();
            } catch(Exception e) {
                ex = e;
            }
            Assert.IsNull(ex);
        }

    }
}

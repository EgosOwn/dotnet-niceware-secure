using NUnit.Framework;
using System;
using niceware;

namespace tests
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestToBytes()
        {
            byte[] bytes = {5, 3, 3, 2, 100, 255};
            var pass = Niceware.ToPassphrase(bytes);
            string[] expected = {"anatomic", "aliphatic", "homebuilding"};
            for (int i = 0; i < expected.Length; i++){
                Assert.IsEqual()
            }
        }


        [Test]
        public void TestGeneratePassphraseCount()
        {
            // 2 bytes per word
            Assert.IsTrue(Niceware.GeneratePassphrase(4).Count == 2);
        }



        [Test]
        public void TestNoOdd(){
            bool success = true;
            try{
                Niceware.GeneratePassphrase(3);
            }
            catch(System.ArgumentException){
                success = false;
            }
            Assert.IsFalse(success);
        }
    }
}
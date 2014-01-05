using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YGOEditor.Helper;

namespace TestUnit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Persist persist = new Persist("CODEEDITOR,FILENAME");

            Console.WriteLine(persist.ToString());
        }
    }
}

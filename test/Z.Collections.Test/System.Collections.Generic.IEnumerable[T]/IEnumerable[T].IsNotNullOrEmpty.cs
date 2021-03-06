// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright � ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_IEnumerable_T_IsNotNullOrEmpty
    {
        [TestMethod]
        public void IsNotNullOrEmpty()
        {
            // Type
            List<string> @thisNull = null;
            IEnumerable<string> @thisEmpty = new List<string>().AsEnumerable();
            IEnumerable<string> @thisNotEmpty = new List<string> {"Fizz"}.AsEnumerable();

            // Exemples
            bool result1 = @thisNull.IsNotNullOrEmpty(); // return false;
            bool result2 = @thisEmpty.IsNotNullOrEmpty(); // return false;
            bool result3 = @thisNotEmpty.IsNotNullOrEmpty(); // return true;

            // Unit Test
            Assert.IsFalse(result1);
            Assert.IsFalse(result2);
            Assert.IsTrue(result3);
        }
    }
}
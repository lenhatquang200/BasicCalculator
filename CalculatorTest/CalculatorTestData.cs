using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest
{
    public class CalculatorTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 1, 2, 3 };
            yield return new object[] { -5,-10,-15};
            yield return new object[] { -5,5,0};
            yield return new object[] { 10, -1, 9};
        }
        IEnumerator IEnumerable.GetEnumerator() =>GetEnumerator();
    }
}

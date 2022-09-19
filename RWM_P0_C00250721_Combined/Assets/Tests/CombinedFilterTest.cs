using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CombinedFilterTest
    {
        [Test]
        public void CombinedFilterSimple()
        {
            int[] input = { 4, 2, 3, 4, 5 };
            int[] output = CombinedFilter.combinedFilter(input);
            int[] expected = { 0, 2, 1, 1, 2 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
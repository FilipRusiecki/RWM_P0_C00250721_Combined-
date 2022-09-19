using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CombinedFilterTest
    {
        [Test]
        public void ModuloFirstSimple()
        {
            int[] input = { 3, 6, 9, 10, 11, 12 };
            int[] output = CombinedFilter.modulo(input);
            int[] expected = { 0, 0, 0, 1, 2, 0 };

            CollectionAssert.AreEqual(expected, output);
        }

        [Test]
        public void RunningTotalSimple()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6 };
            int[] output = CombinedFilter.runtotal(input);
            int[] expected = { 4, 6, 14, 17, 26, 30, 40, 45, 56, 62 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
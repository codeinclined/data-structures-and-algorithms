using KAryTree;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FindMatchesTesting
{
    /// <summary>
    /// Provides four test case for unit testing
    /// </summary>
    class FindMatchesTestingData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            KAryTree<char> tree = new KAryTree<char>('A');

            #region Fill in the tree with 1 A, 2 B's, 3 C's, 4 D's
            tree.Add('B', 'A');
            tree.Add('B', 'B');
            tree.Add('C', 'B');
            tree.Add('C', 'A');
            tree.Add('C', 'C');
            tree.Add('D', 'A');
            tree.Add('D', 'B');
            tree.Add('D', 'C');
            tree.Add('D', 'D');
            #endregion

            yield return new object[] { tree, 'A', 1 };
            yield return new object[] { tree, 'B', 2 };
            yield return new object[] { tree, 'C', 3 };
            yield return new object[] { tree, 'D', 4 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

using KAryTree;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PrintLevelOrderTest
{
    /// <summary>
    /// Provides three test cases for unit testing PrintLevelOrder
    /// </summary>
    class PrintLevelOrderTestingData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            #region Yield Return Tree From Example in Instructions
            KAryTree<char> instructionsTree = new KAryTree<char>('A');

            instructionsTree.Add('B', 'A');
            instructionsTree.Add('C', 'A');
            instructionsTree.Add('D', 'A');
            instructionsTree.Add('E', 'A');
            instructionsTree.Add('F', 'A');
            instructionsTree.Add('G', 'A');

            instructionsTree.Add('H', 'B');
            instructionsTree.Add('I', 'B');
            instructionsTree.Add('J', 'B');

            instructionsTree.Add('K', 'E');
            instructionsTree.Add('L', 'E');

            instructionsTree.Add('M', 'G');

            instructionsTree.Add('N', 'H');
            instructionsTree.Add('O', 'H');

            instructionsTree.Add('P', 'K');

            instructionsTree.Add('Q', 'L');

            yield return new object[] { instructionsTree, "A \r\nB C D E F G \r\nH I J K L M \r\nN O P Q \r\n"};
            #endregion

            #region Yield Return A Second Tree
            KAryTree<char> tree2 = new KAryTree<char>('A');

            tree2.Add('B', 'A');
            tree2.Add('C', 'B');
            tree2.Add('D', 'C');
            tree2.Add('E', 'C');
            tree2.Add('F', 'E');

            yield return new object[] { tree2, "A \r\nB \r\nC \r\nD E \r\nF \r\n" };
            #endregion

            #region Yield Return a Third Tree With Only a Root
            KAryTree<char> tree3 = new KAryTree<char>('A');

            yield return new object[] { tree3, "A \r\n" };
            #endregion
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

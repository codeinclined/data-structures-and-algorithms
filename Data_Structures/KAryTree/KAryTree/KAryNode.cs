using System;
using System.Collections.Generic;
using System.Text;

namespace KAryTree
{
    public class KAryNode<T>
    {
        public T Value { get; set; }
        public List<KAryNode<T>> Children { get; internal set; } = new List<KAryNode<T>>();
    }
}

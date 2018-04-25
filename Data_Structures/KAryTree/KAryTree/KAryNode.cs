using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo("KAryTest")]

namespace KAryTree
{
    public class KAryNode<T>
    {
        public T Value { get; set; }
        public List<KAryNode<T>> Children { get; internal set; } = new List<KAryNode<T>>();
    }
}

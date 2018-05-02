using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo("HashTablesTesting")]

namespace HashTables
{
    /// <summary>
    /// Hash table based around a simple unicode code point, prime factor,
    /// and modulus hash for keys of type KeyT paired with values of type
    /// ValueT. Keys are hashed based on their ToString() representations,
    /// therefore the output of this method must be different for each
    /// instance to be properly hashed by the hashing algorithm.
    /// 
    /// Linked lists are used in case of hashing collisions. The number of
    /// buckets used to hold these linked lists can be changed in the
    /// constructor. Powers of 2 are most efficient for the modulus
    /// operation needed by the hashing algorithm.
    /// </summary>
    /// <typeparam name="KeyT">The type of keys used in each key/value pair. This type
    /// should has a ToString() method that differentiates between instances in order to
    /// allow the hashing algorithm to produce useful hashes for keys</typeparam>
    /// <typeparam name="ValueT">The type of values used in each key/value pair</typeparam>
    public class HashTable<KeyT, ValueT>
    {
        /// <summary>
        /// Bucket array for each of the hashed key indexed linked lists
        /// </summary>
        internal BucketNode<KeyT, ValueT>[] Buckets { get; set; }

        /// <summary>
        /// The number of buckets allocated for the hash table
        /// </summary>
        public int BucketCount => Buckets.Length;

        /// <summary>
        /// The prime number used in the hashing algorithm to produce bucket indexes
        /// </summary>
        public static int PrimeFactor => 1019;

        /// <summary>
        /// Constructor for the HashTable class. Optionally takes in a 
        /// </summary>
        /// <param name="bucketCount">The number of buckets allocated for
        /// the hash table. Powers of 2 offer the most efficient hashing
        /// of keys (defaults to 2^10: 1024)</param>
        public HashTable(int bucketCount = 1024) => 
            Buckets = new BucketNode<KeyT, ValueT>[bucketCount];

        /// <summary>
        /// Retrieve the index for the bucket that contains nodes for the provided
        /// key using a simple hash based on multiplication with the PrimeFactor
        /// property and a modulus with BucketCount to place the index into the
        /// range of the Buckets array. Uses the ToString() method of KeyT, therefore
        /// this method depends on the output of ToString() being unique enough to
        /// differentiate between keys.
        /// </summary>
        /// <param name="key">The key to hash and retrieve a bucket index for.</param>
        /// <returns>The bucket index corresponding to the hashed representation of
        /// the provided key.</returns>
        protected internal int GetHash(KeyT key)
        {
            int hash = 0;

            // Accumulate all unicode code points after converting the key to
            // a string
            foreach (char b in key.ToString())
            {
                hash += b;
            }

            return (hash * PrimeFactor) % BucketCount;
        }

        /// <summary>
        /// Attempts to get a specific BucketNode object by key. Returns true and sets the
        /// bucketNode out parameter to the node corresponding to the specified key. Returns
        /// false if no nodes containing the specified key exist with the out parameter
        /// set to null.
        /// </summary>
        /// <param name="key">The key to search for</param>
        /// <param name="bucketNode">Out parameter set to the node corresponding to the
        /// requested key if found; otherwise, this parameter will be null</param>
        /// <returns>True if a node with the specified key exists; false otherwise</returns>
        internal bool TryGetBucketNodeByKey(KeyT key, out BucketNode<KeyT, ValueT> bucketNode)
        {
            bucketNode = Buckets[GetHash(key)];

            // Try to find the first bucket node that matches the provided key
            while (bucketNode != null)
            {
                if (bucketNode.Key.Equals(key))
                {
                    break;
                }

                bucketNode = bucketNode.Next;
            }

            return bucketNode != null;
        }

        /// <summary>
        /// Tries to find the specified key within the hash table. If the key is
        /// found, then the found field of the returned value tuple is set to
        /// true and the value field is set to the value matching the key.
        /// Otherwise, the found field of the returned value tuple is set to
        /// false and the value field is set to the default value of ValueT.
        /// </summary>
        /// <param name="key">The key corresponding to the requested key/value
        /// pair</param>
        /// <returns>Value tuple with the found field set to whether the requested
        /// key exists in the hash table. The value field is set to the value
        /// held by the key/value pair if it exists; otherwise, it is set to the
        /// default value of type ValueT.</returns>
        public (bool found, ValueT value) Contains(KeyT key)
        {
            // Try to find a node with the specified key in the hash table
            bool found = TryGetBucketNodeByKey(key, out BucketNode<KeyT, ValueT> bucketNode);

            // Return a value tuple containing a bool based on whether a node matching the
            // specified key exists as well a the value of that node or the default value for
            // ValueT if the specified node does not exist.
            return (found: found, value: bucketNode != null ? bucketNode.Value : default(ValueT));
        }

        /// <summary>
        /// Add a new key/value pair to the hash table.
        /// </summary>
        /// <param name="key">The key for the newly added value</param>
        /// <param name="value">The value for the newly added key</param>
        /// <exception cref="ArgumentException">Thrown if the specified
        /// key already exists in the hash table.</exception>
        public void Add(KeyT key, ValueT value)
        {
            // Do not allow an existing key to be overwritten
            if (Contains(key).found)
            {
                throw new ArgumentException(
                    "The specified key already exists in the hash table! Use indexer to re-assign values to existing keys.", nameof(key));
            }

            // Push a new bucket node onto the bucket containing our new value
            int bucketIndex = GetHash(key);
            Buckets[bucketIndex] = new BucketNode<KeyT, ValueT>(key, value) { Next = Buckets[bucketIndex] };
        }

        /// <summary>
        /// Provides a getter and setter for specific keys' values through an indexer.
        /// Getter throws a KeyNotFoundException if the key does not exist. The setter
        /// will either modify the existing, matching node's value or create a new one
        /// containing the specified value if it does not yet exist.
        /// </summary>
        /// <param name="key">The key to either get or set the value for</param>
        /// <returns>The value of the node corresponding to the specified key</returns>
        /// <exception cref="KeyNotFoundException">A key was specified to the getter
        /// that does not exist in the hash table.</exception>
        public ValueT this[KeyT key] {
            get {
                (bool found, ValueT value) = Contains(key);
                return found ? value : throw new KeyNotFoundException();
            }
            set {
                // If the key already exists, change its corresponding node's value; otherwise
                // add a new node matching the specified key with the specified value
                if (TryGetBucketNodeByKey(key, out BucketNode<KeyT, ValueT> bucketNode))
                {
                    bucketNode.Value = value;
                }
                else
                {
                    Add(key, value);
                }
            }
        }
    }
}

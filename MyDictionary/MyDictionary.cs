using System;
namespace MyDictionary
{
    public class MyDictionary<K,V>
    {
        K[] keys;
        V[] values;

        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }

        public void Add(K key, V value)
        {
            K[] tempKeys = keys;
            V[] tempValues = values;

            keys = new K[tempKeys.Length+1];
            values = new V[tempValues.Length+1];

            for (int i = 0; i < tempValues.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[keys.Length-1] = key;
            values[values.Length-1] = value;
        }

        public int Count
        {
            get { return keys.Length; }
        }
    }

}

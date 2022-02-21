using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
     class MyDictionary<K,V>
    {
        K[] keys;
        V[] values;
        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
            
                
        }

        public void Add(K key,V value)
        {
            K[] tempkeys= keys;
            V[] tempvalues= values;
            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];
            for (int i = 0; i < tempkeys.Length; i++)
            {
                keys[i] = tempkeys[i];
                values[i] = tempvalues[i];

            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] =value;
           
        }

        

    }
}

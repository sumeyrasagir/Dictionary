using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<KeyT, ValueT>
    {
        KeyT[] keyTs;
        ValueT[] valueTs;

        public MyDictionary()
        {
            keyTs = new KeyT[0];
            valueTs = new ValueT[0];
        }

        public void Add(KeyT keyT , ValueT valueT)
        {
            KeyT[] tempKeyT = keyTs;
            ValueT[] tempValueT = valueTs;

            keyTs = new KeyT[keyTs.Length + 1];
            valueTs = new ValueT[valueTs.Length + 1];

            for (int i = 0; i < tempKeyT.Length; i++)
            {
                keyTs[i] = tempKeyT[i];
                valueTs[i] = tempValueT[i];
            }

            keyTs[keyTs.Length - 1] = keyT;
            valueTs[valueTs.Length - 1] = valueT;

        }

        public void Show()
        {
            for (int i = 0; i < keyTs.Length; i++)
            {
                Console.WriteLine(keyTs[i] + " = " + valueTs[i]);
            }
        }
    }
}

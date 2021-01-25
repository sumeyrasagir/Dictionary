using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("Elma", "Apple");
            myDictionary.Add("Karpuz", "Watermelon");
            myDictionary.Add("Portakal", "Orange");
            myDictionary.Add("Kayısı", "Apricot");
            myDictionary.Show();
        }
    }
}

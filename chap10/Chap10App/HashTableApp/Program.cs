﻿using System;
using System.Collections;

namespace HashTableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HashTable예제");

            Hashtable ht = new Hashtable();
            ht["일"] = "One";
            ht["이"] = "Two";
            ht["삼"] = "Three";
            ht["사"] = "Four";

            Console.WriteLine(ht["일"]); //One
            Console.WriteLine(ht["이"]); //Two
            Console.WriteLine(ht["사"]); //Four

            foreach(DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key } : {item.Value}");

            }
        }
    }
}

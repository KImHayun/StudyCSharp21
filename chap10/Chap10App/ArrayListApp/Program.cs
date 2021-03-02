﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList(new[] { 80, 74, 81, 90, 34});
            /*array.Add(80);
            array.Add(74);
            array.Add(81);
            array.Add(90);
            array.Add(34);*/

            var loc = array.IndexOf(81);
            array.Insert(loc, 50);
            

            
            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }

            array.RemoveAt(4); // 90 삭제
            foreach (var item in array) 
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("정렬");
            array.Sort(); 
            foreach (var item in array )
            {
                Console.WriteLine($"");
            }
        }

    }
}

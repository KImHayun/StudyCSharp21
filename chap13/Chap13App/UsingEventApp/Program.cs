﻿using System;

namespace UsingEventApp
{
    delegate void EventHandler(string message); //메시지 받아서 처리하는 대리자 선언


    class CustomNotifier
    {
        //이벤트 선언, 사용하는 객체
        public event EventHandler SomethingHappened; //대리자의 인스턴스 이벤트

        public void Dosomething(int number)
        {
            int temp = number % 10; // 46 % 10 = 3 % 3 == 0
            
            if( temp != 0 && temp % 3 == 0 )// 3, 6, 9로 떨어지는 값
            {
                SomethingHappened($"{number}: 짝!"); //이벤트를 사용
            }
        }
    }


    class Program
    {
        public static void MyHandler(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("이벤트사용!");
            CustomNotifier notifier = new CustomNotifier();
            notifier.SomethingHappened += new EventHandler(MyHandler); //이벤트를 내가 만든 로직이 있는 메서드랑 연결

            for (int i = 1; i <=100; i++)
            {
                notifier.Dosomething(i);
            }

        }
    }
}

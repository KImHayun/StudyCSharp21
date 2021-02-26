using System;
using System.Collections.Generic;
using System.Text;

namespace NewInheritTestApp
{
    class Dog : Animal
    {
        public void Bark() //실행을 위한 메서드
        {
            Console.WriteLine($"{this.Name} : 멍멍!");
        }
    public void HowOld()
        {
            Console.WriteLine($"{this.Name}의 나이는 {this.Age}");
        }
    }

}

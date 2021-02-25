using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideTestApp
{
    class ArmorSuite
    {
    
        //자식 클래스에서 재정의
        public virtual void Initialize()
        {
            Console.WriteLine("ArmorSuite 초기화!");
        }
    
        public void Initialize()
        {
            base.Initialize();
            Console.WriteLine("ArmorSuite 개량 Warmachine개량!");
            Console.WriteLine("Double-Barrel 캐논 장착!");
            Console.WriteLine("Micro-Rocket 런처 장착!");
        }

    }
    class IronMan : ArmorSuite

    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine()
        }
    }
    class WarMachine
    {

    }
    class program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("ArmorSuite 생산");
            ArmorSuite suite = new ArmorSuite();
            suite.Initialize();

            Console.WriteLine("WarMachine 생산");
            WarMachine machine = new WarMachine();
            machine.Initialize();
        }
    }
}

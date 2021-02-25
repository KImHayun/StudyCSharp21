using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheriTestApp
{ 
    class parent
    {
      protected string Name;

        public Parent(string Name)
            { 
              this.Name = Name;
              Console.WriteLine($"{this.Name}.parent () 생성자");          
             }
        ~parent()
        { 
        }
   public void ParentMethod()
    {
        // ...
        Console.WriteLine($"{this.Name}.ParentMethod()실행");

    }
}
class Child : Parent
    { 
        private string Color; //색상

    public Child (string Name) : base (Name)
    {
        Console.WriteLine($"{this.Name}.Child()생성자");

    }
    public Child(string Name) : base(Name)
    {
        Console.WriteLine($"{this.Name}.ChildMethod()생성자");

    }
        class MainApp
        {
            static void Main(String[]args)
                parent p = new parent("부모");
            p.ParentMethod(); // 부모클래스에서 메서드 실행
            
            Child c = new Child("자식");
            c.color ="황색"
            c.ParentMethod(); //부모의 메서드 실행
            c.ChildMethod(); //자식클래서 메서드 실행
        }

}
}
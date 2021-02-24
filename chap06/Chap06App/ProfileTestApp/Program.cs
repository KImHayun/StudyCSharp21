using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            printProfile("김하윤", "010-1234-56");
            Console.WriteLine("프로그램 출력 시 오류가 발생.");

        }
      
            

        public static void printProfile(String name, string phone)

        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("이름을 정확히 입력하시오.");
                
            }
            /* 프로필 출력 */
            Console.WriteLine($"이름: {name}, 폰번호 : {phone}");
            return 0; 
        }         
    }
}

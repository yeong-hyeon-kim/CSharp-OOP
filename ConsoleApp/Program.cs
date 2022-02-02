using ClassLibrary.Inheritance;
using ClassLibrary.Polymorphism;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 상속 테스트
            NoteBook GalaxyBook = new NoteBook("갤럭시 북", "삼성전자", "Windows 11", "i9-12600K", "RTX3090Ti", "64GB", "2TB");
            NoteBook MacBook = new NoteBook("맥북 프로", "애플", "MacOS", "MX1", "Radeon", "32GB", "1TB");

            GalaxyBook.PrintInfomation();
            MacBook.PrintInfomation();

            // 다형성 테스트
            // 공통적인 특징을 가지고 있지만 각각의 특성을 표현하기 위해서는 각각의 클래스를 만들어야 할까?
            // 비효율적이다? 왜 비효율적일까?
            // 각각의 특성을 표현하기 위해서는 각각의 클래스에 다시 공통적인 특성을 포함시켜야한다.

            // 그런 이유로 공통 클래스를 상속해서 공통적인 특징은 이미 가지고 있지만 자신만의 특성만 추가하거나
            // 공통적인 부분을 재정의하여 나만의 특성을 표현할 수 있음.

            Phone Phone1 = new Galaxy();
            Galaxy GalaxyS22 = (Galaxy)Phone1;

            GalaxyS22.Sending();
            GalaxyS22.Calling();
            GalaxyS22.SamsungPay();

            // 사용하는 이유는? : 공통적인 특성을 가지고 각자의 특성을 표현할 수 있다.
            // 공통적인 특성을 각 클래스에서 중복으로 정의하지 않고도 각자의 특성을 표현할 수 있다.

            Phone Phone2 = new iPhone();
            iPhone iPhone13 = (iPhone)Phone2;

            iPhone13.MacSafe();
        }
    }
}
using ClassLibrary.Encapsulation;
using ClassLibrary.Inheritance;
using ClassLibrary.Polymorphism;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 상속
            // 상위 클래스 특성을 이어받아 특성을 사용하거나 확장할 수 있다.
            NoteBook GalaxyBook = new NoteBook("갤럭시 북", "삼성전자", "Windows 11", "i9-12600K", "RTX3090Ti", "64GB", "2TB");
            NoteBook MacBook = new NoteBook("맥북 프로", "애플", "MacOS", "MX1", "Radeon", "32GB", "1TB");

            GalaxyBook.PrintInfomation();
            MacBook.PrintInfomation();

            // 다형성
            // 공통적인 특징을 가지고 있지만 각각의 특성을 표현하기 위해서는 각각의 클래스를 만들어야 할까?
            // 비효율적이다? 왜 비효율적일까?
            // 각각의 특성을 표현하기 위해서는 각각의 클래스에 다시 공통적인 특성을 포함시켜야한다.

            // 그런 이유로 공통 클래스를 상속해서 공통적인 특징은 이미 가지고 있지만 자신만의 특성만 추가하거나
            // 공통적인 부분을 재정의하여(Override) 나만의 특성을 표현할 수 있음.

            SmartPhone Phone1 = new Galaxy();
            Galaxy GalaxyS22 = (Galaxy)Phone1;

            GalaxyS22.Sending();
            GalaxyS22.Call();
            GalaxyS22.SamsungPay();

            // 사용하는 이유는? : 공통적인 특성을 가지고 각자의 특성을 표현할 수 있다.
            // 공통적인 특성을 각 클래스에서 중복으로 정의하지 않고도 각자의 특성을 표현할 수 있다.

            SmartPhone Phone2 = new SmartPhone();
            iPhone iPhone13 = (iPhone)Phone2;

            iPhone13.MacSafe();

            // 캡슐화 테스트
            Switch s = new Switch();

            NoteBook noteBook = new NoteBook();
            SmartPhone smartPhone = new SmartPhone();

            s.SwitchTurnOn(noteBook);
            s.SwitchTurnOff(noteBook);

            s.SwitchTurnOn(smartPhone);
            s.SwitchTurnOff(smartPhone);
        }
    }

    class Switch
    {
        /// <summary>
        /// 상위 타입을 매개변수 형식으로 설정하여 인터페이스를 구현하고 있는 클래스가 재정의한 메서드를 실행.
        /// 인터페이스가 아닌 클래스 타입으로 매개변수를 받으면 각 클래스 마다 SwitchTurnOff, SwitchTurnOn 메서드를 생성해야한다.
        /// 하위 타입인 각 클래스들은 상위 타입인 인터페이스 타입에 포함되어 인터페이스를 상속하는 클래스라면 타입에 관계없이 매개변수로 받을 수 있다.
        /// > 매개변수 타입이 특정 클래스 타입이 아니므로 의존성이 줄어든다.
        /// </summary>
        /// <param name="Device"></param>
        public void SwitchTurnOff(IPower Device)
        {
            Device.TurnOff();
        }
        public void SwitchTurnOn(IPower Device)
        {
            Device.TurnOn();
        }
    }
}
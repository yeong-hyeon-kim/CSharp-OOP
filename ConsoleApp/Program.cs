using ClassLibrary.Abstraction;
using ClassLibrary.Encapsulation;
using ClassLibrary.Inheritance;
using ClassLibrary.Polymorphism;

namespace ConsoleApp
{
    class Program
    {
        private static SmartPhoneFactory Factory;

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

            SmartPhone GalaxyPhone = new Galaxy();
            Galaxy GalaxyS22 = (Galaxy)GalaxyPhone;

            GalaxyS22.Message();
            GalaxyS22.Call();

            // 사용하는 이유는? : 공통적인 특성을 가지고 각자의 특성을 표현할 수 있다.
            // 공통적인 특성을 각 클래스에서 중복으로 정의하지 않고도 각자의 특성을 표현할 수 있다.

            SmartPhone Phone = new iPhone();
            iPhone iPhone13 = (iPhone)Phone;

            iPhone13.MacSafe();

            // 캡슐화
            Switch s = new Switch();

            NoteBook noteBook = new NoteBook();
            SmartPhone smartPhone = new SmartPhone();

            s.SwitchTurnOn(noteBook);
            s.SwitchTurnOff(noteBook);

            s.SwitchTurnOn(smartPhone);
            s.SwitchTurnOff(smartPhone);

            // 추상화

            // 인터페이스는 자신을 구현하는 클래스라면 자신이 정의한 메서드가 무조건 있다는 걸 보장한다.
            // 클래스가 인터페이스를 상속받으면 구현하는 걸 강제하기 때문이다.

            // 의존성 주입 왜 사용하나?
            // 외부 클래스(A)에서 특정 클래스(B)의 메소드(M1)를 사용하고 있을때 클래스(B)를 클래스(C)로 변경하면 클래스(C)에 메소드(M1) 없다면 더이상 메소드(M1)를 사용할 수 없다.
            // 메소드(M1)를 정의한 인터페이스를 상속하는 클래스라면 무조건 메소드(M1) 구현(재정의)하므로 클래스가 변경되어도 코드를 수정할 필요가 없다.

            // 의존성 주입(Dependency Injection)
            // 클래스 외부(ConsoleApp.Program)에서 객체(Galaxy)를 생성하여 클래스 내부(SmartPhoneFactory)에 주입.
            Factory = new SmartPhoneFactory(new Galaxy());
            Factory._phone.Camera();
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
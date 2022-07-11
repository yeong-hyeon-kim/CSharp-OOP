using ClassLibrary.Inheritance;
using System;

namespace ClassLibrary.Polymorphism
{
    public class iPhone : SmartPhone
    {
        /// <summary>
        /// 다형성 - 상위 클래스 메서드를 다양한 형태로 이용할 수 있는 성질
        /// </summary>
        public override void Call()
        {
            Console.WriteLine("아이폰 휴대폰 전화 걸기 및 받기");
        }

        public override void Sending()
        {
            Console.WriteLine("i 메시지");
        }

        public void MacSafe()
        {
            Console.WriteLine("맥 세이프");
        }
    }
}

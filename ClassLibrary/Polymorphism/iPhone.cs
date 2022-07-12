using ClassLibrary.Abstraction;
using ClassLibrary.Inheritance;
using System;

namespace ClassLibrary.Polymorphism
{
    public class iPhone : SmartPhone, ISmartPhone
    {
        /// <summary>
        /// 다형성 - 상위 클래스 메서드를 다양한 형태로 이용할 수 있는 성질
        /// </summary>

        public override void Call()
        {
            Console.WriteLine("아이폰 전화 걸기 및 받기");
        }

        /// <summary>
        /// 카메라
        /// </summary>
        public override void Camera()
        {
            Console.WriteLine("Prores");
        }

        /// <summary>
        /// 인터넷
        /// </summary>
        public override void Internet()
        {
            Console.WriteLine("사파리");
        }

        /// <summary>
        /// 메시지
        /// </summary>
        public override void Message()
        {
            Console.WriteLine("i 메시지");
        }

        /// <summary>
        /// 결제
        /// </summary>
        public override void Payment()
        {
            Console.WriteLine("애플 페이");
        }

        /// <summary>
        /// 다형성 - 아이폰 특화
        /// </summary>
        public void MacSafe()
        {
            Console.WriteLine("맥 세이프");
        }
    }
}

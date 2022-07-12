using ClassLibrary.Abstraction;
using ClassLibrary.Encapsulation;
using System;

namespace ClassLibrary.Inheritance
{
    /// <summary>
    /// 상속을 통해 클래스를 구현, 확장하는 작업.
    /// Computer를 SmartPhone로 구체화.
    /// </summary>
    public class SmartPhone : Computer, IPower
    {
        public void TurnOff()
        {
            Console.WriteLine("휴대폰을 종료하려면 오른쪽 상단에 있는 버튼을 꾹 눌러주세요.");
        }

        public void TurnOn()
        {
            Console.WriteLine("휴대폰을 부팅하려면 오른쪽 상단에 있는 버튼을 꾹 눌러주세요.");
        }

        /// <summary>
        /// 전화
        /// </summary>
        public virtual void Call()
        {
            Console.WriteLine("전화 걸기 및 받기");
        }

        /// <summary>
        /// 카메라
        /// </summary>
        public virtual void Camera()
        {
            Console.WriteLine("사진 또는 동영상 촬영");
        }

        /// <summary>
        /// 인터넷
        /// </summary>
        public virtual void Internet()
        {
            Console.WriteLine("웹 서핑");
        }

        /// <summary>
        /// 메시지
        /// </summary>
        public virtual void Message()
        {
            Console.WriteLine("문자 보내기");
        }

        /// <summary>
        /// 결제
        /// </summary>
        public virtual void Payment()
        {
            Console.WriteLine("문자 보내기");
        }
    }
}

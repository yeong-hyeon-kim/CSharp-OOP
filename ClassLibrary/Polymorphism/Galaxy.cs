using ClassLibrary.Abstraction;
using ClassLibrary.Inheritance;
using System;

namespace ClassLibrary.Polymorphism
{
    public class Galaxy : SmartPhone, ISmartPhone
    {
        /// <summary>
        /// 다형성 - 상위 클래스 메서드를 다양한 형태로 이용할 수 있는 성질
        /// </summary>

        public override void Call()
        {
            Console.WriteLine("갤럭시 전화 걸기 및 받기");
        }

        /// <summary>
        /// 카메라
        /// </summary>
        public override void Camera()
        {
            Console.WriteLine("1억 800만 화소");
        }

        /// <summary>
        /// 인터넷
        /// </summary>
        public override void Internet()
        {
            Console.WriteLine("삼성 인터넷");
        }

        /// <summary>
        /// 메시지
        /// </summary>
        public override void Message()
        {
            Console.WriteLine("메시지 +");
        }

        /// <summary>
        /// 결제
        /// </summary>
        public override void Payment()
        {
            Console.WriteLine("문자 보내기");
        }

        /// <summary>
        /// 다형성 - 갤럭시 특화
        /// </summary>
        public void VoiceRecord()
        {
            Console.WriteLine("통화 녹음");
        }
    }
}

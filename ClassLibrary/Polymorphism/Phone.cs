using System;

namespace ClassLibrary.Polymorphism
{
    public class Phone
    {
        /// <summary>
        /// 다형성 - 상위 클래스 메서드를 다양한 형태로 이용할 수 있는 성질
        /// </summary>
        public virtual void Calling()
        {
            Console.WriteLine("전화 걸기");
        }

        public virtual void Sending()
        {
            Console.WriteLine("문자 보내기");
        }
    }
}

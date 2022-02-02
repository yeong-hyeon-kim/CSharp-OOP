using System;

namespace ClassLibrary.Polymorphism
{
    public class Galaxy : Phone
    {
        public override void Calling()
        {
            Console.WriteLine("삼성 휴대폰");
        }

        public override void Sending()
        {
            Console.WriteLine("메시지 +");
        }

        public void SamsungPay()
        {
            Console.WriteLine("삼성페이");
        }
    }
}

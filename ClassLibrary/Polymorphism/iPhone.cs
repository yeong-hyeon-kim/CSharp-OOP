using System;

namespace ClassLibrary.Polymorphism
{
    public class iPhone : Phone
    {
        public override void Calling()
        {
            Console.WriteLine("애플 휴대폰");
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

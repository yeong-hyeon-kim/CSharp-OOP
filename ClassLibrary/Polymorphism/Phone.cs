using System;

namespace ClassLibrary.Polymorphism
{
    public class Phone
    {
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

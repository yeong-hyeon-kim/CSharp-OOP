namespace ClassLibrary.Abstraction
{
    public class SmartPhoneFactory
    {
        public ISmartPhone _phone;

        public SmartPhoneFactory(ISmartPhone phone)
        {
            _phone = phone;
        }
    }
}
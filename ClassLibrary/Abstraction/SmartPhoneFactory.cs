namespace ClassLibrary.Abstraction
{
    public class SmartPhoneFactory
    {
        /// <summary>
        /// 외부에서 의존 관계가 주입(DI)되고 그 타입에 따라 하위 타입(Class)이 결정된다. 
        /// </summary>
        public ISmartPhone _phone;

        /// <summary>
        /// 외부에서 주입하는 클래스는 무조건 ISmartPhone을 상속 받아야한다.
        /// 하위
        /// </summary>
        /// <param name="phone">외부에서 주입되는 의존관계(ISmartPhone를 구현(재정의)한 클래스(Class))를 받는 매개 변수</param>
        public SmartPhoneFactory(ISmartPhone phone)
        {
            _phone = phone;
        }
    }
}
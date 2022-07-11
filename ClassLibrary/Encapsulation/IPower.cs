namespace ClassLibrary.Encapsulation
{
    public interface IPower
    {
        // 은닉화 : 구현을 숨기고, 동작만 노출한다.
        // 느슨한 결합 : 언제든 구현을 수정 할 수 있다.

        // 공통된 특징(행위)만 선언하고 구체적인 내용은 각 클래스에서 구체화하도록 유도.
        // 인터페이스에서 추상화한 특징(행위)를 각 클래스 노트북, 휴대폰이 어떻게 전원을 켜고 끄는지 정의하도록 강제한다.
        // 각 클래스에서 재정의 하지 않으면 클래스

        /// <summary>
        /// 모든 전자제품은 전원을 킨다.
        /// </summary>
        void TurnOn();
        /// <summary>
        /// 모든 전자제품은 전원을 끈다.
        /// </summary>
        void TurnOff();
    }
}

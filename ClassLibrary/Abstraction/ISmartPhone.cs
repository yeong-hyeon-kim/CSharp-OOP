namespace ClassLibrary.Abstraction
{
    //  스마트폰 설계도 : 스마트폰 대표적 기능들
    public interface ISmartPhone
    {
        public void Call()
        {
        }

        /// <summary>
        /// 카메라
        /// </summary>
        public void Camera()
        {
        }

        /// <summary>
        /// 인터넷
        /// </summary>
        public void Internet()
        {
        }

        /// <summary>
        /// 메시지
        /// </summary>
        public void Message()
        {
        }

        /// <summary>
        /// 결제
        /// </summary>
        public void Payment()
        {
        }
    }
}

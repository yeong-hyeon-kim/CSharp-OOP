namespace ClassLibrary.Encapsulation
{
    /// <summary>
    /// 값이 캡슐화 은닉프로퍼티 접근 수준에 따라 원치 않는 값 유출이나 수정을 방지할 수 있다.  
    /// </summary>
    class GetSet
    {
        /// <summary>
        /// 외부에서 수정만 할 수 있고 가져오지 못하도록 set 설정.
        /// </summary>
        public int RoutineCount { get; set; } = 10;

        /// <summary>
        /// 외부에서 가져올 수만 있고 수정하지 못하도록 get 설정.
        /// </summary>
        public string EnvironmentVariable { get; } = "Path";

        /// <summary>
        /// 외부에서 수정 모두 가능하도록 get, set 설정.
        /// </summary>
        public string Writer { get; set; } = "Writer";
    }
}

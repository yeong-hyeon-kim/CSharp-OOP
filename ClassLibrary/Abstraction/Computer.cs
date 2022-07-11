using System;

namespace ClassLibrary.Abstraction
{
    /// <summary>
    /// 추상화,
    /// 노트북, 스마트폰 모두 컴퓨터(Computer)라고 일반화(Generalization) 할 수 있는게 추상화이다.
    /// 클래스간의 공통점을 찾아내서 공통의 조상을 만드는 작업
    /// </summary>
    public abstract class Computer
    {
        /// <summary>
        /// 모델명
        /// </summary>
        public string ModelName { get; set; }

        /// <summary>
        /// 제조사
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// 운영체제
        /// </summary>
        public string OS { get; set; }

        /// <summary>
        /// 중앙처리장치
        /// </summary>
        public string CPU { get; set; }

        /// <summary>
        /// 그래픽처리장치
        /// </summary>
        public string GPU { get; set; }

        /// <summary>
        /// 메모리
        /// </summary>
        public string Memory { get; set; }

        /// <summary>
        /// 저장장치
        /// </summary>
        public string Storage { get; set; }

        public void Calculation()
        {
            Console.WriteLine("Calculation!");
        }
    }
}

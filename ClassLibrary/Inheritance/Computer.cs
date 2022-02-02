using System;

namespace ClassLibrary.Inheritance
{
    public class Computer
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

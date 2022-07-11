using ClassLibrary.Abstraction;
using ClassLibrary.Encapsulation;
using System;

namespace ClassLibrary.Inheritance
{
    /// <summary>
    /// 구체화 : 상속을 통해 클래스를 구현, 확장하는 작업. 
    /// Computer를 NoteBook으로 구체화.
    /// </summary>
    public class NoteBook : Computer, IPower
    {
        public string Type { get; set; } = "노트북";
        public string Battery { get; set; }

        public NoteBook()
        {

        }

        //생성자 : 객체 변수를 생성하는 메서드 
        public NoteBook(string _ModelName, string _Manufacturer, string _OS, string _CPU, string _GPU, string _Memory, string _Storage)
        {
            ModelName = _ModelName;
            Manufacturer = _Manufacturer;
            OS = _OS;
            CPU = _CPU;
            GPU = _GPU;
            Memory = _Memory;
            Storage = _Storage;
        }

        public void PrintInfomation()
        {
            Console.WriteLine($"{Type} 이름 : {ModelName}, 제조사 : {Manufacturer}, 운영체제 : {OS}, 중앙처리장치 : {CPU}, GPU : {GPU}, 메모리 : {Memory} , 저장장치 : {Storage}");
        }

        /// <summary>
        /// 자세하거나 구체적인 동작은 각각 재정의한다.
        /// </summary>
        public void TurnOn()
        {
            Console.WriteLine("부팅하려면 노트북의 전원 버튼을 6초 이상 누르세요");
        }

        public void TurnOff()
        {
            Console.WriteLine("종료하려면 노트북의 전원 버튼을 6초 이상 누르세요");
        }
    }
}

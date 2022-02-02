using System;

namespace ClassLibrary.Inheritance
{
    public class NoteBook : Computer
    {
        public string Type { get; set; } = "노트북";
        public string Battery { get; set; }

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
    }
}

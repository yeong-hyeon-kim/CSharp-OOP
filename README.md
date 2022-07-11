## 📕 프로젝트 개요(Introduce Project)

### OPP(Object Oriented Programming)

* 객체지향의 특성인 추상화, 다형성, 상속, 은닉성의 개념과 사용 이유를 알아봅니다.

## 🏷️ 목차(Index)

1. [캡슐화 (Encapsulation)](#캡슐화-(Encapsulation))
2. [추상화 (Abstraction)](#추상화-(Abstraction))
3. [상속성 (Inheritance)](#상속성-(Inheritance))
4. [다형성 (Polymorphism)](#다형성-(Polymorphism))

### 캡슐화 (Encapsulation)
* [인터페이스(Interface)](./ClassLibrary/Encapsulation/IPower.cs)
  * 은닉화(Hiding) : 공통된 특징(행위)만 선언하고 구체적인 내용은 각 클래스에서 구체화하도록 유도.
  * 느슨한 결합(Loose Coupling) : 하위 타입인 각 클래스들은 상위 타입인 인터페이스 타입에 포함되어 인터페이스를 상속하는 클래스라면 타입에 관계없이 매개변수로 받을 수 있다.
  > 매개변수 타입이 특정 클래스 타입이 아니므로 의존성이 줄어든다.
* 속성(Property)
    * `get`, `set`을 이용하여 외부에서 데이터 접근 수준을 지정할 수 있다.
    * 값을 캡슐화(은닉) 할 수 있다.
### 추상화 (Abstraction)

* [추상 클래스, 메서드](./ClassLibrary/Abstract/Computer.cs)
  * 노트북, 스마트폰 모두 컴퓨터(Computer)라고 일반화(Generalization) 할 수 있는게 추상화이다.
  * 클래스간의 공통점을 찾아내서 공통의 조상을 만드는 작업이다.
  > 노트북, 스마트폰의 공통 조상은 컴퓨터다.

### 상속성 (Inheritance)

* [하위 클래스](./ClassLibrary/Inheritance/NoteBook.cs)
  * 상위 클래스(공통 조상)를 상속받아 하위 클래스(자신)을 구현(구체화, 재정의), 확장하는 작업이다.
  > 컴퓨터를 노트북 또는 스마트폰으로 구체화할 수 있다.

### 다형성 (Polymorphism)
* [갤럭시](./ClassLibrary/Polymorphism/Galaxy.cs)
* 상위 클래스 메서드를 `다`양한 `형`태로 이용할 수 있는 `성`질.
* 스마트폰을 갤럭시나 아이폰으로 다양한 형태로 만들 수 있다.

## 💻 개발 환경(Develop Environment)

### 세부 환경(Environment Detail)

* ✔ OS : ![Windows](https://img.shields.io/badge/Windows-0078D6?style=flat-square&logo=Windows&logoColor=white)
  * 🕒 Version : `11 Pro`
* ✔ Language : ![C#](https://img.shields.io/badge/CSharp-239120?style=flat-square&logo=C-Sharp&logoColor=white)
* ✔ Dependency : ![.NET](https://img.shields.io/badge/.NET-512BD4?style=flat-square&logo=.NET&logoColor=white)
  * 🕒 Version : `6.0`

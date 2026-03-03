using System;
using System.Runtime.InteropServices.Marshalling;
///1-1 기본 상속 문법
/*Child child = new Child();
child.Greet();
child.Study();
class Parent
{
    public void Greet()
    {
        Console.WriteLine("안녕하세요!");
    }
}
class Child : Parent
{
    public void Study()
    {
        Console.WriteLine("공부합니다.");
    }
}*/
///1-2 . 동물 클래스 상속
/*Dog dog = new Dog();
Cat cat = new Cat();
dog.Name = "초코";
cat.Name = "나비";
dog.Eat();
dog.Bark();
cat.Eat();
cat.Moew();
class Animal
{
    public string Name;

    public void Eat()
    {
        Console.WriteLine($"{Name}이(가) 먹이를 먹습니다.");
    }
}
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine($"{Name}이(가) 멍멍 짖습니다.");
    }
}
class Cat : Animal
{
    public void Moew()
    {
        Console.WriteLine($"{Name}이(가) 야옹 웁니다.");
    }
}*/
///2. Object 클래스
/*Product product = new Product { Name = "키보드", Price = 50000 };
Console.WriteLine(product.ToString());
Console.WriteLine(product.GetType());
class Product
{
    public string Name;
    public int Price;
 
}*/
///3. 접근 제한자와 상속
/*Child child = new Child();
child.ShowValues();
Console.WriteLine(child.Pubvalue);
class Parent
{
    private int Privalue = 1;
    protected int Provalue = 2;
    public int Pubvalue = 3;
}
class Child : Parent
{
    public void ShowValues()
    {
        Console.WriteLine(Provalue);
        Console.WriteLine(Pubvalue);
    }
}*/
///4. base 키워드
/*Manager manager = new Manager();
manager.ShowInfo();
class Employee
{
    protected string _department = "개발팀";
    public void ShowDepartment()
    {
        Console.WriteLine($"부서 : {_department}");
    }
}
class Manager : Employee
{
    public void ShowInfo()
    {
        Console.WriteLine($"소속 부서: {_department}");
        base.ShowDepartment();
    }
}*/
/// 5-1 부모 생성자 호출(base)
/*Student student = new Student("홍길동", 3);
Console.WriteLine($"이름: {student.Name}, 학년: {student.Grade}");

class Person
{
    public string Name;
    public Person(string name)
    {
        Name = name;
        Console.WriteLine($"Person 생성자 호출: {Name}");
    }
}
class Student : Person
{
    public int Grade;
    
    public Student(string name,int grade) : base(name)
    {
        Grade = grade;
        Console.WriteLine($"Student 생성자 호출: {Grade}학년");
    }
}*/
///5-2 암시적 기본 생성자 호출
/*Dog dog = new Dog();
class Animal
{
    public Animal()
    {
        Console.WriteLine("Animal 기본 생성자");
    }
}
class Dog : Animal
{
    public Dog()
    {
        Console.WriteLine("Dog 생성자");
    }
}*/
///6-1. 업캐스팅
/*Dog dog = new Dog {  Name = "멍멍이" };
//업캐스팅*/
/*Animal animal = dog;
*//*animal.Eat();
*/
///다운 캐스팅
/*Animal animal1 = new Cat { Name = "야옹이" };
Dog dog1 = (Dog)animal1;*/
///is 연산자로 타입검사
/*Animal animal = new Dog { Name = "멍멍이" };
if (animal is Dog)
{
    Dog dog = (Dog)animal;
    dog.Bark();
}*/
//is 패턴 매칭
/*Animal animal = new Dog { Name = "멍멍이" };
if (animal is Dog dog1)
{
    dog1.Bark();
}
*/
//as 연산자로 안전한 캐스팅
/*Animal animal = new Cat { Name = "야옹이" };
Dog dog = animal as Dog; 
if (dog != null)
{
    dog.Bark();
}
else
{
    Console.WriteLine("Dog 타입이 아닙니다.");
}*/
/*class Animal
{
    public string Name;
    public void Eat()
    {
        Console.WriteLine($"{Name}이(가) 먹습니다.");
    }
}
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine($"{Name}이(가) 짖습니다.");
    }
}
class Cat : Animal
{
    public void Moew()
    {
        Console.WriteLine($"{Name}이(가) 야옹 웁니다.");
    }
}*/
///7. 다형성
/*Asset[] assets = new Asset[3];
assets[0] = new Stock { Name = "삼성전자", Shares = 100 };
assets[1] = new House { Name = "아파트", Mortgage = 50000000000 };
assets[2] = new Stock { Name = "Sk하이닉스", Shares = 50 };
foreach(var asset in assets)
{
    Console.WriteLine(asset.Name);
}
class Asset
{
    public string Name;
}
class Stock : Asset
{
    public int Shares;
}
class House : Asset
{
    public decimal Mortgage;
}*/
///8-1 추상 클래스 기본
/*Rectangle rect = new Rectangle { Name="사각형",Width = 10, Height = 5};
Circle cir = new Circle { Name = "원", Radius = 3 };
Console.WriteLine($"{rect.Name} 넓이: {rect.GetArea()}");
Console.WriteLine($"{cir.Name} 넓이: {cir.GetArea():F2}");
abstract class Shape 
{
    public string Name;

    public abstract double GetArea();
}
class Rectangle : Shape
{
    public double Width;
    public double Height;

    public override double GetArea()
    {
        return Width * Height;
    }
}
class Circle : Shape
{
    public double Radius;

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}*/
///8-2 추상 메서드
/*Car car = new Car();
car.Start();
car.Stop();
abstract class Vehicle
{
    public abstract void Start();
    public void Stop()
    {
        Console.WriteLine("정지합니다.");
    }
}
class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("자동차 시동을 켭니다.");
    }
}*/
///9. 봉인 클래스
/*FinalClass fc = new FinalClass();
fc.Display();
sealed class FinalClass
{
    public void Display()
    {
        Console.WriteLine("이 클래스는 상속할 수 없습니다.");
    }
}*/
///10. 멤버 숨기기(new 키워드)
/*Child cil = new Child();
Parent parent = cil;
Console.WriteLine($"Child.Value: {cil.Value}");
Console.WriteLine($"parent.Value: {parent.Value}");
cil.Show(); 
parent.Show();
class Parent
{
    public int Value = 10;
    public void Show()
    {
        Console.WriteLine("Parent.Show()");
    }
}
class Child : Parent
{
    public new int Value = 20;

    public new void Show() => Console.WriteLine("Child.Show()");
}*/
///11. is-a 관계
/*Dog dog = new Dog();
Console.WriteLine(dog is Animal);
Console.WriteLine(dog is Dog);
Console.WriteLine(dog is Cat);
class Animal { }
class Dog : Animal { }
class Cat : Animal { }*/
///12.종합 예제: 게임 캐릭터 시스템
GameCharacter[] characters = new GameCharacter[]
{
    new Warrior("아서",25),
    new Mage("멀린",40),
    new Warrior("란슬롯",30)
};
foreach (GameCharacter character in characters)
{
    character.Showstatus();
    character.Attack();
    Console.WriteLine();
}
abstract class GameCharacter
{
    public string Name { get; protected set;  }

    public int Health { get; protected set; }
    protected GameCharacter(string name, int health)
    {
        Name = name; 
        Health = health; 
    }
    public abstract void Attack();

    public void Showstatus()
    {
        Console.WriteLine($"{Name} 체력: {Health}");
    }
}
class Warrior : GameCharacter
{
    public int Strength { get; private set; }
    public Warrior(string name, int strength) : base(name,150)
    {
        Strength = strength;
    }
    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 검으로 {Strength} 데미지를 입힙니다!");
    }
}
class Mage : GameCharacter
{
    public int Magic { get; private set; }
    public Mage(string name,int magic):base(name,80)
    {
        Magic = magic; 
    }
    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 마법으로 {Magic} 데미지를 입힙니다!");
    }
}
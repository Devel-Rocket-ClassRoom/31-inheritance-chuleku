using System;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("=== 직원 급여 시스템 ===");
Console.WriteLine();
Manager manager = new Manager("김부장",5000000,1000000);
manager.PrintInfo();
Console.WriteLine();
Developer developer = new Developer("이개발", 4000000, 10);
developer.PrintInfo();
Console.WriteLine();
Intern intern = new Intern("박인턴");
intern.PrintInfo();

abstract class Employee
{
    public string _name { get; protected set; }
    public int _baseSalary { get; protected set; }

    public Employee(string name, int baseSalary)
    {
        _name = name;
        _baseSalary = baseSalary;
    }
    public  string GetName()
    {
        return _name;
    }

    public  int GetBaseSalary()
    {
        return _baseSalary; 
    }
    public abstract int Calculaterpay();
    public abstract void PrintInfo();
}

class Manager : Employee
{
    private int _bonus;
    
    public Manager(string name,int basesalary,int bonus):base(name,basesalary)
    {
        _name=name;
        _baseSalary = basesalary;
        _bonus = bonus;
    }
    public override int Calculaterpay()
    {
        return _baseSalary + _bonus;
    }
    public override void PrintInfo()
    {
        Console.WriteLine($"[매니저] {_name}");
        Console.WriteLine($"기본급: {_baseSalary}원");
        Console.WriteLine($"보너스: {_bonus}원");
        Console.WriteLine($"총 급여: {_baseSalary+_bonus}원");
    }
}
class Developer : Employee
{
    private int _overtimeHours;

    public Developer(string name, int basesalary, int overtimeHours) : base(name, basesalary)
    {
        _name = name;
        _baseSalary = basesalary;
        _overtimeHours = overtimeHours;
    }
    public override int Calculaterpay()
    {
        return _baseSalary + (_overtimeHours * 20000);
    }
    public override void PrintInfo()
    {
        Console.WriteLine($"[개발자] {_name}");
        Console.WriteLine($"기본급: {_baseSalary}원");
        Console.WriteLine($"초과근무: {_overtimeHours}시간");
        Console.WriteLine($"총 급여: {_baseSalary +(_overtimeHours*20000)}원");
    }
}
class Intern : Employee
{
    public Intern(string name, int basesalary = 1500000) : base(name, basesalary)
    {
        _name = name;
        _baseSalary = basesalary;
    }
    public override int Calculaterpay()
    {
        return _baseSalary;
    }
    public override void PrintInfo()
    {
        Console.WriteLine($"[인턴] {_name}");
        Console.WriteLine($"기본급: {_baseSalary}원");
        Console.WriteLine($"총 급여: {_baseSalary}원");
    }
}
using System;
Lion siba = new Lion { Name = "시바", Age = 5 };
Elephant dumbo = new Elephant { Name = "덤보", Age = 10};
Penguin ppololo = new Penguin { Name = "뽀로로", Age = 3};
Console.WriteLine("[동물 정보]");
siba.DisplayInfo();
dumbo.DisplayInfo();
ppololo.DisplayInfo();
Console.WriteLine();
Console.WriteLine("[동물 소리]");
siba.MakeSound("으르렁");
dumbo.MakeSound("뿌우");
ppololo.MakeSound("꽥꽥");
Console.WriteLine();
Console.WriteLine("[동물 행동]");
siba.Eat();
siba.Hunt();
dumbo.Eat();
dumbo.SprayWater();
ppololo.Eat();
ppololo.Swim();
class Animal
{
    public string Name;
    public int Age;
    public string _sound { get;protected set; } 

    public void Eat()
    {
        Console.WriteLine($"{Name}이(가) 먹이를 먹습니다.");
    }
    public void MakeSound(string sound)
    {
        _sound = sound;
        Console.WriteLine($"{Name}: {_sound}!");
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"이름:{Name}, 나이: {Age}살");
    }
}

class Lion : Animal
{
    public void Hunt()
    {
        Console.WriteLine($"{Name}이(가) 사냥을 합니다.");
    }
}
class Elephant : Animal
{
    public void SprayWater()
    {
        Console.WriteLine($"{Name}이(가) 물을 뿌립니다.");
    }
}
class Penguin : Animal
{
    public void Swim()
    {
        Console.WriteLine($"{Name}이(가) 수영을 합니다.");
    }
}
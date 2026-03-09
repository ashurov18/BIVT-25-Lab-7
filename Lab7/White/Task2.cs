using System;

public struct Participant
{
    private string name;
    private string surname;
    private double firstJump;
    private double secondJump;

    public string Name => name;
    public string Surname => surname;
    public double FirstJump => firstJump;
    public double SecondJump => secondJump;

    public double BestJump => Math.Max(firstJump, secondJump);

    public Participant(string name, string surname)
    {
        this.name = name;
        this.surname = surname;
        firstJump = 0;
        secondJump = 0;
    }

    public void Jump(double result)
    {
        if (firstJump == 0)
            firstJump = result;
        else if (secondJump == 0)
            secondJump = result;
    }

    public static void Sort(Participant[] array)
    {
        Array.Sort(array, (a, b) => b.BestJump.CompareTo(a.BestJump));
    }

    public void Print()
    {
        Console.WriteLine($"{name} {surname} | {firstJump} | {secondJump} | Best: {BestJump}");
    }
}

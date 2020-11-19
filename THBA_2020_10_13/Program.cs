using System;

Opg_1();
Opg_2();
Opg_3();

void Opg_1()
{
    Console.WriteLine("\nOpgave 1");
    Console.WriteLine("--------");
    Console.Write("Hvad hedder du          ? ");
    string navn = Console.ReadLine();
    do
    {
        Console.Write("Giv mig et heltal       : ");
        int heltal1 = int.Parse(Console.ReadLine());
        Console.Write("Giv mig endnu et heltal : ");
        int heltal2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"  Hej {navn}");
        Console.WriteLine($"  {heltal1} x {heltal2} = {MyMath.Produkt(heltal1, heltal2)}");
        Console.Write("Vil du lave en ny udregning (Ja/Nej)? ");
    } while (Console.ReadLine().Trim().ToUpper().StartsWith("J"));
}

void Opg_2()
{
    Console.WriteLine("\nOpgave 2");
    Console.WriteLine("--------");

    Console.WriteLine("Skriver tallene [0,99]");
    for (int i = 0; i <= 99; i++) Console.Write($"{i,3}");
    Console.WriteLine();

    Console.WriteLine("\nSkriver tallene [1,9[");
    for (int i = 1; i < 9; i++) Console.Write($"{i,3}");
    Console.WriteLine();

    Console.WriteLine("\nSkriver 7-tabellen");
    for (int i = 0; i < 16; i++) Console.WriteLine($"{i,3} x 7 = {MyMath.Produkt(i, 7),3}");

    Console.WriteLine("\nSkriver 5x10 tabel");
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 10; j++) Console.Write($"{MyMath.Produkt(i, j),3}");
        Console.WriteLine();
    }
}

void Opg_3()
{
    Console.WriteLine("\nOpgave 3");
    Console.WriteLine("--------");

    int[] mitArray = { 4, 8, 10, 9, 3, 5, 1, 6, 7, 2 };

    Console.WriteLine("Tabellen indeholder");
    for (int i = 0; i < mitArray.Length; i++) Console.Write($"{mitArray[i],3}");
    Console.WriteLine();

    Console.WriteLine("Index 3 og 7 byttes");
    int temp = mitArray[7];
    mitArray[7] = mitArray[3];
    mitArray[3] = temp;
    for (int i = 0; i < mitArray.Length; i++) Console.Write($"{mitArray[i],3}");
    Console.WriteLine();

    int sum = 0;
    for (int i = 0; i < mitArray.Length; i++) sum += mitArray[i];
    Console.WriteLine($"Summen af tallene er\n{sum,3}");
    Console.WriteLine();
}

class MyMath
{
    public static int Produkt(int a, int b)
    {
        return a * b;
    }
}

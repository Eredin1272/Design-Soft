using System;
using System.Threading;

Console.WriteLine("Hello, Jerry");

printAbc();
Thread.Sleep(500);

printAbc();
Thread.Sleep(500);

printAbc();
Thread.Sleep(500);

Console.WriteLine("-------------------------");
A();
A();

Console.ReadLine();


void printAbc()
{
    Console.WriteLine("A");
    Console.WriteLine("B");
    Console.WriteLine("C");
}

void A()
{
    Console.WriteLine("A");
    B();
    C();
}

void B()
{
    Console.WriteLine("B");
}

void C()
{
    Console.WriteLine("C");
}
// cs_keyword_is.cs
// The is operator.
using System;

class A {}
class В : A {}
    class Usels
{
    public static void Main() 
{
    A a = new A () ;
    В b = new В();
    if(a is A) 
        Console.WriteLine("Объект а имеет тип A.");

if(b is A)

Console.WriteLine("Объект b совместим с типом А, " +
"поскольку его тип выведен из типа А.");

if (a is В)

    Console.WriteLine("Этот текст не будет отображен, " +
    "поскольку объект а не выведен из класса В.");

if(b is В) 
    Console.WriteLine("Объект b имеет тип В.");
if(a is object) 
    Console.WriteLine("а — это объект.");
}
}
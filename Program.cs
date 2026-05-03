using System;
using System.Diagnostics.Contracts;
Console.WriteLine("Declare the first 2 registers,1- eax,2- ebx");
int eax = int.Parse(Console.ReadLine());
int ebx = int.Parse(Console.ReadLine());
int result;
Console.WriteLine("You can choice operator!\n 1 - +,2 - -, 3 - *, 4 - /.\n ");
int oper = int.Parse(Console.ReadLine());
int reslt = 0;
switch (oper)
{
    case 1:
    Console.WriteLine("You choice +");
    int sum;
    sum = eax + ebx;
    reslt = sum;
    break;
    case 2:     
    Console.WriteLine("You choice -");
    int sub;
    reslt = eax - ebx;
    break;
    case 3:
    int mult;
    reslt = eax * ebx;
    break;
    case 4:
    reslt = eax / ebx;
    break;
}
Console.WriteLine("Result:"+ reslt);
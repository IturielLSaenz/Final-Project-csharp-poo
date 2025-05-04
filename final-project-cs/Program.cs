// See https://aka.ms/new-console-template for more information
using System;
Console.WriteLine("What's your name?");
string name = Console.ReadLine();
Console.WriteLine("Input your phone: ");
string phone = Console.ReadLine();
Console.WriteLine("Input your email: ");
string email = Console.ReadLine();
Person owner = new Person(name,phone,email);
Console.WriteLine(owner.toString());

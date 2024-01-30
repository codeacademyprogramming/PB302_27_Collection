
using Lesson2;
using Lesson2.Generic;
using System.Collections;

MyList<string> names = new MyList<string>();
names.Add("Hikmet");
names.Add("Nermin");
names.Add("Abbas");
names.Add("Tofiq");

string[] namesArr = { "Hikmet", "Nermin", "Abbas", "Tofiq" };

foreach (string name in names)
{
	Console.WriteLine(name);
}

ArrayList arrList0 = new ArrayList();
arrList0.Add(13);
arrList0.Add(14);
arrList0.Add("Salam");


ArrayList arrList1 = new ArrayList();
arrList1.Add("Salam");
arrList1.Add(45);
arrList1.Add(names);

arrList1.RemoveAt(2);
arrList1.AddRange(namesArr);
arrList1.AddRange(arrList0);
arrList1.RemoveRange(0, 2);
arrList1.Remove("Hikmet");
Console.WriteLine(arrList1.Contains("Hikmet"));
Console.WriteLine(arrList1.IndexOf("Hikmet"));
Console.WriteLine(arrList1.Capacity);
Console.WriteLine(arrList1.Count);
Console.WriteLine(arrList1[0]);

foreach (var item in arrList1)
{
    Console.WriteLine(item);
}


SortedList nonGenSortedList = new SortedList();

nonGenSortedList.Add("P101", 16);
nonGenSortedList.Add("P100", 17);
nonGenSortedList.Add("P103", 26);
nonGenSortedList.Add("A105", 17);
nonGenSortedList.Add("A106", "necesen");


Console.WriteLine("sorted list");
Console.WriteLine(nonGenSortedList["A106"]);

Queue nonGenqueue = new Queue();
nonGenqueue.Enqueue(10);
nonGenqueue.Enqueue("Salam");
nonGenqueue.Enqueue('A');

Console.WriteLine("Non Gen Queue items:");

var item1 = nonGenqueue.Dequeue();
Console.WriteLine(nonGenqueue.Peek());

Console.WriteLine("Non Gen Queue items: ");
foreach (var item in nonGenqueue)
{
    Console.WriteLine(item);
}

Stack nonGenStack = new Stack();
nonGenStack.Push(10);
nonGenStack.Push("Salam");
nonGenStack.Push('A');


Console.WriteLine(nonGenStack.Peek());
Console.WriteLine(nonGenStack.Pop());
Console.WriteLine(nonGenStack.Peek());
Console.WriteLine("Non Gen Stack items: ");
foreach (var item in nonGenStack)
{
    Console.WriteLine(item);
}

Hashtable table = new Hashtable();

table.Add("A", 11);
table.Add("b", 110);
table.Add(14, "salam");

Console.WriteLine(table["b"]);


Human hmn1 = new Human();


ArrayList numArrList = new ArrayList();
numArrList.Add(10);
numArrList.Add(20);
numArrList.Add(35);
numArrList.Add(110);

MyList<int> myNumList = new MyList<int>();
myNumList.Add(-20);
myNumList.Add(-30);


List<int> numList = new List<int>();

numList.Add(10);
numList.Add(20);
numList.Add(30);
numList.Add(40);
numList.Add(40);
numList.Add(40);
numList.Add(40);
numList.Add(50);

numList.AddRange(myNumList);

numList.Sort();
numList.Reverse();
var newNumList = numList.Distinct();

Console.WriteLine(numList[0]);

foreach (var item in newNumList)
{
    Console.WriteLine(item);
}

Dictionary<string, string> phoneBook = new Dictionary<string, string>();

phoneBook.Add("a@code.edu.az", "+994555555");
phoneBook.Add("b@code.edu.az", "+994555556");
phoneBook.Add("c@code.edu.az", "+994555557");


string email = Console.ReadLine();

string phone;
if(phoneBook.TryGetValue(email,out phone))
{
    Console.WriteLine(phone);
}
else
{
    Console.WriteLine("Bele bir email yoxdur");
}

var keys = phoneBook.Keys;
var values = phoneBook.Values;

foreach (var item in phoneBook)
{
    Console.WriteLine(item.Key+" - "+item.Value);
}
































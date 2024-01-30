using Lesson1;

string[] names = new string[5];

StringList nameList= new StringList();

nameList.Add("Hikmet");
nameList.Add("Nermin");
nameList.Add("Abbas");
nameList.Add("Tofiq");


for (int i = 0; i < nameList.Length; i++)
{
    Console.WriteLine(nameList[i]);
}

IntList numList = new IntList();
numList.Add(10);
numList.Add(20);
numList.Add(30);
numList.Add(40);
numList.Add(50);


for (int i = 0; i < numList.Length; i++)
{
    Console.WriteLine(numList[i]);
}

IInfo infoObj1 = new Car { Brand = "Mercedes", Model = "E200" };
IInfo infoObj2 = new Human { Name="Hikmet" };


Human hmn1 = new Human { Name = "Tofiq" };

MyList<Car> myCarList = new MyList<Car>();

MyList<int> myNumList = new MyList<int>();
myNumList.Add(10);
myNumList.Add(20);
myNumList.Add(30);
myNumList.Add(40);

for (int i = 0; i < myNumList.Length; i++)
{
    Console.WriteLine(myNumList[i]);
}

MyList<string> myNameList = new MyList<string>();
MyList<DateTime> myDateList = new MyList<DateTime>();
MyList<Human> myHumanList = new MyList<Human>();


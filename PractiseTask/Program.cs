using PractiseTask;

string[] names =new string[4];
StringList nameList= new StringList();

nameList.Add("Fidan");
nameList.Add("Fidan2");
nameList.Add("Fidan3");
nameList.Add("Fidan4");
Console.WriteLine(nameList[0]) ;

for (int i = 0; i < nameList.Length; i++)
{
    Console.WriteLine(nameList[i]);
}

IntList numList = new IntList();
numList.Add(1);
numList.Add(2);
numList.Add(3);
numList.Add(4);
numList.Add(5);


for (int i = 0; i < numList.Length; i++)
{
    Console.WriteLine(numList[i]);
}

//MyList<int> myNumList = new MyList<int>();
//myNumList.Add(1);
//myNumList.Add(2);
//myNumList.Add(3);
//myNumList.Add(4);
//for (int i = 0; i < myNumList.Length; i++)
//{
//    Console.WriteLine(myNumList[i]);
//}

//MyList<string> myNameList = new MyList<string>();
//MyList<DateTime> myDateList = new MyList<DateTime>();
MyList<Human> myHumanList = new MyList<Human>();
MyList<Car> myCarList= new MyList<Car>();



IInfo infoObj1 = new Car { Brand = "Bmw", Model = "M4" };
IInfo infoObj2 = new Human { Name="Fidan"};




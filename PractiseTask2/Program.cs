using PractiseTask2;
using System.Collections;

MyList<string> products = new MyList<string>();
products.Add("milk");
products.Add("bread");
products.Add("meat");
products.Add("water");

string[] productsArr = { "milk", "bread", "meat", "water" };

var enumarableProducts = GetProducts(products);

//foreach (string product in products.GetProducts())
//{
//    Console.WriteLine(product);
//}
foreach(string product in products)
{
    Console.WriteLine(product);
}

IEnumerable<string> GetProducts(MyList<string> productList)
{
	for (int i = 0; i < productList.Length; i++)
	{
		yield return productsArr[i];
	}
}
//////////////////////////////////////////////////////////



ArrayList numArrList= new ArrayList();
numArrList.Add(products);
numArrList.Add("Fidan");
numArrList.Add(19);
numArrList.RemoveAt(0);
numArrList.AddRange(productsArr);
numArrList.Clear();
//numArrList.RemoveRange(0, 1);
Console.WriteLine(numArrList.Contains(19));
Console.WriteLine(numArrList.IndexOf("Fidan"));
Console.WriteLine(numArrList.Count);
foreach (var i in numArrList)
{
    Console.WriteLine(i);
}


SortedList sortedList = new SortedList();
sortedList.Add("A", 1);
sortedList.Add("F", 7);
sortedList.Add("C", 3);
sortedList.Add("B", 2);
Console.WriteLine(sortedList["A"]);

 Queue queue = new Queue();
queue.Enqueue("C");
queue.Enqueue("F");
queue.Enqueue(15);
Console.WriteLine(queue.Dequeue());  /*Fifo*/
Console.WriteLine(queue.Peek());
foreach (var i in queue)
{
    Console.WriteLine(i);
}

///////////////////////////////////
Stack stack = new Stack(); /*lifo*/
stack.Push("C");
stack.Push("F");
stack.Push(15);
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Peek());
foreach (var i in stack)
{
    Console.WriteLine(i);
}

//////////////////////////////////

Hashtable ht=new Hashtable();
ht.Add("A", 1);
ht.Add("F", 7);
ht.Add(45, "hello");
//Console.WriteLine(ht.Count);
Console.WriteLine(ht["A"]);
MyList<int> numList = new MyList<int>();
numList.Add(40);
numList.Add(-30);

List<int> list = new List<int>();
list.Add(1);
list.Add(2);
list.Add(2);
list.Add(2);
list.Add(3);

Console.WriteLine(list.Contains(3));
list.AddRange(numList);
list.Sort();
 var newList=list.Distinct();
foreach (var i in list)
{
    Console.WriteLine(i);
}
foreach (var i in newList)
{
    Console.WriteLine(i);
}

Dictionary<string,string> keyValuePairs = new Dictionary<string,string>();
keyValuePairs.Add("salam", "malas");
keyValuePairs.Add("abc", "cba");
Console.WriteLine(keyValuePairs.Count);
Console.WriteLine(keyValuePairs["abc"]);
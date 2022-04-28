// See https://aka.ms/new-console-template for more information
using System.Collections.Specialized;

string name = "deepak";
Console.WriteLine("Hello, World! God is great");
Console.WriteLine($"My name is {name}"); // $ to pass parameters to string

string[] namestrList = { "deepak","arpit","pratik"};

// List example

List<string> list = new List<string>(5);

list.AddRange(namestrList);

void PrintList(List<string> list) 
{
    foreach(var item in list) 
    {
        Console.WriteLine($"Name is : {item}");
    }
}

PrintList(list);

// Linked list example
string[] songs = {
                    "laal bindi","kalavathi","natu natu"
                 };
LinkedList<string> myList = new LinkedList<string>(songs);
foreach(string s in myList) 
{
    Console.WriteLine(s);
}

LinkedListNode<string> first = myList.First; // linked list nodes
LinkedListNode<string> last = myList.Last;

Console.WriteLine("First value in the list: "+ first.Value);
Console.WriteLine("Last value in the list: "+ last.Value);

// Stack
Stack<string> myStack = new Stack<string>();
myStack.Push("one");
myStack.Push("two");
myStack.Push("three");
myStack.Push("four");
myStack.Push("five");

Console.WriteLine("Elements in Stack - LIFO");
foreach(string s in myStack)
{
    Console.WriteLine(s);
}

// Queue
// Stack
Queue<string> myQueue = new Queue<string>();
myQueue.Enqueue("one");
myQueue.Enqueue("two");
myQueue.Enqueue("three");
myQueue.Enqueue("four");
myQueue.Enqueue("five");

Console.WriteLine("Elements in Queue - FIFO");

foreach (string s in myQueue)
{
    Console.WriteLine(s);
}


// Dictionary
Dictionary<string, string> myDictionary = new Dictionary<string, string>();
myDictionary.Add("bmp", "bitmap image");
myDictionary.Add("jpg", "jpeg image");
myDictionary.TryAdd("pdf", "pdf file");

Console.WriteLine(myDictionary["pdf"]);

// shopping list challange
List<ShoppingList> shopList = new List<ShoppingList>();
shopList.Add(new ShoppingList() { item = "apple", price = 160, quantity = 12 });
shopList.Add(new ShoppingList() { item = "mango", price = 120, quantity = 10 });

Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(shopList));

public class ShoppingList
{
    public string item { get; set; }
    public double price { get; set; }
    public int quantity { get; set; }
}

//Namespace: System.Collections.Specialized
//HybridDictionary
//OrderedDictionary
//StringCollection
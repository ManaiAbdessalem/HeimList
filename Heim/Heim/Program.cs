namespace Heim;

internal class Program
{
    public static MyList<int> My_list { get; set; } = new();

    private static void Main(string[] args)
    {
        //Adding value Test
        InitializeTest("Adding value");
        Console.WriteLine($"Value to Add: 19 ");
        My_list.Add(19);
        DisplayListAfterAction("List data after adding 19: ");

        //Clearing value Test
        InitializeTest("Clearing list");
        Console.WriteLine($"Actual list length: {My_list.Count()}");
        My_list.Clear();
        Console.WriteLine($"Clearing list..., new list length: {My_list.Count()}");

        //Inserting value Test
        InitializeTest("Inserting list");
        Console.WriteLine($"Want to insert 99 between 3 and 4");
        My_list.Insert(2, 99);
        DisplayListAfterAction("list datas after inserting : ");

        //Removing value Test
        InitializeTest("Removeing from list");
        Console.WriteLine("Want to Remove '5' value ");
        My_list.Remove(5);
        DisplayListAfterAction($"list datas after removing '4' : ");
        Console.WriteLine("Want to Remove an non existing value '365'");
        My_list.Remove(365);
        DisplayListAfterAction($"list datas after removing non existing'365' : ");

        //RemoveingAt value Test
        InitializeTest("RemoveingAt from list");
        Console.WriteLine("Want to Remove at index '1'");
        My_list.RemoveAt(1);
        DisplayListAfterAction($"list datas after removingAt index '1' : ");
        Console.WriteLine("Want to Remove at non existing index '111'");
        My_list.RemoveAt(111);

        //IndexOf Test
        InitializeTest("IndexOf");
        Console.WriteLine("Want to get indexOf '5' and non existing '8' ");
        Console.WriteLine($"Index of value '5': {My_list.IndexOf(5)}");
        Console.WriteLine($"Index of value '8': {My_list.IndexOf(8)}");

        //Contains Test
        InitializeTest("Contains");
        Console.WriteLine("Want to check if the list contains '3' value and non existing'10' value ");
        Console.WriteLine($"Contains value '3': {My_list.Contains(3)}");
        Console.WriteLine($"Contains value '10': {My_list.Contains(13)}");

        //GetEnumerator Test
        InitializeTest("GetEnumerator");
        Console.WriteLine($"In my code i added four values. The 'GetEnumerator' is called for example from this method Console.WriteLine(string.Join(\"\\t\", Mylist));");
        DisplayListAfterAction($"List datas after calling GetEnumerator : ");

        //Count Test
        InitializeTest("Count");
        Console.WriteLine($"Calling Count : {My_list.Count} ");

        // this[int index] Get Test
        InitializeTest("this[int index] Get ");
        Console.WriteLine($"Want to get the value of index 2 : Mylist[2] : {My_list[2]} ");
        Console.WriteLine($"Want to get the value of non existing index 1000 : Mylist[1000]");
        int value = My_list[1000];

        // this[int index] Set Test
        InitializeTest("this[int index] Set");
        Console.WriteLine($"Want to Set the value of index 2 to 555: Mylist[2]");
        My_list[2] = 555;
        DisplayListAfterAction($"New list datas : ");
        Console.WriteLine($"Want to set the value of non existing index 1000 : Mylist[1000]=3");
        My_list[1000] = 3;
        Console.Read();
    }

    private static void InitializeTest(string testname)
    {
        My_list.Clear();
        My_list.Add(3);
        My_list.Add(4);
        My_list.Add(5);
        My_list.Add(6);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"********* {testname} Test *********");
        Console.Write($"Actual list datas : ");
        Console.WriteLine(string.Join("\t", My_list));
    }

    private static void DisplayListAfterAction(string message)
    {
        Console.Write(message);
        Console.WriteLine(string.Join("\t", My_list));
    }
}
namespace Heim;

internal class Program
{
    public static MyList<int> My_list { get; set; }

    private static void Main(string[] args)
    {
        //Adding values Test
        InitializeTest("Adding value", 5);
        My_list.Add(15);
        Console.WriteLine($"Value to Add: 15 ");
        DisplayListAfterAction("List data after adding:  ");

        //Clearing value Test
        InitializeTest("Clearing list", 6);
        My_list.Clear();
        DisplayListAfterAction("Clearing list... List data after clearing:  ");

        //Inserting value Test
        InitializeTest("Inserting list", 5);
        Console.WriteLine($"Want to insert 99 at index 2");
        My_list.Insert(2, 99);
        DisplayListAfterAction("list datas after inserting : ");

        //Removing value Test
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"********* Removeing from list Test *********");

        My_list = new MyList<int>(5);
        FillArray();
        My_list[0] = 4;
        DisplayInitialList();
        Console.WriteLine("Want to Remove '4' value ");
        My_list.Remove(4);
        DisplayListAfterAction($"list datas after removing '4' : ");
        Console.WriteLine("Want to Remove an non existing value '365'");
        My_list.Remove(365);
        DisplayListAfterAction($"list datas after removing non existing'365' : ");

        //RemoveingAt value Test
        InitializeTest("RemoveingAt from list", 5);
        Console.WriteLine("Want to Remove at index '1'");
        My_list.RemoveAt(1);
        DisplayListAfterAction($"list datas after removingAt index '1' : ");
        Console.WriteLine("Want to Remove at non existing index '111'");
        My_list.RemoveAt(111);

        //IndexOf Test
        InitializeTest("IndexOf", 5);
        Console.WriteLine("Want to get indexOf '5' and non existing '8' ");
        Console.WriteLine($"Index of value '5': {My_list.IndexOf(5)}");
        Console.WriteLine($"Index of value '8': {My_list.IndexOf(8)}");

        //Contains Test
        InitializeTest("Contains", 5);
        Console.WriteLine("Want to check if the list contains '3' value and non existing'10' value ");
        Console.WriteLine($"Contains value '3': {My_list.Contains(3)}");
        Console.WriteLine($"Contains value '10': {My_list.Contains(13)}");

        //GetEnumerator Test
        InitializeTest("GetEnumerator", 5);
        Console.WriteLine($"In my code i added 5 values. The 'GetEnumerator' is called for example from this method Console.WriteLine(string.Join(\"\\t\", Mylist));");
        DisplayListAfterAction($"List datas after calling GetEnumerator : ");

        //Count Test
        InitializeTest("Count", 5);
        Console.WriteLine($"Calling Count : {My_list.Count} ");

        // this[int index] Get Test
        InitializeTest("this[int index] Get ", 5);
        Console.WriteLine($"Want to get the value of index 2, Mylist[2] : {My_list[2]} ");
        Console.WriteLine($"Want to get the value of non existing index 1000, Mylist[1000]");
        int value = My_list[1000];

        // this[int index] Set Test
        InitializeTest("this[int index] Set", 5);
        Console.WriteLine($"Want to Set the value of index 2 to 555: Mylist[2]=555");
        My_list[2] = 555;
        DisplayListAfterAction($"New list datas : ");
        Console.WriteLine($"Want to set the value of non existing index 1000 : Mylist[1000]=3");
        My_list[1000] = 3;
        Console.Read();
    }

    /// <summary>
    /// Initialize List, Fill datas & display.
    /// </summary>
    /// <param name="testname">name of test</param>
    /// <param name="length">length of the arry</param>
    private static void InitializeTest(string testname, int length)
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"********* {testname} Test *********");

        My_list = new MyList<int>(length);
        FillArray();
        DisplayInitialList();
    }

    /// <summary>
    /// Display the content of List
    /// </summary>
    private static void DisplayInitialList()
    {
        Console.Write($"Actual list datas : ");
        Console.WriteLine(string.Join("\t", My_list));
    }

    /// <summary>
    /// Display the content of List after doing action test, with custom message.
    /// </summary>
    /// <param name="message"></param>
    private static void DisplayListAfterAction(string message)
    {
        Console.Write(message);
        Console.WriteLine(string.Join("\t", My_list));
    }

    /// <summary>
    /// Fill data in array
    /// </summary>
    private static void FillArray()
    {
        for (int i = 0; i < My_list.Count; i++)
        {
            My_list[i] = i + 1;
        }
    }
}

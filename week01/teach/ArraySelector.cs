public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        // create a new int[] of the correct size that is empty 'result_array' new List<int>();
        List<int> resultArray = new List<int>();
        
        // variables set to 0, that indicate which index to us for each array1 and array2
        int index_l1 = 0;
        int index_l2 = 0;

        // step through the select array and pull itms from the correct array.   forloop for select array
        foreach (int selector in select){
            Console.WriteLine($"selector  is {selector}");

            if (selector == 1){
                int item = list1[index_l1++];
                Console.WriteLine($"item is {item}");
                resultArray.Add(item);
            }
            else if (selector == 2){
                int item = list2[index_l2++];
                Console.WriteLine($"item is {item}");
                resultArray.Add(item);
            }
            else {
                Console.WriteLine("That's weird. There isn't a third selector!");
            }
        }
        // return the result List but it now needs to be and anctual int[] that holds the result.  the function List.toArray I think.
        return resultArray.ToArray();
    }
}
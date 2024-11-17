public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7.0, 14.0, 21.0, 28.0, 35.0}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    { 
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.  example <double>{3,6,9,12,15}
        //new double array of length 'length'
        //for loop iterates using length 
        //create variable called multiple that is i * the number 
        //populates array with each result
        //returns array 
        
        double[] result = new double[length];
        for (int i = 0; i < length; i++){
            double multiple = i * number;
            result[i] = (double) multiple;
        }
        return []; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // takes the var amount and moves it to the front of the list. 
        // make a list of indexes containing the correct indexes to used to add the new rotatedList using the Add() function
        // RotateListRight(times=3) the indexes list is [6,7,8,0,1,2,3,4,5] iterate this list, rotList.Add(data[])
        int count = data.Count;
        int diff = count - amount;
        List<int> slice1 = data.Slice(diff, count-diff);  // [7,8,9]
        List<int> slice2 = data.Slice(0, diff);           // [1,2,3,4,5,6]      

        data.Clear();
        for (int i = 0; i < slice1.Count; i++){
            data.Add(slice1[i]);
        }
         for (int i = 0; i < slice2.Count; i++){
            data.Add(slice2[i]);
        }       
        return;
        
    }
}

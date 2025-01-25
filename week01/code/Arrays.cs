public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // I will create an array and insert the number in the first position array[0]
        //  I will define a for look to continue adding the elements to the array
        // I will multiply the number by the current iteration plus 1 so that I do not insert the initial number twice
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        double[] array = new double[length];
        array[0] = number;
        for (int i = 1; i < length; i++)
        {
            array[i] = number * (i + 1);
        }


        return array; // replace this return statement with your own
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
        // I will define a variable lenght to get the Count of the list and create a for loop to handle the rotations
        // inside the for I will get the last position
        // I will save the value in a variable and delete from the list using Remove
        // then I will use the function myList.Insert(index, value) to add it in the beginning of the list
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        int item = 0;
        int lenght = data.Count;
        for (int i = 0; i < amount; i++)
        {
            item = data[lenght - 1];
            data.Remove(data[lenght - 1]);
            data.Insert(0, item);
        }


    }
}

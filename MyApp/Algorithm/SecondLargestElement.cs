using System;

class SecondLargestElement : ISolution
{
    public void Solve()
    {
        int[] arr = { 5,5,3,1,2,4,5 };
        int firstLargestElement = int.MinValue;
        int secondLargestElement = int.MinValue;

        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] > firstLargestElement)
            {
                secondLargestElement = firstLargestElement;
                firstLargestElement = arr[i];
            }
            else if(arr[i] > secondLargestElement && arr[i] != firstLargestElement)
            {
                secondLargestElement = arr[i];
            }
        }

        Console.WriteLine("First Largest Element: " + firstLargestElement);
        Console.WriteLine("Second Largest Element: " + secondLargestElement);
    }
}


namespace Sussne_four_Assiment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1
            //  Write a program that prints an identity matrix using for loop, in other words takes a
            //  value n from the user and shows the identity table of size n * n.
            //  1 0 0 0
            //  0 1 0 0
            //  0 0 1 0
            //  0 0 0 1

            //Console.Write("Enter the nnumber: ");
            //int n = int.Parse(Console.ReadLine());

            //for(int i = 0; i < n; i++)
            //{
            //    for(int j = 0; j < n; j++)
            //    {
            //        if(i == j)
            //        {
            //            Console.Write("1 ");
            //            continue;
            //        }
            //        Console.Write("0 ");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Q2
            // Write a program in C# Sharp to find the sum of all elements of the array.

            //int[] Array = { 1, 2, 3, 4, 5, 6, 7, 8 };

            //int sum = 0;
            //for(int i = 0;i< Array.Length; i++)
            //{
            //    sum+= Array[i];
            //}

            //Console.WriteLine($"The Sum of the Array is {sum}");


            #endregion

            #region Q3
            // Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order

            //int[] Arr1 = { 1, 4, 7 };
            //int[] Arr2 = { 2, 3, 5 };

            //int[] Result = new int[Arr1.Length * 2];

            //int n = Arr1.Length;

            //int l = 0;
            //int r = 0;

            //int i = 0;

            //while(l < n && r < n)
            //{
            //    if (Arr1[l] <= Arr2[r])
            //    {
            //        Result[i] = Arr1[l];
            //        l++;
            //    }
            //    else
            //    {
            //        Result[i] = Arr2[r];
            //        r++;
            //    }
            //    i++;
            //}

            //while (l < n)
            //{
            //    Result[i] = Arr1[l];
            //    l++;
            //    i++;
            //}

            //while (r < n)
            //{
            //    Result[i] = Arr2[r];
            //    r++;
            //    i++;
            //}

            //for (int j = 0; j< Result.Length; j++)
            //{
            //    Console.Write($"{Result[j]} ");
            //}


            #endregion

            #region Q4
            // Write a program in C# Sharp to count the frequency of each element of an array.

            //int[] Arr = { 1, 2, 3, 4, 5, 2, 3, 4, 1 };

            ///bool[] Visited = new bool[Arr.Length];
            /// O(N^2)
            ///for(int i = 0;i < Arr.Length; i++)
            ///{
            ///    if (Visited[i] == false)
            ///    {
            ///        int counter = 1;
            ///        for(int j = i + 1; j< Arr.Length; j++)
            ///        {
            ///            if (Arr[i] == Arr[j])
            ///            {
            ///                counter++;
            ///                Visited[j] = true;
            ///            }
            ///        }
            ///        Console.WriteLine($"The Number {Arr[i]} Has A Frequency = {counter}");
            ///    }
            ///}

            //int size = 0;

            //for(int i = 0; i < Arr.Length; i++)
            //{
            //    size = Math.Max(size, Arr[i]);
            //}

            //int[] freq = new int[size + 1];

            //for(int i = 0;i < Arr.Length; i++)
            //{
            //    freq[Arr[i]]++;
            //}

            //for(int i = 0; i<= size;i++)
            //{
            //    if (freq[i] > 0)
            //    {
            //        Console.WriteLine($"The Number {i} has a Frequency = {freq[i]}");
            //    }
            //} 
            #endregion

            #region Q5
            // Write a program in C# Sharp to find maximum and minimum element in an array
            //int[] Arr = { 1, 2, 3, 4, 5, 2, 3, 4, 1 };

            //int max = int.MinValue;
            //int min = int.MaxValue;

            //for(int i = 0; i < Arr.Length; i++)
            //{
            //    if(Arr[i] > max)
            //    {
            //        max = Arr[i];
            //    }

            //    if (Arr[i] < min)
            //    {
            //        min = Arr[i];
            //    }
            //}



            #endregion

            #region Q6
            //  Write a program in C# Sharp to find the second largest element in an array.

            //int[] Arr = { 1, 2, 3, 5, 2, 3, 4, 1 };

            //int max = int.MinValue;
            //int Second = int.MinValue;

            //for(int i = 0; i < Arr.Length; i++)
            //{
            //    if(Arr[i] > max)
            //    {
            //        Second = max; 
            //        max = Arr[i];
            //    }else if (Arr[i] > Second)
            //    {
            //        Second = Arr[i];
            //    }
            //}

            //Console.WriteLine(Second);

            #endregion

            #region Q7
            // Consider an Array of Integer values with size N, having values as    
            // in this Example
            // 7 0 0 0 5 6 7 5 0 7 5 3

            //write a program find the longest distance between Two equal cells.In this example.The
            //distance is measured by the number Of cells- for example, the distance between the first
            //and the fourth cell is 2(cell 2 and cell 3).

            //In the example above, the longest distance is between the first 7 and the
            //10th 7, with a distance of 8 cells, i.e.the number of cells between the 1st
            //And the 10th 7s.

            //int[] Arr = { 7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };

            //int MaxDistance = 0;

            //for(int i =0;i<Arr.Length;i++)
            //{
            //    for(int j =Arr.Length-1;j > i;j--)
            //    {
            //        if (Arr[i] == Arr[j])
            //        {
            //            if(MaxDistance < j - i - 1)
            //            {
            //                MaxDistance = j - i - 1;
            //                break;
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine(MaxDistance);

            #endregion

            #region Q8
            // Write a program to create two multidimensional arrays of same size. Accept value
            // from user and store them in first array. Now copy all the elements of first array
            // on second array and print second array.

            //Console.Write("Enter the number: ");
            //int n = int.Parse(Console.ReadLine());

            //int[,] Arr1 = new int[n, n];
            //int[,] Arr2 = new int[n, n];

            //for(int i = 0; i < n; i++)
            //{
            //    for(int j = 0; j < n; j++)
            //    {
            //        Arr1[i,j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Arr2[i, j] = Arr1[i, j];
            //    }
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write($"{Arr2[i,j]} ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Q9
            // Write a Program to Print One Dimensional Array in Reverse Order

            //int[] Arr = { 1, 2, 3, 4, 5, 2, 3, 4, 1 };

            //for(int i = Arr.Length-1; i >= 0; i--)
            //{
            //    Console.Write($"{Arr[i]} ");
            //}


            #endregion

        }
    }
}

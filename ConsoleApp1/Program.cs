namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {  //Q1
            #region User Input and Number Printing
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("Numbers from 1 to " + number + ":");
            //for (int i = 1; i <= number; i++)
            //{
            //    Console.Write(i);
            //    if (i < number)
            //    {
            //        Console.Write(", ");
            //    }
            //}
            //Console.WriteLine();
            #endregion
            //Q2
            #region Multiplication Table
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write(number * i);
            //    if (i < 12)
            //    {
            //        Console.Write(", ");
            //    }
            //}
            //Console.WriteLine();
            #endregion
            //Q3
            #region Print Even Numbers
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 2; i <= number; i += 2)
            //{
            //    Console.Write(i);
            //    if (i + 2 <= number)
            //    {
            //        Console.Write(", ");
            //    }
            //}
            #endregion
            //Q4
            #region Power Calculation
            //Console.Write("Enter the base number: ");
            //int baseNumber = int.Parse(Console.ReadLine());
            //Console.Write("Enter the exponent: ");
            //int exponent = int.Parse(Console.ReadLine());
            //int result = (int)Math.Pow(baseNumber, exponent);
            //Console.WriteLine(result);
            #endregion
            //Q5
            #region Calculate Total, Average, and Percentage
            //int[] marks = new int[5];
            //int total = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("Enter marks for subject " + (i + 1) + ": ");
            //    marks[i] = int.Parse(Console.ReadLine());
            //    total += marks[i];
            //}

            //double average = total / 5.0;
            //double percentage = (total / 500.0) * 100;

            //Console.WriteLine("Total: " + total);
            //Console.WriteLine("Average: " + average);
            //Console.WriteLine("Percentage: " + percentage + "%");
            #endregion
            //Q6
            #region Reverse String
            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();
            //char[] charArray = input.ToCharArray();
            //Array.Reverse(charArray);
            //string reversed = new string(charArray);
            //Console.WriteLine(reversed);
            #endregion
            //Q7
            #region Reverse Integer
            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());
            //int reversed = 0;

            //while (number != 0)
            //{
            //    int digit = number % 10;
            //    reversed = reversed * 10 + digit;
            //    number /= 10;
            //}

            //Console.WriteLine(reversed);
            #endregion
            //Q8
            #region Find Prime Numbers
            //Console.Write("Enter the start of the range: ");
            //int start = int.Parse(Console.ReadLine());
            //Console.Write("Enter the end of the range: ");
            //int end = int.Parse(Console.ReadLine());

            //Console.WriteLine("Prime numbers between " + start + " and " + end + ":");

            //for (int number = start; number <= end; number++)
            //{
            //    bool isPrime = true;

            //    if (number <= 1)
            //    {
            //        continue;
            //    }

            //    for (int i = 2; i <= Math.Sqrt(number); i++)
            //    {
            //        if (number % i == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }

            //    if (isPrime)
            //    {
            //        Console.Write(number + " ");
            //    }
            //}

            //Console.WriteLine();
            #endregion
            //Q9
            #region Decimal to Binary Conversion
            //Console.Write("Enter a decimal number: ");
            //int decimalNumber = int.Parse(Console.ReadLine());
            //string binary = "";

            //while (decimalNumber > 0)
            //{
            //    binary = (decimalNumber % 2) + binary;
            //    decimalNumber /= 2;
            //}

            //Console.WriteLine("Binary representation: " + (string.IsNullOrEmpty(binary) ? "0" : binary));
            #endregion
            //Q10
            #region Check if Points are on a Straight Line
            //Console.Write("Enter the coordinates of the first point (x1, y1): ");
            //int x1 = int.Parse(Console.ReadLine());
            //int y1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the coordinates of the second point (x2, y2): ");
            //int x2 = int.Parse(Console.ReadLine());
            //int y2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the coordinates of the third point (x3, y3): ");
            //int x3 = int.Parse(Console.ReadLine());
            //int y3 = int.Parse(Console.ReadLine());

            //// Calculate the slopes between the points
            //double slope1 = (double)(y2 - y1) / (x2 - x1);
            //double slope2 = (double)(y3 - y2) / (x3 - x2);

            //// Check if the slopes are equal
            //if (slope1 == slope2)
            //{
            //    Console.WriteLine("The points lie on a single straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do not lie on a single straight line.");
            //}
            #endregion
            //Q11
            #region Print Identity Matrix
            //Console.Write("Enter the size of the identity matrix (n): ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write("1 ");
            //        }
            //        else
            //        {
            //            Console.Write("0 ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //#endregion
            ////Q12
            //#region Sum of Array Elements
            //Console.Write("Enter the size of the array: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] array = new int[size];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //int sum = 0;
            //for (int i = 0; i < size; i++)
            //{
            //    sum += array[i];
            //}

            //Console.WriteLine("Sum of all elements in the array: " + sum);
            #endregion
            //Q12
            #region Sum of Array Elements
            //Console.Write("Enter the size of the array: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] array = new int[size];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //int sum = 0;
            //for (int i = 0; i < size; i++)
            //{
            //    sum += array[i];
            //}

            //Console.WriteLine("Sum of all elements in the array: " + sum);
            #endregion
            //Q13
            #region Merge Two Sorted Arrays
            //Console.Write("Enter the size of the arrays: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] array1 = new int[size];
            //int[] array2 = new int[size];
            //int[] mergedArray = new int[2 * size];

            //Console.WriteLine("Enter elements for the first array (sorted in ascending order):");
            //for (int i = 0; i < size; i++)
            //{
            //    array1[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Enter elements for the second array (sorted in ascending order):");
            //for (int i = 0; i < size; i++)
            //{
            //    array2[i] = int.Parse(Console.ReadLine());
            //}

            //int i1 = 0, i2 = 0, iMerged = 0;

            //while (i1 < size && i2 < size)
            //{
            //    if (array1[i1] < array2[i2])
            //    {
            //        mergedArray[iMerged++] = array1[i1++];
            //    }
            //    else
            //    {
            //        mergedArray[iMerged++] = array2[i2++];
            //    }
            //}

            //while (i1 < size)
            //{
            //    mergedArray[iMerged++] = array1[i1++];
            //}

            //while (i2 < size)
            //{
            //    mergedArray[iMerged++] = array2[i2++];
            //}

            //Console.WriteLine("Merged and sorted array:");
            //for (int i = 0; i < mergedArray.Length; i++)
            //{
            //    Console.Write(mergedArray[i] + " ");
            //}
            //Console.WriteLine();
            #endregion
            //Q14
            #region Count Frequency of Array Elements
            //Console.Write("Enter the size of the array: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] array = new int[size];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Element Frequency:");

            //for (int i = 0; i < size; i++)
            //{
            //    int count = 1;
            //    if (array[i] != int.MinValue) // Check if element is already counted
            //    {
            //        for (int j = i + 1; j < size; j++)
            //        {
            //            if (array[i] == array[j])
            //            {
            //                count++;
            //                array[j] = int.MinValue; // Mark as counted
            //            }
            //        }
            //        Console.WriteLine(array[i] + " - " + count);
            //    }
            //}
            #endregion
            //Q15
            #region Find Maximum and Minimum Element in Array
            //Console.Write("Enter the size of the array: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] array = new int[size];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //int max = array[0];
            //int min = array[0];

            //for (int i = 1; i < size; i++)
            //{
            //    if (array[i] > max)
            //    {
            //        max = array[i];
            //    }
            //    if (array[i] < min)
            //    {
            //        min = array[i];
            //    }
            //}

            //Console.WriteLine("Maximum element: " + max);
            //Console.WriteLine("Minimum element: " + min);
            #endregion
            //Q16
            #region Find Second Largest Element in Array
            //Console.Write("Enter the size of the array: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] array = new int[size];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //if (size < 2)
            //{
            //    Console.WriteLine("Array should have at least two elements to find the second largest element.");
            //}
            //else
            //{
            //    int largest = int.MinValue;
            //    int secondLargest = int.MinValue;

            //    for (int i = 0; i < size; i++)
            //    {
            //        if (array[i] > largest)
            //        {
            //            secondLargest = largest;
            //            largest = array[i];
            //        }
            //        else if (array[i] > secondLargest && array[i] != largest)
            //        {
            //            secondLargest = array[i];
            //        }
            //    }

            //    if (secondLargest == int.MinValue)
            //    {
            //        Console.WriteLine("There is no second largest element (all elements may be the same).");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Second largest element: " + secondLargest);
            //    }
            //}
            #endregion
            //Q17
            #region Longest Distance Between Equal Elements
            //Console.Write("Enter the size of the array: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] array = new int[size];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //int maxDistance = -1; // Initialize with -1 to indicate no valid distance found

            //// Loop to find the longest distance between two equal elements
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = i + 1; j < size; j++)
            //    {
            //        if (array[i] == array[j])
            //        {
            //            int distance = j - i - 1; // Calculate the distance
            //            if (distance > maxDistance)
            //            {
            //                maxDistance = distance; // Update the max distance
            //            }
            //        }
            //    }
            //}

            //if (maxDistance == -1)
            //{
            //    Console.WriteLine("No two equal elements found in the array.");
            //}
            //else
            //{
            //    Console.WriteLine("The longest distance between two equal elements is: " + maxDistance);
            //}
            #endregion
            //Q18
            #region Reverse Order of Words
            //Console.Write("Enter a list of space-separated words: ");
            //string input = Console.ReadLine();

            //// Split the input string into words
            //string[] words = input.Split(' ');

            //// Reverse the array of words
            //Array.Reverse(words);

            //// Join the reversed words back into a string
            //string reversedString = string.Join(" ", words);

            //Console.WriteLine("Reversed order of words: " + reversedString);
            #endregion
            //Q19
            #region Copy Elements from One Multidimensional Array to Another
            //Console.Write("Enter the number of rows for the multidimensional array: ");
            //int rows = int.Parse(Console.ReadLine());

            //Console.Write("Enter the number of columns for the multidimensional array: ");
            //int columns = int.Parse(Console.ReadLine());

            //int[,] array1 = new int[rows, columns];
            //int[,] array2 = new int[rows, columns];

            //Console.WriteLine("Enter the elements for the first multidimensional array:");

            //// Accept values from the user for the first array
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write($"Enter element for position ({i},{j}): ");
            //        array1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //// Copy all elements from the first array to the second array
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        array2[i, j] = array1[i, j];
            //    }
            //}

            //// Print the second array
            //Console.WriteLine("Elements of the second multidimensional array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write(array2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            //Q20
            #region Print One Dimensional Array in Reverse Order
            //Console.Write("Enter the size of the array: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] array = new int[size];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Array in reverse order:");
            //for (int i = size - 1; i >= 0; i--)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();
            #endregion
        }
    }
}
        
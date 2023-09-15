

int[] n = { 5, 7, 3, 2, 9 };
int sum = SumArr(n);

Console.WriteLine("Sum of all elements stored in the array is: " + sum);



static int SumArr(int[] n)
{
    int sum = 0;
    foreach (int item in n)
    {
        sum += item;
    }
    return sum;
}

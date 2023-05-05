int[] arr1 = new int[] { 1, 2, 5, 7, 19, 0, 0, 0 };
int[] arr1_copy = new int[5];

Console.Write("{0}, {1}, {2}, {3}, {4} -> ", arr1[0], arr1[1], arr1[2], arr1[3], arr1[4]);

Array.Copy(arr1, arr1_copy, 5);

Console.Write("[");
for (int i = 0; i < arr1_copy.Length; i++)
{
    Console.Write(arr1_copy[i]);
    if (i < arr1_copy.Length - 1)
        Console.Write(", ");
}
Console.Write("]");

Console.WriteLine();

int[] arr2 = new int[] { 6, 1, 33 };

Console.Write("{0}, {1}, {2} -> ", arr2[0], arr2[1], arr2[2]);
Console.Write("[");
for (int i = 0; i < arr2.Length; i++)
{
    Console.Write(arr2[i]);
    if (i < arr2.Length - 1)
        Console.Write(", ");
}
Console.Write("]");
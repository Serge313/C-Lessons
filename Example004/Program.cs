int[] array = {11, 32, 3, 4, 6, 4, 21, 12, 54};

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index = index +1;
}
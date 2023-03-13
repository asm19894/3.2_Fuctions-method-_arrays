int [] array = {1, 2, 31, 14, 21, 16, 23, 4};

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.Write (index);
        break;
    }
    //index = index + 1;
    index++;
}


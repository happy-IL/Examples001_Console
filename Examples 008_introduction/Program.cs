

int [] array = { 1, 12, 31, 4, 15, 16, 17, 19};

int n = array.Lenght;
int find = 4;

ind index = 0;

while (index < n)
{

    if(array[index] == find)
    {
        Console.Writeline(index);
    }
    //index = index + 1;
    index++;
}

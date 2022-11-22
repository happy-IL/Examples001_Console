void FillArray(int[] collection)
{
    int legth = collection.Length;
    int index = 0;
    while (index < legth)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}


FillArray(array);
PrintArray(array);


int [] array = new int[10];


void FillArray(int[] collection);

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Writeline(col[position]);
        position++;
    }

}

int[] array = new int[10];


}





int Index0f(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        return position;
    }
int [] array = new int[10];

FillArray(array);
PrintArray(array);
Console.Writeline();

int pos = Index0f(array, 4);
Console.Writeline(pos);


void FillArray(int[] collection)
{
    int uzun = collection.Length;
    int index = 0;
    while (index < uzun)
    {
        collection [index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position<count)
    {
        Console.WriteLine (col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // -1 вместо 0 для того чтобы в результатах поиска не выдавало 0 если искомого числа нет
    while (index<count)
    {
        if(collection[index]==find)
        {
            position = index;
            break;
        }

        index++;
    }
    return position;
}


int[] array = new int[10]; 
// ввели переменную array и с помощью команды new сказали создай новый массив, в котором будет 10 элементов
// по умолчанию этот массив будет заволнен нулями и чтобы заполнить его другими случайными числами, воспользуемся методом, который описали выше

FillArray(array);
PrintArray(array);
Console.WriteLine();


int pos = IndexOf(array, 4);
Console.WriteLine(pos);


Console.Clear();
int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//                0  1  2   3   4   5   6  7  - индексы нашего массива      
int [] MyArray = {11,21,31,41,15,61,17,18,19};

int Best = Max (
    Max(MyArray[0], MyArray[1], MyArray[2]),
    Max(MyArray[3], MyArray[4], MyArray[5]),
    Max(MyArray[6], MyArray[7], MyArray[8])
);


Console.WriteLine(Best);


Console.Clear();
int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}


int a1 = 15;
int b1 = 27;
int c1 = 30;
int a2 = 16;
int b2 = 48;
int c2 = 14;
int a3 = 72;
int b3 = 23;
int c3 = 33;

int Max1 = Max (a1,b1,c1);
int Max2 = Max (a2,b2,c2);
int Max3 = Max (a3,b3,c3);

Console.WriteLine (Max1);
Console.WriteLine (Max2);
Console.WriteLine (Max3);

int Best = Max (Max1,Max2,Max3);
Console.WriteLine(Best);



﻿//             0  1  2 3 4   5  6  7   
int[] array = {1,12,31,4,15,4,17,18};

int n = array.Length;
int find = 4;

int index = 0;

while (index<n)
{
      if (array [index] == find)
      {
      Console.WriteLine (index);
      break;
      }
      // index = index + 1;
      index++;
}
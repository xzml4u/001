﻿int a = 2;
int b = 3;
int c = 7;
int max;

max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine(max);
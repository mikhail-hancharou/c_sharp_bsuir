#include "Lib.h"
#include "pch.h"
#include <math.h>

int _stdcall Sum(int a, int b)
{
    return a + b;
}

int _stdcall Subtraction(int a, int b)
{
    return a - b;
}

int _stdcall Multiply(int a, int b)
{
    return a * b;
}

int _stdcall Division(int a, int b)
{
    return a / b;
}

int _stdcall Pow(int a, int power)
{
    int value = a;
    while (power - 1 > 0)
    {
        a *= value;
        power--;
    }
    return a;
}

int _stdcall Mod(int a, int b)
{
    return a % b;
}

int _cdecl Abs(int a)
{
    int modifier = a < 0 ? -1 : 1;
    return a * modifier;
}

int _cdecl Min(int a, int b)
{
    return a < b ? a : b;
}

int _cdecl Max(int a, int b)
{
    return a > b ? a : b;
}
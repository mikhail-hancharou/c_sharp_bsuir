#pragma once

#ifdef MATHLIBRARY_EXPORTS
#define MATHLIBRARY_API __declspec(dllexport)
#else
#define MATHLIBRARY_API __declspec(dllimport)
#endif

extern "C" 
{
    MATHLIBRARY_API int _stdcall Subtraction(int a, int b);
    MATHLIBRARY_API int _stdcall Sum(int a, int b);
    MATHLIBRARY_API int _stdcall Multiply(int a, int b);
    MATHLIBRARY_API int _stdcall Division(int a, int b);
    MATHLIBRARY_API int _stdcall Pow(int a, int power);
    MATHLIBRARY_API int _stdcall Mod(int a, int b);
    MATHLIBRARY_API int _cdecl Abs(int a);
    MATHLIBRARY_API int _cdecl Min(int a, int b);
    MATHLIBRARY_API int _cdecl Max(int a, int b);

}

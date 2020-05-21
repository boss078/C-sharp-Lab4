#ifdef MYCROSSPLATFORMLIB_EXPORTS
#define MYCROSSPLATFORMLIB_API __declspec(dllexport)
#else
#define MYCROSSPLATFORMLIB_API __declspec(dllimport)
#endif

#include "pch.h"

extern "C" __int32 MYCROSSPLATFORMLIB_API __stdcall pow(__int32 number, __int32 pow);

extern "C" float MYCROSSPLATFORMLIB_API __stdcall returnPI();
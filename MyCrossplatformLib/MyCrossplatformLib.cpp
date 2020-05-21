#include "pch.h"
#include "MyCrossplatformLib.h"

__int32 __stdcall pow(__int32 number, __int32 power) {
	__int32 result = 1;
	for (__int32 i = 0; i < power; i++) {
		result *= number;
	}
	return result;
}

float __stdcall returnPI() {
	return 3.14159265359;
}
#pragma once
#include "PluginSettings.h"
#include "SimpleClass.h"
#ifdef __cplusplus
extern "C"
{
#endif
	// Put your functions here
	PLUGIN_API int SimpleFunction();
	//I/O
	PLUGIN_API void ReadInto(float objectNumber, float x, float y, float z);
	PLUGIN_API void startWriting();
	PLUGIN_API void endWriting();
	PLUGIN_API int returnLines();
	PLUGIN_API float ReadOut(int j);
	PLUGIN_API int aTest();
#ifdef __cplusplus
}
#endif

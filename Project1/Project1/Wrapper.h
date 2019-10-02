#pragma once
#include "PluginSettings.h"
#include "SimpleClass.h"
#include "FileManager.h"
#ifdef __cplusplus
extern "C"
{
#endif
	// Put your functions here
	PLUGIN_API int SimpleFunction();

	PLUGIN_API int getPosX();
	PLUGIN_API int getPosY();
	PLUGIN_API int getPosZ();
	PLUGIN_API int setPosX();
	PLUGIN_API int setPosY();
	PLUGIN_API int setPosZ();
	PLUGIN_API int printPos();

#ifdef __cplusplus
}
#endif

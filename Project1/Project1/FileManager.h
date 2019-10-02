#pragma once
#include "PluginSettings.h"

//Core LIbraries
#include <iostream>
#include <fstream>
#include <string>
#include <direct.h>

class PLUGIN_API FileManager {
public:
	//File IO


	int getPosX();
	int getPosY();
	int getPosZ();
	void setPosX(int posX, int posY, int posZ);
	//	int setPosY();
	//	int setPosZ();

	int BlockPosX = 0;
	int BlockPosY = 0;
	int BlockPosZ = 0;


	//void savePosX(char * filePath);


};

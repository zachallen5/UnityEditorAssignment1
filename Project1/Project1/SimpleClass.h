#pragma once
#include "PluginSettings.h"
#include <fstream>
#include <iostream>
#include <string>
#include <vector>
using namespace std;


class PLUGIN_API SimpleClass
{
public:
	ofstream myFile;

	int SimpleFunction();
	int aTest();
	void startWriting();
	void endWriting();
	void ReadInto(float objectNumber, float x, float y, float z);
	float ReadOut(int j);
	int returnLines();

	vector <float> read;

};
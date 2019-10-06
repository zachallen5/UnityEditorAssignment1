#include "Wrapper.h"
SimpleClass simpleClass;
int SimpleFunction()
{
	return simpleClass.SimpleFunction();
}
int aTest()
{
	return simpleClass.aTest();
}

void ReadInto(float objectNumber, float x, float y, float z)
{
	simpleClass.ReadInto(objectNumber, x, y, z);
}

float ReadOut(int j)
{
	return simpleClass.ReadOut(j);
}

void startWriting()
{
	simpleClass.startWriting();
}

void endWriting()
{
	simpleClass.endWriting();
}

int returnLines()
{
	return simpleClass.returnLines();
}
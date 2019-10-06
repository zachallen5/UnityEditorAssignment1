#include "SimpleClass.h"
int SimpleClass::SimpleFunction()
{
	return 1;
}

int SimpleClass::aTest()
{
	return 1;
}
void SimpleClass::startWriting()
{
	myFile.open("test.txt");

}
void SimpleClass::endWriting()
{
	myFile.close();
}

void SimpleClass::ReadInto(float objectNumber, float x, float y, float z)
{

	myFile << objectNumber << "\n";
	myFile << x << "\n";
	myFile << y << "\n";
	myFile << z << "\n";
	

}

float SimpleClass::ReadOut(int j)
{
	read.clear();
	ifstream myReadFile;
	myReadFile.open("test.txt");
	float value;
	while (myReadFile >> value)
	{
		read.push_back(value);
		
	}
	myReadFile.close();
	return read[j];

	
}

int SimpleClass::returnLines()
{
	read.clear();
	ifstream myReadFile;
	myReadFile.open("test.txt");
	int value = 0;
	string tempString;
	while (getline(myReadFile, tempString))
	{
		value++;
	}
	myReadFile.close();
	return value;


}

//float SimpleClass::returnLines()
//{
//	ifstream myReadFile;
//	myReadFile.open("text.txt");
//	float count = 0.0f;
//	while (!myReadFile.eof())
//	{
//		count++;
//	}
//	return count;
//
//}
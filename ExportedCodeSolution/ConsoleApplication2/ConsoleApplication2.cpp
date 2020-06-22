// ConsoleApplication2.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
//

#include <iostream>
#include <Windows.h>

using CallUriFn = void(__stdcall*) ();

int main()
{
	HMODULE mod = LoadLibraryA("ExportedCodeSolution.dll");
	CallUriFn fn = reinterpret_cast<CallUriFn>(GetProcAddress(mod, "callUri"));
	fn();
}

#pragma once
#ifndef SudokuSolver_Lock_Class_Included
#define SudokuSolver_Lock_Class_Included

#include "stdafx.h"

using namespace System;

namespace SudokuSolver
{
	//DOLATER class description of Lock
	public ref class LockAbstract
	{
	private:
		System::Threading::EventWaitHandle ^ hEventWaitHandle;

	public:
		//Creates a new instance of Lock
		LockAbstract();

		//DOLATER add description
		inline void Lock();
		//DOLATER add description
		inline void Unlock();
	};
}

#endif // !SudokuSolver_Lock_Class_Included
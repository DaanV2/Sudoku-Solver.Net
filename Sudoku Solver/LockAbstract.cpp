#include "stdafx.h"
#include "LockAbstract.h"

namespace SudokuSolver
{
	LockAbstract::LockAbstract()
	{
		this->hEventWaitHandle = gcnew System::Threading::EventWaitHandle(true, System::Threading::EventResetMode::AutoReset);
	}

	inline void LockAbstract::Lock()
	{
		this->hEventWaitHandle->WaitOne();
	}

	inline void LockAbstract::Unlock()
	{
		this->hEventWaitHandle->Set();
	}
}
#include "stdafx.h"
#include "BaseValues.h"

namespace SudokuSolver
{
	BaseValues::BaseValues() : CanValues()
	{
		this->hMarkCalculated = false;
		this->hFinalValue = false;
	}
}
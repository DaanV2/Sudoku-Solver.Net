#pragma once
#include "CanValues.h"
#include "Cell.h"

#ifndef SudokuSolver_Determine_Class_Included
#define SudokuSolver_Determine_Class_Included

namespace SudokuSolver
{
	public ref class Determine : public CanValues
	{
	private:
		array<Cell^, 1>^ hCells;

	public:
		Determine();
	};
}

#endif // !SudokuSolver_Determine_Class_Included
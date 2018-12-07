#pragma once

#ifndef SudokuSolver_Cell_Class_Included
#define SudokuSolver_Cell_Class_Included
#include "GridCell.h"

namespace SudokuSolver
{
	public ref class GridCellCollection
	{
		array<GridCell^, 2>^ hCells;

	public:
		GridCellCollection();

		//TODO add description
		property array<GridCell^, 2>^ Cells
		{
			array<GridCell^, 2>^ get() { return this->hCells; }
			void set(array<GridCell^, 2>^ value) { this->hCells = value; }
		}

		GridCell^ operator()(int X, int Y)
		{
			return this->hCells[X, Y];
		}
	};
}

#endif // !SudokuSolver_Cell_Class_Included


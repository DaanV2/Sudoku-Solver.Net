#pragma once

#ifndef SudokuSolver_GridItem_Class_Included
#define SudokuSolver_GridItem_Class_Included

#include "Cell.h"

namespace SudokuSolver
{
	public ref class GridItem
	{
	private:
		array<Cell^, 2>^ hCells;

	public:
		GridItem(array<Cell^, 2>^ Cells, const int % X, const int % Y);

		//TODO add description
		property array<Cell^, 2>^ Cells
		{
			array<Cell^, 2>^ get() { return this->hCells; }
			void set(array<Cell^, 2>^ value) { this->hCells = value; }
		}
	};
}

#endif
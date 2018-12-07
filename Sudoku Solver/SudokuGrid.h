#pragma once

#ifndef SudokuSolver_SudokuGrid_Class_Included
#define SudokuSolver_SudokuGrid_Class_Included

#include "Cell.h"
#include "GridItem.h"

namespace SudokuSolver
{
	public ref class SudokuGrid
	{
	private: 
		array<Cell^, 2>^ hCells;
		array<GridItem^, 2>^ hGridItems;

	public:
		SudokuGrid();

		//TODO add description
		property array<Cell^, 2>^ Cells
		{
			array<Cell^, 2>^ get() { return this->hCells; }
			void set(array<Cell^, 2>^ value) { this->hCells = value; }
		}

		//TODO add description
		property array<GridItem^, 2>^ GridItems
		{
			array<GridItem^, 2>^ get() { return this->hGridItems; }
			void set(array<GridItem^, 2>^ value) { this->hGridItems = value; }
		}
	};
}

#endif // !SudokuSolver_SudokuGrid_Class_Included
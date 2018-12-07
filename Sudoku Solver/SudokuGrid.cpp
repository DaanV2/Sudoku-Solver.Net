#include "stdafx.h"
#include "SudokuGrid.h"

namespace SudokuSolver
{
	SudokuGrid::SudokuGrid()
	{
		this->hCells = gcnew array<Cell^, 2>(9, 9);
		
		for (int X = 0; X < this->hCells->GetLength(0); X++)
			for (int Y = 0; Y < this->hCells->GetLength(1); Y++)
				this->hCells[X, Y] = gcnew Cell();

		this->hGridItems = gcnew array<GridItem^, 2>(3, 3);

		for (int X = 0; X < this->hGridItems->GetLength(0); X++)
			for (int Y = 0; Y < this->hGridItems->GetLength(1); Y++)
				this->hGridItems[X, Y] = gcnew GridItem(this->hCells, X * 3, Y * 3);
	}
}

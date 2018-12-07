#include "stdafx.h"
#include "GridItem.h"

namespace SudokuSolver
{
	GridItem::GridItem(array<Cell^, 2>^ Cells, const int % X, const int % Y)
	{
		this->hCells = gcnew array<Cell^, 2>(3, 3);

		for (int hX = 0; hX < hCells->Length; hX++)
			for (int hY = 0; hY < hCells->Length; hY++)
				this->hCells[hX, hY] = Cells[X + hX, Y + hY];
	}
}

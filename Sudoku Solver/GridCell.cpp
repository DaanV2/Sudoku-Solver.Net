#include "stdafx.h"
#include "GridCell.h"

namespace SudokuSolver
{
	GridCell::GridCell()
	{
		this->hCan1 = false;
		this->hCan2 = false;
		this->hCan3 = false;
		this->hCan4 = false;
		this->hCan5 = false;
		this->hCan6 = false;
		this->hCan7 = false;
		this->hCan8 = false;
		this->hCan9 = false;

		this->hValue = 0;
	}
}
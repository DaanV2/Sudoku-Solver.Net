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
	
	GridCell::GridCell(const GridCell ^ Copy)
	{
		this->hCan1 = Copy->hCan1;
		this->hCan2 = Copy->hCan2;
		this->hCan3 = Copy->hCan3;
		this->hCan4 = Copy->hCan4;
		this->hCan5 = Copy->hCan5;
		this->hCan6 = Copy->hCan6;
		this->hCan7 = Copy->hCan7;
		this->hCan8 = Copy->hCan8;
		this->hCan9 = Copy->hCan9;

		this->hValue = Copy->hValue;
	}
}
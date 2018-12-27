#pragma once

#ifndef SudokuSolver_GridCellCollection_Class_Included
#define SudokuSolver_GridCellCollection_Class_Included

#include "stdafx.h"
#include "GridCell.h"

namespace SudokuSolver
{
	public ref class GridCellCollection
	{
	private:
		array<GridCell^> ^ hItems;

	public:
		//TODO add description
		GridCellCollection();

		//TODO add description
		Property(array<GridCell^>^, hItems, Item)

		//TODO add description
		property size_t Count
		{
#ifdef ENVIRONMENT32
			size_t get() { return (size_t)this->hItems->GetLength(0); }
#else
			size_t get() { return (size_t)this->hItems->GetLongLength(0); }
#endif
		}
	};
}

#endif //!SudokuSolver_GridCellCollection_Class_Included

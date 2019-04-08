/*ISC License

Copyright (c) 2018, Daan Verstraten, daanverstraten@hotmail.com

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted, provided that the above
copyright notice and this permission notice appear in all copies.

THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.*/
#pragma once

#ifndef SudokuSolver_SudokuGrid_Class_Included
#define SudokuSolver_SudokuGrid_Class_Included

#include "stdafx.h"
#include "GridCell.h"
#include "DetermineCollection.h"

namespace SudokuSolver
{
	//DOLATER add description
	public ref class SudokuGrid
	{
	private:
		array<GridCell^, 2>^ hCells;
		array<DetermineCollection<GridCell^>^, 1>^ hRows;
		array<DetermineCollection<GridCell^>^, 1>^ hColumns;
		array<DetermineCollection<GridCell^>^, 2>^ hBlocks;

	public:
		//DOLATER add description
		SudokuGrid();

		//DOLATER add description
		SudokuGrid(const SudokuGrid ^ Copy);
		
		//DOLATER add description
		property GridCell^ Cells[size_t, size_t]
		{
			GridCell^ get(size_t R, size_t C)
			{
				return this->hCells[R, C];
			}
			void set(size_t R, size_t C, GridCell^ value)
			{
				this->hCells[R, C] = value;
			}
		}

		//DOLATER add description
		inline void Set(const size_t & R, const size_t & C, GridCell ^ value);

		//DOLATER add description
		inline GridCell ^ Get(const size_t & R, const size_t & C);
	};
}

#endif //!SudokuSolver_SudokuGrid_Class_Included

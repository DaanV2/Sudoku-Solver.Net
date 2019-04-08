#include "stdafx.h"
#include "SudokuGrid.h"

namespace SudokuSolver
{
	SudokuGrid::SudokuGrid()
	{
		this->hCells = gcnew array<GridCell^, 2>(9, 9);
		this->hRows = gcnew array<DetermineCollection<GridCell^>^, 1>(9);
		this->hColumns = gcnew array<DetermineCollection<GridCell^>^, 1>(9);
		this->hBlocks = gcnew array<DetermineCollection<GridCell^>^, 2>(3, 3);

		for (size_t I = 0; I < this->hRows->Length; I++)
			this->hRows[I] = gcnew DetermineCollection<GridCell^>(9);

		for (size_t I = 0; I < this->hColumns->Length; I++)
			this->hColumns[I] = gcnew DetermineCollection<GridCell^>(9);

		for (size_t R = 0; R < this->hBlocks->GetLength(0); R++)
			for (size_t C = 0; C < this->hBlocks->GetLength(1); C++)
				this->hBlocks[R, C] = gcnew DetermineCollection<GridCell^>(9);

		for (size_t R = 0; R < this->hCells->GetLength(0); R++)
			for (size_t C = 0; C < this->hCells->GetLength(1); C++)
				this->Set(R, C, gcnew GridCell());
	}

	SudokuGrid::SudokuGrid(const SudokuGrid ^ Copy)
	{
		this->hCells = gcnew array<GridCell^, 2>(9, 9);
		this->hRows = gcnew array<DetermineCollection<GridCell^>^, 1>(9);
		this->hColumns = gcnew array<DetermineCollection<GridCell^>^, 1>(9);
		this->hBlocks = gcnew array<DetermineCollection<GridCell^>^, 2>(3, 3);

		for (size_t I = 0; I < this->hRows->Length; I++)
			this->hRows[I] = gcnew DetermineCollection<GridCell^>(9);

		for (size_t I = 0; I < this->hColumns->Length; I++)
			this->hColumns[I] = gcnew DetermineCollection<GridCell^>(9);

		for (size_t R = 0; R < this->hBlocks->GetLength(0); R++)
			for (size_t C = 0; C < this->hBlocks->GetLength(1); C++)
				this->hBlocks[R, C] = gcnew DetermineCollection<GridCell^>(9);				

		for (size_t R = 0; R < this->hCells->GetLength(0); R++)
			for (size_t C = 0; C < this->hCells->GetLength(1); C++)
				this->Set(R, C, gcnew GridCell(Copy->hCells[R, C]));
	}

	inline void SudokuGrid::Set(const size_t & R, const size_t & C, GridCell ^ value)
	{
		this->hCells[R, C] = value;
		this->hRows[R][C] = value;
		this->hColumns[C][R] = value;

		size_t nR = R % 3;
		size_t nC = C % 3;
		this->hBlocks[nR, nC][nR + nC * 3] = value;
	}

	inline GridCell ^ SudokuGrid::Get(const size_t & R, const size_t & C)
	{
		return this->hCells[R, C];
	}
}

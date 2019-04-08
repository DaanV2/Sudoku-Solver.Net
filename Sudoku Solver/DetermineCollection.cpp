#include "stdafx.h"
#include "DetermineCollection.h"

namespace SudokuSolver
{
	generic<typename TypeItem>
	DetermineCollection<TypeItem>::DetermineCollection()
	{
		this->hItems = gcnew array<TypeItem>(1);
	}

	generic<typename TypeItem>
	DetermineCollection<TypeItem>::DetermineCollection(const size_t & Size)
	{
		this->hItems = gcnew array<TypeItem>(Size);
	}

	generic<typename TypeItem>
	DetermineCollection<TypeItem>::DetermineCollection(array<TypeItem, 1>^ Items)
	{
		this->hItems = Items;
	}

	generic<typename TypeItem>
	void DetermineCollection<TypeItem>::Set(const size_t & Index, TypeItem Item)
	{
		if (this->hItems->GetLength(0) <= Index)
			Array::Resize<TypeItem>(this->hItems, Index);

		this->hItems[Index] = Item;
	}

	generic<typename TypeItem>
	TypeItem DetermineCollection<TypeItem>::Get(const size_t & Index)
	{
		if (this->hItems->GetLength(0) <= Index)
			return TypeItem();

		return this->hItems[Index];
	}
}
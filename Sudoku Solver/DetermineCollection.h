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

#ifndef SudokuSolver_DetermineCollection_Class_Included
#define SudokuSolver_DetermineCollection_Class_Included

#include "stdafx.h"

namespace SudokuSolver
{
	generic<typename TypeItem>
	public ref class DetermineCollection
	{
	private:
		array<TypeItem> ^ hItems;

	public:
		//DOLATER add description
		DetermineCollection();

		//DOLATER add description
		DetermineCollection(const size_t & Size);

		//DOLATER add description
		DetermineCollection(array<TypeItem, 1>^ Items);

		//DOLATER add description
		Property(array<TypeItem>^, hItems, Items)

		//DOLATER add description
		property size_t Count
		{
#ifdef ENVIRONMENT32
			size_t get() { return (size_t)this->hItems->GetLength(0); }
#else
			size_t get() { return (size_t)this->hItems->GetLongLength(0); }
#endif
		}

		//DOLATER add description
		property TypeItem default[size_t]
		{
			TypeItem get(size_t Index)
			{
				return this->hItems[Index];
			}
			void set(size_t Index, TypeItem value)
			{
				this->hItems[Index] = value;
			}
		}

		//DOLATER add description
		void Set(const size_t & Index, TypeItem Item);
		//DOLATER add description
		TypeItem Get(const size_t & Index);	
	};
}

#endif //!SudokuSolver_GridCellCollection_Class_Included

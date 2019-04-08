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

#ifndef SudokuSolver_GridCell_Class_Included
#define SudokuSolver_GridCell_Class_Included

#include "GridCell.h"
#include "LockAbstract.h"
#include "stdafx.h"

namespace SudokuSolver
{
	//DOLATER add description
	public ref class GridCell : public LockAbstract
	{
	private:
		bool hCan1;
		bool hCan2;
		bool hCan3;
		bool hCan4;
		bool hCan5;
		bool hCan6;
		bool hCan7;
		bool hCan8;
		bool hCan9;

		unsigned char hValue;

	public:
		//DOLATER add description
		GridCell();

		//DOLATER add description
		GridCell(const GridCell ^ Copy);

		//DOLATER add description
		event ValueChangedEventHandler<GridCell^>^ ValueChanged;
		//DOLATER add description
		event ValueChangedEventHandler<GridCell^>^ CanValueChanged;

		//DOLATER add description
		Property_WithEvent(bool, hCan1, Can1, CanValueChanged)
		//DOLATER add description
		Property_WithEvent(bool, hCan2, Can2, CanValueChanged)
		//DOLATER add description
		Property_WithEvent(bool, hCan3, Can3, CanValueChanged)
		//DOLATER add description
		Property_WithEvent(bool, hCan4, Can4, CanValueChanged)
		//DOLATER add description
		Property_WithEvent(bool, hCan5, Can5, CanValueChanged)
		//DOLATER add description
		Property_WithEvent(bool, hCan6, Can6, CanValueChanged)
		//DOLATER add description
		Property_WithEvent(bool, hCan7, Can7, CanValueChanged)
		//DOLATER add description
		Property_WithEvent(bool, hCan8, Can8, CanValueChanged)
		//DOLATER add description
		Property_WithEvent(bool, hCan9, Can9, CanValueChanged)

		//DOLATER add description
		property unsigned char Value
		{
			unsigned char get() { return this->hValue; }
			void set(unsigned char value)
			{
				this->hValue = value;

				if (this->hValue > 0)
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
				}

				this->ValueChanged(this);
			}
		};
	};
}
#endif
#pragma once

#ifndef SudokuSolver_GridCell_Class_Included
#define SudokuSolver_GridCell_Class_Included

#include "GridCell.h"
#include "stdafx.h"

namespace SudokuSolver
{
	//TODO add description
	public ref class GridCell
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
		//TODO add description
		GridCell();

		//TODO add description
		event ValueChangedEventHandler<GridCell^>^ ValueChanged;
		//TODO add description
		event ValueChangedEventHandler<GridCell^>^ CanValueChanged;

		//TODO add description
		Property_WithEvent(bool, hCan1, Can1, CanValueChanged)
		//TODO add description
		Property_WithEvent(bool, hCan2, Can2, CanValueChanged)
		//TODO add description
		Property_WithEvent(bool, hCan3, Can3, CanValueChanged)
		//TODO add description
		Property_WithEvent(bool, hCan4, Can4, CanValueChanged)
		//TODO add description
		Property_WithEvent(bool, hCan5, Can5, CanValueChanged)
		//TODO add description
		Property_WithEvent(bool, hCan6, Can6, CanValueChanged)
		//TODO add description
		Property_WithEvent(bool, hCan7, Can7, CanValueChanged)
		//TODO add description
		Property_WithEvent(bool, hCan8, Can8, CanValueChanged)
		//TODO add description
		Property_WithEvent(bool, hCan9, Can9, CanValueChanged)

		//TODO add description
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
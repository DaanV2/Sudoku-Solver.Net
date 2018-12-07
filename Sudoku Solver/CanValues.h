#pragma once

#ifndef SudokuSolver_CanValues_Class_Included
#define SudokuSolver_CanValues_Class_Included

using namespace System;

namespace SudokuSolver
{
	public delegate void ValueChangedEventHandler(Object ^ sender);

	public ref class CanValues abstract
	{
		bool hCan_1;
		bool hCan_2;
		bool hCan_3;
		bool hCan_4;
		bool hCan_5;
		bool hCan_6;
		bool hCan_7;
		bool hCan_8;
		bool hCan_9;

	public:
		CanValues();

		event ValueChangedEventHandler ^ CanValueChanged;

		//TODO add description
		Property_WithEvent(bool, hCan_1, Can_1, CanValueChanged)
		//TODO add description
		Property_WithEvent(bool, hCan_2, Can_2, CanValueChanged)
		//TODO add description
		Property_WithEvent(bool, hCan_3, Can_3, CanValueChanged)
		//TODO add description
		Property_WithEvent(bool, hCan_4, Can_4, CanValueChanged)
		//TODO add description
		Property_WithEvent(bool, hCan_5, Can_5, CanValueChanged)
		//TODO add description
		Property_WithEvent(bool, hCan_6, Can_6, CanValueChanged)
		//TODO add description
		Property_WithEvent(bool, hCan_7, Can_7, CanValueChanged)
		//TODO add description
		Property_WithEvent(bool, hCan_8, Can_8, CanValueChanged)
		//TODO add description
		Property_WithEvent(bool, hCan_9, Can_9, CanValueChanged)
	};
}

#endif

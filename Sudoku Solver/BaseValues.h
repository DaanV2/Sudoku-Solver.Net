#pragma once

#ifndef SudokuSolver_BaseValues_Class_Included
#define SudokuSolver_BaseValues_Class_Included

#include "CanValues.h"

using namespace System;

namespace SudokuSolver
{
	public ref class BaseValues abstract : public CanValues
	{
		bool hMarkCalculated;
		unsigned char hFinalValue;

	public:
		BaseValues();

		event ValueChangedEventHandler ^ FinalValueChanged;

		//TODO add description
		Property_WithEvent(unsigned char, hFinalValue, FinalValue, FinalValueChanged)
		//TODO add description
		Property(bool, hMarkCalculated, MarkCalculated)

	};
}

#endif
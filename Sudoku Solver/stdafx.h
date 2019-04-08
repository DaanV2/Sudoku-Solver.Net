#pragma once

#ifndef Stdafxh_Included
#define Stdafxh_Included

#include "stdEnviroment.h"

#define Property($Type, $Variable, $Name) property $Type $Name { \
	$Type get() { return this->$Variable; }\
	void set($Type value) { this->$Variable = value; } };

#define Property_WithEvent($Type, $Variable, $Name, $Event) property $Type $Name { \
	$Type get() { return this->$Variable; }\
	void set($Type value) { this->$Variable = value; this->$Event(this); } };

#define Property_ReadOnly($Type, $Variable, $Name) property $Type $Name { \
	$Type get() { return this->$Variable; } } };

using namespace System;

namespace SudokuSolver
{
	//DOLATER add description
	generic <typename T>
	delegate void ValueChangedEventHandler(T sender);
}

#endif // !Stdafxh_Included
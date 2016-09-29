using UnityEngine;
using System.Collections;
using uFrame.Attributes;
using Leap;

[ActionLibrary, uFrameCategory("Math")]
public static class MathUtils  {


	public static int increment(int integer)
	{
		integer = integer + 1;
		return integer;
	}

	public static int decrement (int integer){
		integer = integer - 1;
		return integer;
	}
}


using UnityEngine;
using System.Collections;
using uFrame.Attributes;
using Leap;

[ActionLibrary, uFrameCategory("Math")]
public static class StringUtils  {


	public static string concatenateStringAndString(string a, string b){
		return a + b;
	}

	public static string concatenateIntAndString(int a, string b){
		return a.ToString () + b;
	}
}
using UnityEngine;
using System.Collections;
using Leap;

public class Excercise {

	private bool[] fingerStates;

	private string question;

	private int solution;


	public Excercise(string question, int solution)
	{
		//this.fingerStates = fingerStates;
		this.question = question;
		this.solution = solution;
	}

	public bool isSatisfied(Hand leftHand, Hand rightHand)
	{
		int sum = 0;

		for(int i=0; i<5;i++)
		{
			if (leftHand.Fingers[i].IsExtended)
				sum += 1; 
		}

		for(int i=0; i<5;i++)
		{
			if (rightHand.Fingers[i].IsExtended)
				sum += 1; 
		}

		if (sum == solution)
			return true;

		return false;
	}

	public string getQuestion(){
		return question;
	}

	public int getSolution(){
		return solution;
	}


}

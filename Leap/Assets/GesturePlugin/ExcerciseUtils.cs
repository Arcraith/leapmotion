using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Leap;
using System;
using uFrame.Attributes;
using LeapDB;

[ActionLibrary, uFrameCategory("Excercise")]
public static class ExcerciseUtils  {
	
	private static List<Excercise> excerciseList = new List<Excercise> ();

	private static IDictionary excerciseDictionary = new Dictionary<object, Excercise>();

	private static IDictionary easyExcerciseDict = new Dictionary<object, Excercise> ();

	private static IDictionary mediumExcerciseDict = new Dictionary<object, Excercise> ();

	private static IDictionary hardExcerciseDict = new Dictionary<object, Excercise> ();

	private static float oldTime = 0;

	private static float newTime = 0;

	private static float deltaTime = 0;

	private static bool gestureBroken = true;

	public static void registerExcercise(object key1, string question, int answer)
	{
		
		addToDict ("easy", easyExcerciseDict);
		addToDict ("medium", mediumExcerciseDict);
		addToDict ("hard", hardExcerciseDict);


		excerciseDictionary = easyExcerciseDict;
	}

	private static void addToDict(string difficulty, IDictionary dictionary){
		int key = 1;

		StreamReader reader = new StreamReader(Application.dataPath + "/Excercises/"+difficulty+"Excercises.txt");
		string content = reader.ReadToEnd ();
		reader.Close ();

		string[] lines = content.Split ("\n"[0]);

		foreach (string line in lines) {
			Char delimiter = ':';
			string[] lineContents = line.Split (delimiter);
			dictionary.Add(key, new Excercise(lineContents[0], Int32.Parse(lineContents[1])));
			//Debug.Log ("key: " + key + ", question: " + lineContents[0] + ", answer: " + lineContents[1]);
			key++;	
		}
	}

	public static string getExcerciseText(object key){
		Excercise ex = (Excercise) excerciseDictionary [key];

		return ex.getQuestion ();
		//return "hallo";
	}

	public static void setDifficultyExcercises(Difficulties level){
		switch (level) {
		case Difficulties.Easy:
			excerciseDictionary = easyExcerciseDict;
			break;
		case Difficulties.Medium:
			excerciseDictionary = mediumExcerciseDict;
			break;
		case Difficulties.Hard:
			excerciseDictionary = hardExcerciseDict;
			break;
		default:
			excerciseDictionary = easyExcerciseDict;
			break;
		}
	}

	public static bool isEmpty(){
		return (excerciseDictionary.Count == 0);
	}

	public static void isExcerciseSolved(object key, Hand leftHand, Hand rightHand, Action yes, Action no)
	{
		Excercise ex = (Excercise)excerciseDictionary [key];

		if (ex.isSatisfied(leftHand,rightHand))
		{
			yes();
		}
		else
			no();
	}

	public static void SolveCountdown(float holdingTime, Action yes){
		
		newTime = Time.time;

		deltaTime = newTime - oldTime;
		//Debug.Log ("delta: " + deltaTime);

		if (deltaTime >= holdingTime) {
			yes ();
		}

		if(gestureBroken == true){
			oldTime = newTime;
			gestureBroken = false;
		}
	}

	public static float getTimePassed(){
		return deltaTime;
	}

	public static void breakGesture(){
		gestureBroken = true;
		oldTime = Time.time;
	}

	public static void fillLoadingBar(Transform loadingBar, float maxTime, float delta){
		//Debug.Log (delta);

		if (delta != 0)
			loadingBar.GetComponent<UnityEngine.UI.Image> ().fillAmount = delta / maxTime;
		else
			loadingBar.GetComponent<UnityEngine.UI.Image> ().fillAmount = 0;
	}
}

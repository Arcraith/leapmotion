using UnityEngine;
using System.Collections;
using uFrame.Attributes;
using LeapDB;

[ActionLibrary, uFrameCategory("Gameobject")]
public static class GameObjectUtils {
    


    public static void setActive(GameObject obj, bool state)
    {
        obj.SetActive(state);
    }


	[ActionTitle("SetColor")]
	[ActionDescription("Set Material Color to String Value")]
	public static void setColor(GameObject obj, string color){

		if (color == "red")
			obj.GetComponent<Renderer> ().material.color = Color.red;
		else if (color == "blue")
			obj.GetComponent<Renderer> ().material.color = Color.blue;
		else if (color == "green")
			obj.GetComponent<Renderer> ().material.color = Color.green;
		else if (color == "yellow")
			obj.GetComponent<Renderer> ().material.color = Color.yellow;
		else
			obj.GetComponent<Renderer> ().material.color = Color.white;
		
	}


	[ActionTitle("SetColorRGB")]
	[ActionDescription("Set Material Color to RGB Value")]
	public static void setColorRGB(GameObject obj, int red, int green, int blue){
		int r = red;
		int g = green;
		int b = blue;

		if (r > 255)
			r = 255;

		if (g > 255)
			g = 255;

		if (b > 255)
			b = 255;

		if (obj != null) {
			obj.GetComponent<Renderer> ().material.color = new Color (r, g, b);
		}
	}


	[ActionTitle("Find GameObject")]
	[ActionDescription("Searches for GameObject with given name")]
	public static void findGameObject(string name, out GameObject result){
		result = null;
		result = GameObject.Find (name);
		return;
	}


	[ActionTitle("Set State")]
	[ActionDescription("Sets the state of given enum to another difficulty")]
	public static void setState(Difficulty component, Difficulties level, string type){

		switch (type) {
		case "easy":
			component.level = Difficulties.Easy;
			break;
		case "medium":
			component.level = Difficulties.Medium;
			break;
		case "hard":
			component.level = Difficulties.Hard;
			break;
		default:
			component.level = Difficulties.Easy;
			break;
		}
	}
}

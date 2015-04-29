using UnityEngine;
using System.Collections;

public class BasicUI : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		GUI.skin.label.alignment = TextAnchor.MiddleCenter;
		GUI.skin.label.fontSize = 30;
		GUI.Label (new Rect (0, 0, Screen.width, Screen.height), "Test Successful");
		GUI.Label (new Rect (0, -100, Screen.width, Screen.height), "Test 1 Snehal Successful");
		GUI.Label (new Rect (0, 200, Screen.width, Screen.height), "Test 2 Sachet Successful");

	}
}

using UnityEngine;
using System.Collections;

public class TestScripts : MonoBehaviour {

	// Use this for initialization
	void Start () {
		LoadInformation.LoadAllInformation ();
		Debug.Log("Player name: " + GameInformation.PlayerName);
		Debug.Log("Player level: " + GameInformation.PlayerLevel);
		Debug.Log("Player strength: " + GameInformation.PlayerStrength);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

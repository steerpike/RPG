using UnityEngine;
using System.Collections;

public class CreateAPlayerGUI : MonoBehaviour {


	public enum CreatePlayerStates{
		CLASSSELECTION,
		STATALLOCATION,
		FINALSETUP
	}
	private DisplayCreatePlayerFunctions displayFunctions = new DisplayCreatePlayerFunctions();
	public static CreatePlayerStates currentState;

	// Use this for initialization
	void Start () {
		currentState = CreatePlayerStates.CLASSSELECTION;
	}
	
	// Update is called once per frame
	void Update () {
		switch (currentState) {
		case(CreatePlayerStates.CLASSSELECTION):

			break;
		case(CreatePlayerStates.STATALLOCATION):
			
			break;
		case(CreatePlayerStates.FINALSETUP):
			
			break;
		}
	}
	void OnGUI() {
		displayFunctions.DisplayMainItems ();
		if (currentState == CreatePlayerStates.CLASSSELECTION) {
			displayFunctions.DisplayClassSelections();
		}
		if (currentState == CreatePlayerStates.STATALLOCATION) {
			displayFunctions.DisplayStatAllocation();
		}
		if (currentState == CreatePlayerStates.FINALSETUP) {
			displayFunctions.DisplayFinalSetup();
		}
	}
}

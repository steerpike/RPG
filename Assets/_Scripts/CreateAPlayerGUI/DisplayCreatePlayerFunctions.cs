using UnityEngine;
using System.Collections;

public class DisplayCreatePlayerFunctions {

	private int classSelection;
	private string[] classSelectionNames = new string[] {"Mage", "Warrior", "Rogue", "Cleric", "Paladin", "Warlock"};


	public void DisplayClassSelections() {
		//A list of toggle buttons where each button is a different class
		classSelection = GUI.SelectionGrid(new Rect(50,50,250, 300), classSelection, classSelectionNames, 2);
		GUI.Label (new Rect (450, 50, 300, 300), FindClassDescription(classSelection));
		GUI.Label (new Rect (450, 100, 300, 300), FindClassStatValues(classSelection));
	}
	private string FindClassDescription(int classSelection) {
		if (classSelection == 0) {
			BaseCharacterClass tempClass= new BaseMageClass();
			return tempClass.CharacterClassDescription;
		}
		if (classSelection == 1) {
			BaseCharacterClass tempClass= new BaseWarriorClass();
			return tempClass.CharacterClassDescription;
		}
		return "No class found ";
	}

	private string FindClassStatValues(int classSelection) {
		if (classSelection == 0) {
			BaseCharacterClass tempClass= new BaseMageClass();
			string tempStats = tempClass.Strength+ "\n"+tempClass.Intelligence;
			return tempStats;
		}
		return "No stats found";
	}
	public void DisplayStatAllocation() {
		//
	}
	public void DisplayFinalSetup() {

	}
	public void DisplayMainItems() {
		GUI.Label (new Rect (Screen.width / 2, 20, 250, 100), "CREATE NEW PLAYER");
	}
}

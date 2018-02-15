using UnityEngine;
using System.Collections;

public class CreateNewCharacter : MonoBehaviour {

	private BasePlayer newPlayer;
	private bool isMageClass;
	private bool isWarriorClass;
	private string playerName = "Enter a name";
	// Use this for initialization
	void Start () {
		newPlayer = new BasePlayer ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI() {
		playerName = GUILayout.TextArea (playerName, 15);
		isMageClass = GUILayout.Toggle (isMageClass, "Mage Class");
		isWarriorClass = GUILayout.Toggle (isWarriorClass, "Warrior Class");
		if (GUILayout.Button ("Create")) {
			if(isMageClass) {
				newPlayer.PlayerClass = new BaseMageClass();
			} else if(isWarriorClass) {
				newPlayer.PlayerClass = new BaseWarriorClass();
			}
			CreateNewPlayer();
			Debug.Log("Player name: " + newPlayer.PlayerName);
			Debug.Log("Player class: " + newPlayer.PlayerClass.CharacterClassName);
			Debug.Log("Player level: " + newPlayer.PlayerLevel);
			Debug.Log("Player strength: " + newPlayer.Strength);
			Debug.Log("Player gold: " + newPlayer.Gold);
			Debug.Log("Player resistance: " + newPlayer.Resistance);
			StoreNewPlayerInformation();
			SaveInformation.SaveAllInformation();
		}
		if (GUILayout.Button ("Load")) {
			Application.LoadLevel("test");
		}
	}
	private void StoreNewPlayerInformation() {
		GameInformation.PlayerName = newPlayer.PlayerName;
		GameInformation.PlayerLevel = newPlayer.PlayerLevel;
		GameInformation.PlayerStrength = newPlayer.Strength;
		GameInformation.PlayerIntelligence = newPlayer.Intelligence;
		GameInformation.PlayerFaith = newPlayer.Faith;
		GameInformation.PlayerAgility = newPlayer.Agility;
		GameInformation.PlayerResistance = newPlayer.Resistance;
		GameInformation.PlayerGold = newPlayer.Gold;
	}
	private void CreateNewPlayer() {
		newPlayer.PlayerLevel = 1;
		newPlayer.PlayerName = playerName;
		newPlayer.Strength = newPlayer.PlayerClass.Strength;
		newPlayer.Intelligence = newPlayer.PlayerClass.Intelligence;
		newPlayer.Faith = newPlayer.PlayerClass.Faith;
		newPlayer.Agility = newPlayer.PlayerClass.Agility;
		newPlayer.Resistance = newPlayer.PlayerClass.Resistance;
		newPlayer.Gold = 10;
	}
}

using UnityEngine;
using System.Collections;

public class SaveInformation {

	public static void SaveAllInformation() {
		PlayerPrefs.SetString ("PLAYERNAME", GameInformation.PlayerName);
		PlayerPrefs.SetInt ("PLAYERLEVEL", GameInformation.PlayerLevel);
		PlayerPrefs.SetInt ("PLAYERSTRENGTH", GameInformation.PlayerStrength);
		PlayerPrefs.SetInt ("PLAYERINTELLIGENCE", GameInformation.PlayerIntelligence);
		PlayerPrefs.SetInt ("PLAYERFAITH", GameInformation.PlayerFaith);
		PlayerPrefs.SetInt ("PLAYERAGILITY", GameInformation.PlayerAgility);
		if (GameInformation.EquipmentOne != null) {
			PPSerialisation.Save ("EQUIPMENTITEM1", GameInformation.EquipmentOne);
		}
		Debug.Log ("INFORMATION SAVED");
	}
}

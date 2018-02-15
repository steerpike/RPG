using UnityEngine;
using System.Collections;

public class LoadInformation {

	public static void LoadAllInformation() {
		GameInformation.PlayerName = PlayerPrefs.GetString ("PLAYERNAME");
		GameInformation.PlayerLevel = PlayerPrefs.GetInt ("PLAYERLEVEL");
		GameInformation.PlayerStrength = PlayerPrefs.GetInt ("PLAYERSTRENGTH");
		GameInformation.PlayerIntelligence = PlayerPrefs.GetInt ("PLAYERINTELLIGENCE");
		GameInformation.PlayerFaith = PlayerPrefs.GetInt ("PLAYERFAITH");
		GameInformation.PlayerAgility = PlayerPrefs.GetInt ("PLAYERAGILITY");
		GameInformation.PlayerResistance = PlayerPrefs.GetInt ("PLAYERRESISTANCE");
		GameInformation.PlayerGold = PlayerPrefs.GetInt ("PLAYERGOLD");
		if (PlayerPrefs.GetString ("EQUIPMENTITEM1") != null) {
			GameInformation.EquipmentOne = (BaseEquipment)PPSerialisation.Load("EQUIPMENTITEM1");
		}
	}
}

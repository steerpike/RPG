using UnityEngine;
using System.Collections;

public static class IncreaseExperience {
	private static int xpToGive;
	private static LevelUp levelUpScript = new LevelUp();

	public static void AddExperience() {
		xpToGive = GameInformation.PlayerLevel * 100;
		GameInformation.CurrentXP += xpToGive;
		CheckLevelIncrease ();
		Debug.Log (xpToGive);
	}
	private static void CheckLevelIncrease() {
		if (GameInformation.CurrentXP >= GameInformation.RequiredXP) {
			//Level up player
			levelUpScript.LevelUpCharacter();
		}
	}
}

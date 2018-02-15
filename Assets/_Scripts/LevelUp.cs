using UnityEngine;
using System.Collections;

public class LevelUp  {

	public int maxPlayerLevel = 50;

	public void LevelUpCharacter() {
		//check to see if current xp is greater than required
		if (GameInformation.CurrentXP >= GameInformation.RequiredXP) {
			GameInformation.CurrentXP -= GameInformation.RequiredXP;
		} else {
			GameInformation.CurrentXP = 0;
		}
		if (GameInformation.PlayerLevel < maxPlayerLevel) {
			GameInformation.PlayerLevel += 1;
		} else {
			GameInformation.PlayerLevel = maxPlayerLevel;
		}
		DetermineRequiredXP ();
	}
	private void DetermineRequiredXP() {
		int temp = (GameInformation.PlayerLevel * 1000) + 250;
		GameInformation.RequiredXP = temp;
	}
}

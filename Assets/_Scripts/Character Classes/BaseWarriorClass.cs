using UnityEngine;
using System.Collections;

public class BaseWarriorClass : BaseCharacterClass {

	public  BaseWarriorClass() {
		CharacterClassName = "Warrior";
		CharacterClassDescription = "A strong and powerful fighter.";
		Strength = 15;
		Intelligence = 5;
		Faith = 5;
		Agility = 10;
		Resistance = 8;
	}
}

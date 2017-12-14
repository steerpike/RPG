using UnityEngine;
using System.Collections;

public class BaseMageClass : BaseCharacterClass {
	
	public  BaseMageClass() {
		CharacterClassName = "Mage";
		CharacterClassDescription = "A wise and deadly spellcaster.";
		Strength = 5;
		Intelligence = 15;
		Faith = 8;
		Agility = 8;
	}
}
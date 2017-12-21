using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseEquipment : BaseStatItem {
	public enum EquipmentTypes {
		HELMET,
		CLOAK,
		BREASTPLATE,
		BOOTS,
		RING,
		NECKLACE
	}
	private EquipmentTypes equipmentType;
	private int spellEffectID;
	
	public EquipmentTypes EquipmentType {
		get{return equipmentType;}
		set{equipmentType=value;}
	}
	public int SpellEffectID {
		get{return spellEffectID;}
		set{spellEffectID = value;}
	}
}
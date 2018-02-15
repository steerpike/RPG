using UnityEngine;
using System.Collections;

public class BaseCharacterClass  {
	private string characterClassName;
	private string characterClassDescription;
	private int strength;
	private int intelligence;
	private int faith;
	private int agility;
	private int resistance;

	public string CharacterClassName {
		get{return characterClassName;}
		set{characterClassName = value;}
	}
	public string CharacterClassDescription {
		get{return characterClassDescription;}
		set{characterClassDescription = value;}
	}
	public int Strength {
		get{return strength;}
		set{strength = value;}
	}
	public int Intelligence {
		get{return intelligence;}
		set{intelligence = value;}
	}
	public int Faith {
		get{return faith;}
		set{faith = value;}
	}
	public int Agility {
		get{return agility;}
		set{agility = value;}
	}
	public int Resistance {
		get{return resistance;}
		set{resistance = value;}
	}
}

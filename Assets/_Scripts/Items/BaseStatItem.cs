using UnityEngine;
using System.Collections;

public class BaseStatItem : BaseItem {

	private int strength;
	private int intelligence;
	private int faith;
	private int agility;
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
}

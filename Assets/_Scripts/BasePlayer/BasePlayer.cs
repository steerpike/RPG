using UnityEngine;
using System.Collections;

public class BasePlayer {

	private string playerName;
	private int playerLevel;
	private BaseCharacterClass playerClass;
	private int strength;
	private int intelligence;
	private int faith;
	private int agility;
	/*
	public string PlayerName {
		get{ return playerName; }
		set{ playerName = value; }
	}*/
	public string PlayerName{ get; set;}

	public int PlayerLevel {
		get{ return playerLevel; }
		set{ playerLevel = value; }
	}
	public BaseCharacterClass PlayerClass {
		get{ return playerClass; }
		set{ playerClass = value; }
	}
	public int Strength {
		get{ return strength; }
		set{ strength = value; }
	}
	public int Intelligence {
		get{ return intelligence; }
		set{ intelligence = value; }
	}
	public int Faith {
		get{ return faith; }
		set{ faith = value; }
	}
	public int Agility {
		get{ return agility; }
		set{ agility = value; }
	}
}

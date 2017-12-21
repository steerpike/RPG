using UnityEngine;
using System.Collections;

public class GameInformation : MonoBehaviour {

	void Awake() {
		DontDestroyOnLoad (transform.gameObject);
	}
	public static BaseEquipment EquipmentOne{ get; set;}
	public static string PlayerName{ get; set;}
	public static int PlayerLevel{ get; set;}
	public static string PlayerClass{ get; set;}
	public static int PlayerStrength{ get; set;}
	public static int PlayerIntelligence{ get; set;}
	public static int PlayerFaith{ get; set;}
	public static int PlayerAgility{ get; set;}
}

using UnityEngine;
using System.Collections;

public class CreateNewEquipment : MonoBehaviour {

	private BaseEquipment newEquipment;
	private string[] itemNames = new string[4]{"Common", "Great", "Amazing", "Legendary"};
	// Use this for initialization
	void Start () {
	
	}
	private void ChooseItemName() {
		newEquipment.ItemName = itemNames [Random.Range (0, 3)] + " ITem";
	}
	private void CreateEquipment() {
		newEquipment = new BaseEquipment ();
	}
	void ChooseItemType() {
	
	}
	// Update is called once per frame
	void Update () {
	
	}
}

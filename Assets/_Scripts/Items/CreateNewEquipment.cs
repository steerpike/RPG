using UnityEngine;
using System.Collections;

public class CreateNewEquipment : MonoBehaviour {

	private BaseEquipment newEquipment;
	private string[] itemNames = new string[4]{"Common", "Great", "Amazing", "Legendary"};
	// Use this for initialization
	void Start () {
		CreateEquipment ();
		Debug.Log (newEquipment.ItemName);
		Debug.Log (newEquipment.ItemDescription);
		Debug.Log (newEquipment.EquipmentType.ToString());
	}

	private void CreateEquipment() {
		newEquipment = new BaseEquipment ();
		newEquipment.ItemName = itemNames [Random.Range (0, 3)] + " Item";
		newEquipment.ItemID = Random.Range (1, 101);

		newEquipment.ItemDescription = "This is a new piece of equipment.";
		newEquipment.Strength = Random.Range(1,10);
		newEquipment.Intelligence = Random.Range(1,10);
		newEquipment.Faith = Random.Range(1,10);
		newEquipment.Agility = Random.Range(1,10);

		ChooseItemType ();
	}
	void ChooseItemType() {
		int randomTemp = Random.Range (1, 6);
		if (randomTemp == 1) {
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.HELMET;
		} else if (randomTemp == 2) {
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.CLOAK;
		} else if (randomTemp == 3) {
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.BREASTPLATE;
		} else if (randomTemp == 4) {
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.BOOTS;
		} else if (randomTemp == 5) {
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.RING;
		} else if (randomTemp == 6) {
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.NECKLACE;
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}

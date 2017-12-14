using UnityEngine;
using System.Collections;

public class CreateNewWeapon : MonoBehaviour {

	private BaseWeapon newWeapon;

	public void CreateWeapon() {
		newWeapon = new BaseWeapon ();
		newWeapon.ItemName = "W" + Random.Range (1, 101);
		newWeapon.ItemDescription = "This is a new weapon.";
		newWeapon.ItemID = Random.Range (1,101);
		newWeapon.Strength = Random.Range(1,10);
		newWeapon.Intelligence = Random.Range(1,10);
		newWeapon.Faith = Random.Range(1,10);
		newWeapon.Agility = Random.Range(1,10);

	}
	private void ChooseWeaponType() {
		int randomTemp = Random.Range (1,7);
	}
}

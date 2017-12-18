using UnityEngine;
using System.Collections;

public class CreateNewWeapon : MonoBehaviour {

	private BaseWeapon newWeapon;
	/*
	public void Start() {
		CreateWeapon ();
		Debug.Log (newWeapon.ItemName);
		Debug.Log (newWeapon.WeaponType.ToString());
	}
	*/

	public void CreateWeapon() {
		newWeapon = new BaseWeapon ();
		newWeapon.ItemName = "W" + Random.Range (1, 101);
		newWeapon.ItemDescription = "This is a new weapon.";
		newWeapon.ItemID = Random.Range (1,101);
		newWeapon.Strength = Random.Range(1,10);
		newWeapon.Intelligence = Random.Range(1,10);
		newWeapon.Faith = Random.Range(1,10);
		newWeapon.Agility = Random.Range(1,10);
		ChooseWeaponType ();
		newWeapon.SpellEffectID = Random.Range (1, 101);

	}
	private void ChooseWeaponType() {
		int randomTemp = Random.Range (1,5);
		if (randomTemp == 1) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;
		} else if (randomTemp == 2) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.STAFF;
		} else if (randomTemp == 3) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.DAGGER;
		} else if (randomTemp == 4) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.MACE;
		} else if (randomTemp == 5) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
		}
	}
}

﻿using UnityEngine;
using System.Collections;

public class projectile : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D coll){
		GameObject.Destroy (this.gameObject);
		//Debug.Log (coll.gameObject.transform.parent.name);

		Rigidbody2D rbTouche = coll.gameObject.GetComponent <Rigidbody2D>();
		if (coll.gameObject.transform.parent) {
			if (coll.gameObject.transform.parent.name == "mesEnnemis") {
				rbTouche.SendMessageUpwards ("Toucher", 1, SendMessageOptions.RequireReceiver);
			}
		}
	}
}

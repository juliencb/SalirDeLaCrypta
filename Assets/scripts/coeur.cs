using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class coeur : MonoBehaviour {

	public Text txtnbVies;

	// http://answers.unity3d.com/questions/42843/referencing-non-static-variables-from-another-scri.html
	// pour aller chercher la variable d'un script d'un autre gameObject

	void OnCollisionEnter2D (Collision2D coll){
		personnage playerScript = coll.gameObject.GetComponent<personnage> ();
		if (playerScript.nbVie < playerScript.nbVieMax) {
			if(coll.gameObject.transform.parent.name == "Perso"){
				playerScript.nbVie++;
				playerScript.txtnbVies.text = playerScript.nbVie.ToString();
				GameObject.Destroy (this.gameObject);
			}
		}
	}
}


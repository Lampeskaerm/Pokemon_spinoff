using UnityEngine;
using System.Collections;

public class PlayerCollisionDetection : MonoBehaviour {

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Enemy") {
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}

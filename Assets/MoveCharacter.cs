using UnityEngine;
using System.Collections;

public class MoveCharacter : MonoBehaviour {
	int moveSpeed = 10;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.DownArrow)) {
			transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			transform.Rotate(Vector3.up * moveSpeed * 20 * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.Rotate (-Vector3.up * moveSpeed * 20 * Time.deltaTime);
		}
	}
}

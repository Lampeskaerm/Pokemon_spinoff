using UnityEngine;
using System.Collections;

public class CameraFollowing : MonoBehaviour {
	Transform target;
	float zdistance = 10f, ydistance = 2f;

	void Start(){
		target = GameObject.FindWithTag("Player").transform;
	}
	void LateUpdate(){
				
		transform.position = new Vector3(target.position.x, target.position.y + ydistance, target.position.z - zdistance);
		
	}
}

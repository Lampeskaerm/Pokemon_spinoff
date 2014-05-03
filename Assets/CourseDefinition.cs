using UnityEngine;
using System.Collections;

public class CourseDefinition : MonoBehaviour {
	float zfloorTile = 10f, yfloorTile = 0.1f, xfloorTile = 10f;
	float zenemy = 5f, yenemy = 5f, xenemy = 5f;
	LoadCourse lc = new LoadCourse();
	ArrayList course;
	public Transform floorTile, enemy;

	// Use this for initialization
	void Start () {
		loadCourse ();
		createCourse ();
	}
	
	void loadCourse(){
		course = lc.getCourse();
	}

	void createCourse(){
		float counter1;
		int counter2 = 0;
		foreach(string str in course) {
			counter1 = 0f;
			foreach(char c in str){
				if(c == '#'){
					Transform t = Instantiate(floorTile, new Vector3(counter2*xfloorTile, yfloorTile, counter1*zfloorTile), Quaternion.identity) as Transform;
					GameObject tile = t.gameObject;
					tile.renderer.material.color = Color.red;
				} else if(c == 'E'){
					Transform t = Instantiate(floorTile, new Vector3(counter2*xfloorTile, yfloorTile, counter1*zfloorTile), Quaternion.identity) as Transform;
					GameObject tile = t.gameObject;
					tile.renderer.material.color = Color.red;

					t = Instantiate(enemy, new Vector3(counter2*xenemy, yenemy+(tile.renderer.bounds.size.y), counter1*zenemy), Quaternion.identity) as Transform;
					GameObject enemySquare = t.gameObject;
					enemy.renderer.material.color = Color.green;
				}
				counter1++;
			}
			counter2++;
		}
	}
}

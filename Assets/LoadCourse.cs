using UnityEngine;
using System.Collections;
using System.IO;

public class LoadCourse {
	StreamReader streamReader = new StreamReader("C:\\Users\\Anne-Katrine Binder\\Documents\\Pokemon_spinoff\\test.txt");
	ArrayList course = new ArrayList();
	
	// Update is called once per frame
	public LoadCourse () {
		string line;
		while ((line = streamReader.ReadLine()) != null) {
			course.Add (line);
		}
		streamReader.Close ();
	}
	
	public ArrayList getCourse(){
		return course;
	}
}

using UnityEngine;

public class changeColor : MonoBehaviour {
	void Update () {
		if(Input.GetKeyDown(KeyCode.R)) {
			GetComponent<Renderer>().material.color = Color.red;
		}
		if(Input.GetKeyDown(KeyCode.B)) {
			GetComponent<Renderer>().material.color = Color.blue;
		}
		if(Input.GetKeyDown(KeyCode.G)) {
			GetComponent<Renderer>().material.color = Color.green;
		}
	}
}
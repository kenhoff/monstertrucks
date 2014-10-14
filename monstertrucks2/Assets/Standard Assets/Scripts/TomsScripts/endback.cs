using UnityEngine;
using System.Collections;

public class endback : MonoBehaviour {
	public string load;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
	if (Event.current.Equals(Event.KeyboardEvent("end"))) {
			Application.LoadLevel(load);
        	}
	}
}

using UnityEngine;
using System.Collections;

public class endscreen : MonoBehaviour {
public string mainMenu;
	void OnGUI(){
		int score = PlayerPrefs.GetInt("round score");
				
			GUI.BeginGroup(new Rect(Screen.width / 2 - 200, Screen.height / 2 - 200, 400, 400));
			GUI.contentColor = Color.white;
			GUI.Box (new Rect(0,0,400,200), "Round Summary");
			GUI.skin.GetStyle("Label").alignment = TextAnchor.MiddleCenter;
			GUI.contentColor = Color.red;
			GUI.Label(new Rect(5,5,390,190),
				"Round Score: "+ score + "\n"+
				"Cash Earned: "+ (score * .1)+
				"\nPress Enter");
			GUI.EndGroup();
			if (Event.current.Equals(Event.KeyboardEvent("return"))) {
			Application.LoadLevel(mainMenu);
        	}
}
}

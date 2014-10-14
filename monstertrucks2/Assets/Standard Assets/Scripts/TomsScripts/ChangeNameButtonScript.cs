using UnityEngine; 
using System.Collections;

public class ChangeNameButtonScript : MonoBehaviour {
	
public AudioClip Soundhover;
public AudioClip ClickSound;
public string title;
public string changeString;
public bool guiOn;
public Font font;

void OnStart(){
		changeString = PlayerPrefs.GetString(title);
	}

public void OnMouseEnter ()
{
    audio.PlayOneShot(Soundhover); 
	renderer.material.color = Color.red;
}

public void OnMouseExit ()
{
	renderer.material.color = Color.black;
}

public void OnMouseUp ()
	{
	renderer.material.color = Color.black;
		
    audio.PlayOneShot(ClickSound);
		guiOn = true;
		GameObject.Find("Main Camera").GetComponent<MouseLook>().enabled = false;
	
}

void OnGUI(){
		if(guiOn){
			
			if (Event.current.Equals(Event.KeyboardEvent("return"))) {
				if(changeString.Length == 0)
					changeString = PlayerPrefs.GetString(title);
				PlayerPrefs.SetString(title, changeString);
				GameObject.Find("Main Camera").GetComponent<MouseLook>().enabled = true;
				guiOn = false;
			}
			if (Event.current.Equals(Event.KeyboardEvent("end"))) {
				GameObject.Find("Main Camera").GetComponent<MouseLook>().enabled = true;
				guiOn = false;
			}
			GUI.skin.font = font;
			GUI.BeginGroup(new Rect(Screen.width / 2 - 200, Screen.height / 2 - 200, 400, 400));
			GUI.contentColor = Color.white;
			GUI.Box (new Rect(0,0,400,200), "Change "+ title);
			GUI.skin.GetStyle("Label").alignment = TextAnchor.MiddleCenter;
			GUI.contentColor = Color.red;
			GUI.SetNextControlName("TextField");
			changeString = GUI.TextField(new Rect(5,30,390,30),changeString, 24);
			GUI.FocusControl("TextField");
			GUI.contentColor = Color.red;
			GUI.Label(new Rect(5,50,390,145),
				"Press Enter to Save \n" +
				"Press End to Cancel");
			GUI.EndGroup();

		}
}
}
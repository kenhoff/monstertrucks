using UnityEngine;
using System.Collections;

public class NguiDisplayScript : MonoBehaviour {
public string title;
public bool isString;
public bool cash;
public bool isFloat;
public bool isInt;
	
void Update(){
    if(isString){
			this.GetComponent<TextMesh>().text = title + ": "+ PlayerPrefs.GetString(title);
		}
	else if(cash){
			this.GetComponent<TextMesh>().text = title + ": $"+ PlayerPrefs.GetInt(title);
		}
	else if(isFloat){
			this.GetComponent<TextMesh>().text = title + ": "+ PlayerPrefs.GetFloat(title).ToString("F1");
		}
	else if(isInt){
			this.GetComponent<TextMesh>().text = title + ": "+ PlayerPrefs.GetInt(title);
		}
	}
}


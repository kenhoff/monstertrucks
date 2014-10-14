using UnityEngine; 
using System.Collections;

public class ResetPlayerStatsScript : MonoBehaviour {
	
public AudioClip Soundhover;
public AudioClip ClickSound;
public string title;
public string changeString;
public bool guiOn;
public Font font;

public Color bodyColor;
public Color outlineColor;
public Color tintColor;
public Material body;
public Material tint;

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
			GUI.skin.font = font;
			GUI.BeginGroup(new Rect(Screen.width / 2 - 200, Screen.height / 2 - 200, 400, 400));
			GUI.contentColor = Color.white;
			GUI.Box (new Rect(0,0,400,400), "Reset Player Stats?");
			GUI.skin.GetStyle("Label").alignment = TextAnchor.MiddleCenter;
			GUI.contentColor = Color.red;
			GUI.Label(new Rect(5,45,390,350),
				"!!!WARNING!!! \n\n" +
				"THERE IS NO GOING BACK! \n\n" +
				"Press Home to Reset \n\n " +
				"Press Enter to Cancel");
			if (Event.current.Equals(Event.KeyboardEvent("return"))) {
				GameObject.Find("Main Camera").GetComponent<MouseLook>().enabled = true;
				guiOn = false;
			}
			if (Event.current.Equals(Event.KeyboardEvent("home"))) {
//Player Specific Info
PlayerPrefs.SetString("Player Name", "Mystery Driver");
PlayerPrefs.SetInt("Cash", 0);
PlayerPrefs.SetInt("Highest Score - Round", 0);
PlayerPrefs.SetInt("Total Score", 0);
		
//Player Truck Info
PlayerPrefs.SetString("Truck Name", "Mayhem");
PlayerPrefs.SetInt("SpeedInt", 27);
PlayerPrefs.SetInt("HandlingInt", 27);
PlayerPrefs.SetInt("WeightInt", 49);
PlayerPrefs.SetInt("StyleInt", 1);
Debug.Log("This is what Style is before float: " + PlayerPrefs.GetInt("Style"));

float speedFloat = (float)PlayerPrefs.GetInt("SpeedInt");
float handlingFloat = (float)PlayerPrefs.GetInt("HandlingInt");
float weightFloat = (float)PlayerPrefs.GetInt("WeightInt");
float styleFloat = (float)PlayerPrefs.GetInt("StyleInt");
				
PlayerPrefs.SetFloat("Speed", ( speedFloat / 27.0f));
PlayerPrefs.SetFloat("Handling", (handlingFloat / 27.0f));
PlayerPrefs.SetFloat("Weight", (weightFloat / 7.0f));
PlayerPrefs.SetFloat("Style", (styleFloat));

Debug.Log("This is what Style is before float: " + PlayerPrefs.GetInt("Style"));				
/*PlayerPrefs.SetFloat("Speed", 5);
PlayerPrefs.SetFloat("Handling", 5);
PlayerPrefs.SetFloat("Weight", 5);
PlayerPrefs.SetFloat("Style", 5);*/

//Player Upgrades Info
PlayerPrefs.SetInt("Body Paint Street Purchased", 0);
PlayerPrefs.SetInt("Body Paint Street Active", 0);
PlayerPrefs.SetInt("Body Paint Sport Purchased", 0);
PlayerPrefs.SetInt("Body Paint Sport Active", 0);
PlayerPrefs.SetInt("Body Paint Race Purchased", 0);
PlayerPrefs.SetInt("Body Paint Race Active", 0);

PlayerPrefs.SetInt("Body Detail Street Purchased", 0);
PlayerPrefs.SetInt("Body Detail Street Active", 0);
PlayerPrefs.SetInt("Body Detail Sport Purchased", 0);
PlayerPrefs.SetInt("Body Detail Sport Active", 0);
PlayerPrefs.SetInt("Body Detail Race Purchased", 0);
PlayerPrefs.SetInt("Body Detail Race Active", 0);

PlayerPrefs.SetInt("Window Tint Street Purchased", 0);
PlayerPrefs.SetInt("Window Tint Street Active", 0);
PlayerPrefs.SetInt("Window Tint Sport Purchased", 0);
PlayerPrefs.SetInt("Window Tint Sport Active", 0);
PlayerPrefs.SetInt("Window Tint Race Purchased", 0);
PlayerPrefs.SetInt("Window Tint Race Active", 0);

PlayerPrefs.SetInt("Air Filter Street Purchased", 0);
PlayerPrefs.SetInt("Air Filter Street Active", 0);
PlayerPrefs.SetInt("Air Filter Sport Purchased", 0);
PlayerPrefs.SetInt("Air Filter Sport Active", 0);
PlayerPrefs.SetInt("Air Filter Race Purchased", 0);
PlayerPrefs.SetInt("Air Filter Race Active", 0);
		
PlayerPrefs.SetInt("Camshaft Street Purchased", 0);
PlayerPrefs.SetInt("Camshaft Street Active", 0);
PlayerPrefs.SetInt("Camshaft Sport Purchased", 0);
PlayerPrefs.SetInt("Camshaft Sport Active", 0);
PlayerPrefs.SetInt("Camshaft Race Purchased", 0);
PlayerPrefs.SetInt("Camshaft Race Active", 0);
		
PlayerPrefs.SetInt("Displacement Street Purchased", 0);
PlayerPrefs.SetInt("Displacement Street Active", 0);
PlayerPrefs.SetInt("Displacement Sport Purchased", 0);
PlayerPrefs.SetInt("Displacement Sport Active", 0);
PlayerPrefs.SetInt("Displacement Race Purchased", 0);
PlayerPrefs.SetInt("Displacement Race Active", 0);

PlayerPrefs.SetInt("Exhaust Street Purchased", 0);
PlayerPrefs.SetInt("Exhaust Street Active", 0);
PlayerPrefs.SetInt("Exhaust Sport Purchased", 0);
PlayerPrefs.SetInt("Exhaust Sport Active", 0);
PlayerPrefs.SetInt("Exhaust Race Purchased", 0);
PlayerPrefs.SetInt("Exhaust Race Active", 0);
		
PlayerPrefs.SetInt("Fuel Street Purchased", 0);
PlayerPrefs.SetInt("Fuel Street Active", 0);
PlayerPrefs.SetInt("Fuel Sport Purchased", 0);
PlayerPrefs.SetInt("Fuel Sport Active", 0);
PlayerPrefs.SetInt("Fuel Race Purchased", 0);
PlayerPrefs.SetInt("Fuel Race Active", 0);
		
PlayerPrefs.SetInt("Ignition Street Purchased", 0);
PlayerPrefs.SetInt("Ignition Street Active", 0);
PlayerPrefs.SetInt("Ignition Sport Purchased", 0);
PlayerPrefs.SetInt("Ignition Sport Active", 0);
PlayerPrefs.SetInt("Ignition Race Purchased", 0);
PlayerPrefs.SetInt("Ignition Race Active", 0);
		
PlayerPrefs.SetInt("IntakeManifold Street Purchased", 0);
PlayerPrefs.SetInt("IntakeManifold Street Active", 0);
PlayerPrefs.SetInt("IntakeManifold Sport Purchased", 0);
PlayerPrefs.SetInt("IntakeManifold Sport Active", 0);
PlayerPrefs.SetInt("IntakeManifold Race Purchased", 0);
PlayerPrefs.SetInt("IntakeManifold Race Active", 0);
		
PlayerPrefs.SetInt("Piston Street Purchased", 0);
PlayerPrefs.SetInt("Piston Street Active", 0);
PlayerPrefs.SetInt("Piston Sport Purchased", 0);
PlayerPrefs.SetInt("Piston Sport Active", 0);
PlayerPrefs.SetInt("Piston Race Purchased", 0);
PlayerPrefs.SetInt("Piston Race Active", 0);
		
PlayerPrefs.SetInt("SuperCharger Street Purchased", 0);
PlayerPrefs.SetInt("SuperCharger Street Active", 0);
PlayerPrefs.SetInt("SuperCharger Sport Purchased", 0);
PlayerPrefs.SetInt("SuperCharger Sport Active", 0);
PlayerPrefs.SetInt("SuperCharger Race Purchased", 0);
PlayerPrefs.SetInt("SuperCharger Race Active", 0);
		
PlayerPrefs.SetInt("RollCage Street Purchased", 0);
PlayerPrefs.SetInt("RollCage Street Active", 0);
PlayerPrefs.SetInt("RollCage Sport Purchased", 0);
PlayerPrefs.SetInt("RollCage Sport Active", 0);
PlayerPrefs.SetInt("RollCage Race Purchased", 0);
PlayerPrefs.SetInt("RollCage Race Active", 0);
		
PlayerPrefs.SetInt("Spoiler Street Purchased", 0);
PlayerPrefs.SetInt("Spoiler Street Active", 0);
PlayerPrefs.SetInt("Spoiler Sport Purchased", 0);
PlayerPrefs.SetInt("Spoiler Sport Active", 0);
PlayerPrefs.SetInt("Spoiler Race Purchased", 0);
PlayerPrefs.SetInt("Spoiler Race Active", 0);

PlayerPrefs.SetInt("Suspension Street Purchased", 0);
PlayerPrefs.SetInt("Suspension Street Active", 0);
PlayerPrefs.SetInt("Suspension Sport Purchased", 0);
PlayerPrefs.SetInt("Suspension Sport Active", 0);
PlayerPrefs.SetInt("Suspension Race Purchased", 0);
PlayerPrefs.SetInt("Suspension Race Active", 0);
		
PlayerPrefs.SetInt("Tires Street Purchased", 0);
PlayerPrefs.SetInt("Tires Street Active", 0);
PlayerPrefs.SetInt("Tires Sport Purchased", 0);
PlayerPrefs.SetInt("Tires Sport Active", 0);
PlayerPrefs.SetInt("Tires Race Purchased", 0);
PlayerPrefs.SetInt("Tires Race Active", 0);
		
PlayerPrefs.SetInt("WeightReduction Street Purchased", 0);
PlayerPrefs.SetInt("WeightReduction Street Active", 0);
PlayerPrefs.SetInt("WeightReduction Sport Purchased", 0);
PlayerPrefs.SetInt("WeightReduction Sport Active", 0);
PlayerPrefs.SetInt("WeightReduction Race Purchased", 0);
PlayerPrefs.SetInt("WeightReduction Race Active", 0);
				
body.SetColor("_OutlineColor", outlineColor);
body.SetColor("_Color", bodyColor);
tint.SetColor ("_Color", tintColor);
					

				GameObject.Find("Main Camera").GetComponent<MouseLook>().enabled = true;
				guiOn = false;
			}
			
			GUI.EndGroup();
		}
}
}
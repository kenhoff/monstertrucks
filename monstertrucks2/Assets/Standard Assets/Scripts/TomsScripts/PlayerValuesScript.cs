using UnityEngine;
using System.Collections;

public class PlayerValuesScript : MonoBehaviour {
void OnStart(){

Debug.Log ("This is loading on beginning of game");
	
//Player Specific Info
PlayerPrefs.GetString("Player Name", "Mystery Driver");
PlayerPrefs.GetInt("Cash", 0);
PlayerPrefs.GetInt("Highest Score - Round", 0);
PlayerPrefs.GetInt("Total Score", 0);
		
//Player Truck Info
PlayerPrefs.GetString("Truck Name", "Mayhem");
PlayerPrefs.SetInt("SpeedInt", 27);
PlayerPrefs.SetInt("HandlingInt", 27);
PlayerPrefs.SetInt("WeightInt", 49);
PlayerPrefs.SetInt("StyleInt", 1);
		
Debug.Log("This is what Speed is before float: " + PlayerPrefs.GetInt("StyleInt"));
Debug.Log("This is what Handling is before float: " + PlayerPrefs.GetInt("HandlingInt"));
Debug.Log("This is what Weight is before float: " + PlayerPrefs.GetInt("WeightInt"));
Debug.Log("This is what Style is before float: " + PlayerPrefs.GetInt("StyleInt"));

float speedFloat = (float)PlayerPrefs.GetInt("SpeedInt");
float handlingFloat = (float)PlayerPrefs.GetInt("HandlingInt");
float weightFloat = (float)PlayerPrefs.GetInt("WeightInt");
float styleFloat = (float)PlayerPrefs.GetInt("StyleInt");
				
PlayerPrefs.SetFloat("Speed", ( speedFloat / 27.0f));
PlayerPrefs.SetFloat("Handling", (handlingFloat / 27.0f));
PlayerPrefs.SetFloat("Weight", (weightFloat / 7.0f));
PlayerPrefs.SetFloat("Style", (styleFloat));
		
Debug.Log("This is what Speed is after float: " + PlayerPrefs.GetInt("Style"));
Debug.Log("This is what Handling is after float: " + PlayerPrefs.GetInt("Handling"));
Debug.Log("This is what Weight is after float: " + PlayerPrefs.GetInt("Weight"));
Debug.Log("This is what Style is after float: " + PlayerPrefs.GetInt("Style"));

		
//Player Upgrades Info
PlayerPrefs.GetInt("Body Paint Street Purchased", 0);
PlayerPrefs.GetInt("Body Paint Street Active", 0);
PlayerPrefs.GetInt("Body Paint Sport Purchased", 0);
PlayerPrefs.GetInt("Body Paint Sport Active", 0);
PlayerPrefs.GetInt("Body Paint Race Purchased", 0);
PlayerPrefs.GetInt("Body Paint Race Active", 0);

PlayerPrefs.GetInt("Body Detail Street Purchased", 0);
PlayerPrefs.GetInt("Body Detail Street Active", 0);
PlayerPrefs.GetInt("Body Detail Sport Purchased", 0);
PlayerPrefs.GetInt("Body Detail Sport Active", 0);
PlayerPrefs.GetInt("Body Detail Race Purchased", 0);
PlayerPrefs.GetInt("Body Detail Race Active", 0);

PlayerPrefs.GetInt("Window Tint Street Purchased", 0);
PlayerPrefs.GetInt("Window Tint Street Active", 0);
PlayerPrefs.GetInt("Window Tint Sport Purchased", 0);
PlayerPrefs.GetInt("Window Tint Sport Active", 0);
PlayerPrefs.GetInt("Window Tint Race Purchased", 0);
PlayerPrefs.GetInt("Window Tint Race Active", 0);		
	
PlayerPrefs.GetInt("Air Filter Street Purchased", 0);
PlayerPrefs.GetInt("Air Filter Street Active", 0);
PlayerPrefs.GetInt("Air Filter Sport Purchased", 0);
PlayerPrefs.GetInt("Air Filter Sport Active", 0);
PlayerPrefs.GetInt("Air Filter Race Purchased", 0);
PlayerPrefs.GetInt("Air Filter Race Active", 0);
		
PlayerPrefs.GetInt("Camshaft Street Purchased", 0);
PlayerPrefs.GetInt("Camshaft Street Active", 0);
PlayerPrefs.GetInt("Camshaft Sport Purchased", 0);
PlayerPrefs.GetInt("Camshaft Sport Active", 0);
PlayerPrefs.GetInt("Camshaft Race Purchased", 0);
PlayerPrefs.GetInt("Camshaft Race Active", 0);
		
PlayerPrefs.GetInt("Displacement Street Purchased", 0);
PlayerPrefs.GetInt("Displacement Street Active", 0);
PlayerPrefs.GetInt("Displacement Sport Purchased", 0);
PlayerPrefs.GetInt("Displacement Sport Active", 0);
PlayerPrefs.GetInt("Displacement Race Purchased", 0);
PlayerPrefs.GetInt("Displacement Race Active", 0);

PlayerPrefs.GetInt("Exhaust Street Purchased", 0);
PlayerPrefs.GetInt("Exhaust Street Active", 0);
PlayerPrefs.GetInt("Exhaust Sport Purchased", 0);
PlayerPrefs.GetInt("Exhaust Sport Active", 0);
PlayerPrefs.GetInt("Exhaust Race Purchased", 0);
PlayerPrefs.GetInt("Exhaust Race Active", 0);
		
PlayerPrefs.GetInt("Fuel Street Purchased", 0);
PlayerPrefs.GetInt("Fuel Street Active", 0);
PlayerPrefs.GetInt("Fuel Sport Purchased", 0);
PlayerPrefs.GetInt("Fuel Sport Active", 0);
PlayerPrefs.GetInt("Fuel Race Purchased", 0);
PlayerPrefs.GetInt("Fuel Race Active", 0);
		
PlayerPrefs.GetInt("Ignition Street Purchased", 0);
PlayerPrefs.GetInt("Ignition Street Active", 0);
PlayerPrefs.GetInt("Ignition Sport Purchased", 0);
PlayerPrefs.GetInt("Ignition Sport Active", 0);
PlayerPrefs.GetInt("Ignition Race Purchased", 0);
PlayerPrefs.GetInt("Ignition Race Active", 0);
		
PlayerPrefs.GetInt("IntakeManifold Street Purchased", 0);
PlayerPrefs.GetInt("IntakeManifold Street Active", 0);
PlayerPrefs.GetInt("IntakeManifold Sport Purchased", 0);
PlayerPrefs.GetInt("IntakeManifold Sport Active", 0);
PlayerPrefs.GetInt("IntakeManifold Race Purchased", 0);
PlayerPrefs.GetInt("IntakeManifold Race Active", 0);
		
PlayerPrefs.GetInt("Piston Street Purchased", 0);
PlayerPrefs.GetInt("Piston Street Active", 0);
PlayerPrefs.GetInt("Piston Sport Purchased", 0);
PlayerPrefs.GetInt("Piston Sport Active", 0);
PlayerPrefs.GetInt("Piston Race Purchased", 0);
PlayerPrefs.GetInt("Piston Race Active", 0);
		
PlayerPrefs.GetInt("SuperCharger Street Purchased", 0);
PlayerPrefs.GetInt("SuperCharger Street Active", 0);
PlayerPrefs.GetInt("SuperCharger Sport Purchased", 0);
PlayerPrefs.GetInt("SuperCharger Sport Active", 0);
PlayerPrefs.GetInt("SuperCharger Race Purchased", 0);
PlayerPrefs.GetInt("SuperCharger Race Active", 0);
		
PlayerPrefs.GetInt("RollCage Street Purchased", 0);
PlayerPrefs.GetInt("RollCage Street Active", 0);
PlayerPrefs.GetInt("RollCage Sport Purchased", 0);
PlayerPrefs.GetInt("RollCage Sport Active", 0);
PlayerPrefs.GetInt("RollCage Race Purchased", 0);
PlayerPrefs.GetInt("RollCage Race Active", 0);
		
PlayerPrefs.GetInt("Spoiler Street Purchased", 0);
PlayerPrefs.GetInt("Spoiler Street Active", 0);
PlayerPrefs.GetInt("Spoiler Sport Purchased", 0);
PlayerPrefs.GetInt("Spoiler Sport Active", 0);
PlayerPrefs.GetInt("Spoiler Race Purchased", 0);
PlayerPrefs.GetInt("Spoiler Race Active", 0);

PlayerPrefs.GetInt("Suspension Street Purchased", 0);
PlayerPrefs.GetInt("Suspension Street Active", 0);
PlayerPrefs.GetInt("Suspension Sport Purchased", 0);
PlayerPrefs.GetInt("Suspension Sport Active", 0);
PlayerPrefs.GetInt("Suspension Race Purchased", 0);
PlayerPrefs.GetInt("Suspension Race Active", 0);
		
PlayerPrefs.GetInt("Tires Street Purchased", 0);
PlayerPrefs.GetInt("Tires Street Active", 0);
PlayerPrefs.GetInt("Tires Sport Purchased", 0);
PlayerPrefs.GetInt("Tires Sport Active", 0);
PlayerPrefs.GetInt("Tires Race Purchased", 0);
PlayerPrefs.GetInt("Tires Race Active", 0);
		
PlayerPrefs.GetInt("WeightReduction Street Purchased", 0);
PlayerPrefs.GetInt("WeightReduction Street Active", 0);
PlayerPrefs.GetInt("WeightReduction Sport Purchased", 0);
PlayerPrefs.GetInt("WeightReduction Sport Active", 0);
PlayerPrefs.GetInt("WeightReduction Race Purchased", 0);
PlayerPrefs.GetInt("WeightReduction Race Active", 0);
		
	}
}

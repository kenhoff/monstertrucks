using UnityEngine;
using System.Collections;

public class ComponentScript : MonoBehaviour {

public int partCost;
public int partSpeed;
public int partHandling;
public int partWeight;
public int partStyle;
public string name;
public string changeColorPart;
public bool isPaint;
public bool onGui;
public bool active;
public Color upgradeColor;
public Color originalColor;
public Material changeColorMaterial;

public AudioClip Soundhover;
public AudioClip ClickSound;
public AudioClip CashMachine;
public AudioClip Rejected;
	
ComponentScript[] componentScriptChildren;

public void Start()
	{
		CleanUp();
	}

public void OnMouseEnter ()
{
	onGui = true;
    audio.PlayOneShot(Soundhover); 
	renderer.material.color = Color.red;
}

public void CleanUp ()
{
		if(PlayerPrefs.GetInt(name+" Active") == 1)
			renderer.material.color = Color.green;
		else if(PlayerPrefs.GetInt(name+" Purchased") == 1)
			renderer.material.color = Color.blue;
		else
			renderer.material.color = Color.black;
		//updates float values anytime part changes
float speedFloat = (float)PlayerPrefs.GetInt("SpeedInt");
float handlingFloat = (float)PlayerPrefs.GetInt("HandlingInt");
float weightFloat = (float)PlayerPrefs.GetInt("WeightInt");
float styleFloat = (float)PlayerPrefs.GetInt("StyleInt");
				
PlayerPrefs.SetFloat("Speed", ( speedFloat / 27.0f));
PlayerPrefs.SetFloat("Handling", (handlingFloat / 27.0f));
PlayerPrefs.SetFloat("Weight", (weightFloat / 7.0f));
PlayerPrefs.SetFloat("Style", (styleFloat));
}
	
public void OnMouseExit ()
	{
		onGui = false;
		CleanUp();
	}
	
public void OnMouseUp ()
	{
		componentScriptChildren = transform.parent.parent.GetComponentsInChildren<ComponentScript>();
			if(PlayerPrefs.GetInt(name+" Active") == 0) //Check if Active
			{ 
			if(PlayerPrefs.GetInt(name+" Purchased") == 0) //for non active and not purchased
				{
				//Should throw in an "Are you Sure"
				if(PlayerPrefs.GetInt("Cash") >= partCost)
				{
					PlayerPrefs.SetInt("Cash", PlayerPrefs.GetInt("Cash") - partCost);
					foreach (ComponentScript i in componentScriptChildren)
					{
						if(PlayerPrefs.GetInt(i.name+" Active") == 1)
						{
							i.active = false;
							PlayerPrefs.SetInt( i.name+" Active", 0);
							PlayerPrefs.SetInt("SpeedInt", PlayerPrefs.GetInt("SpeedInt") - i.partSpeed);
							PlayerPrefs.SetInt("HandlingInt", PlayerPrefs.GetInt("HandlingInt") - i.partHandling);
							PlayerPrefs.SetInt("WeightInt", PlayerPrefs.GetInt("WeightInt") - i.partWeight);
							PlayerPrefs.SetInt("StyleInt", PlayerPrefs.GetInt("StyleInt") - i.partStyle);
							}
					}
					active = true;
					PlayerPrefs.SetInt(name+" Purchased", 1);
					PlayerPrefs.SetInt(name+" Active", 1);
					PlayerPrefs.SetInt("SpeedInt", PlayerPrefs.GetInt("SpeedInt") + partSpeed);
					PlayerPrefs.SetInt("HandlingInt", PlayerPrefs.GetInt("HandlingInt") + partHandling);
					PlayerPrefs.SetInt("WeightInt", PlayerPrefs.GetInt("WeightInt") + partWeight);
				    PlayerPrefs.SetInt("StyleInt", PlayerPrefs.GetInt("StyleInt") + partStyle);
					
					if(isPaint) //if it is in appearance, change material color
					{
						 changeColorMaterial.SetColor (changeColorPart, upgradeColor);
					}
					audio.PlayOneShot(CashMachine);
				}
				else
				{
					Debug.Log("Not enough Money");
					audio.PlayOneShot(Rejected);
				}
			}
			else //for non active but purchased
			{
					foreach (ComponentScript i in componentScriptChildren)
					{
						if(PlayerPrefs.GetInt(i.name+" Active") == 1)
						{
							i.active = false;
							PlayerPrefs.SetInt( i.name+" Active", 0);
							PlayerPrefs.SetInt("SpeedInt", PlayerPrefs.GetInt("SpeedInt") - i.partSpeed);
							PlayerPrefs.SetInt("HandlingInt", PlayerPrefs.GetInt("HandlingInt") - i.partHandling);
							PlayerPrefs.SetInt("WeightInt", PlayerPrefs.GetInt("WeightInt") - i.partWeight);
							PlayerPrefs.SetInt("StyleInt", PlayerPrefs.GetInt("StyleInt") - i.partStyle);
						}
					}
					active = true;
					PlayerPrefs.SetInt(name+" Active", 1);
					PlayerPrefs.SetInt("SpeedInt", PlayerPrefs.GetInt("SpeedInt") + partSpeed);
					PlayerPrefs.SetInt("HandlingInt", PlayerPrefs.GetInt("HandlingInt") + partHandling);
					PlayerPrefs.SetInt("WeightInt", PlayerPrefs.GetInt("WeightInt") + partWeight);
					PlayerPrefs.SetInt("StyleInt", PlayerPrefs.GetInt("StyleInt") + partStyle);

					if(isPaint) //if it is in appearance, change material color
					{
						 changeColorMaterial.SetColor (changeColorPart, upgradeColor);
					}
					audio.PlayOneShot(ClickSound);
			}
	}
		else //for is active and purchased, shut off
		{
			active = false;
			PlayerPrefs.SetInt(name+" Active", 0);
			PlayerPrefs.SetInt("SpeedInt", PlayerPrefs.GetInt("SpeedInt") - partSpeed);
			PlayerPrefs.SetInt("HandlingInt", PlayerPrefs.GetInt("HandlingInt") - partHandling);
			PlayerPrefs.SetInt("WeightInt", PlayerPrefs.GetInt("WeightInt") - partWeight);
			PlayerPrefs.SetInt("StyleInt", PlayerPrefs.GetInt("StyleInt") - partStyle);
			
			if(isPaint) //if it is in appearance, change material color
					{
						 changeColorMaterial.SetColor (changeColorPart, originalColor);
					}
			audio.PlayOneShot(ClickSound);
		}
		foreach (ComponentScript i in componentScriptChildren) //button color clean up
			i.CleanUp();
}
	void OnGUI(){
		if(onGui){
			
			int otherSpeed = partSpeed;
			int otherHandling = partHandling;
			int otherWeight = partWeight;
			int otherStyle = partStyle;
			componentScriptChildren = transform.parent.parent.GetComponentsInChildren<ComponentScript>();
			
			foreach (ComponentScript i in componentScriptChildren)
					{
						if(PlayerPrefs.GetInt(i.name+" Active") == 1)
						{
						otherSpeed = partSpeed - i.partSpeed;
						otherHandling = partHandling - i.partHandling;
						otherWeight = partWeight - i.partWeight;
						otherStyle = partStyle - i.partStyle;
				}
			}
							
			int newCash = PlayerPrefs.GetInt("Cash") - partCost;
			float newSpeed = ((float)PlayerPrefs.GetInt("SpeedInt") + (float)otherSpeed) / 27;
			float newHandling = ((float)PlayerPrefs.GetInt("HandlingInt") + (float)otherHandling) / 27;
			float newWeight = ((float)PlayerPrefs.GetInt("WeightInt") + (float)otherWeight) / 7;
			int newStyle = PlayerPrefs.GetInt("StyleInt") + otherStyle;

			
			float backSpeed = ((float)PlayerPrefs.GetInt("SpeedInt") - (float)partSpeed) / 27;
			float backHandling = ((float)PlayerPrefs.GetInt("HandlingInt") - (float)partHandling) / 27;
			float backWeight = ((float)PlayerPrefs.GetInt("WeightInt") - (float)partWeight) / 7;
			int backStyle = PlayerPrefs.GetInt("StyleInt") - partStyle;
			

			

			
			GUI.BeginGroup(new Rect(Screen.width / 2 - 500, Screen.height / 2 - 200, 1000, 400));
			GUI.contentColor = Color.white;
			GUI.Box (new Rect(0,0,400,200), "Current Stats");
			GUI.skin.GetStyle("Label").alignment = TextAnchor.MiddleCenter;
			GUI.contentColor = Color.red;
			GUI.Label(new Rect(5,35,390,190),
				"Cost: "+ partCost + "\n"+
				"Speed: "+ PlayerPrefs.GetFloat("Speed").ToString("F1") + "/ 10.0" + "\n"+
				"Handling: "+ PlayerPrefs.GetFloat("Handling").ToString("F1") + "/ 10.0" + "\n"+
				"Weight: "+ PlayerPrefs.GetFloat("Weight").ToString("F1") + "/ 10.0" + "\n"+
				"Style: "+ PlayerPrefs.GetInt("StyleInt") + "/ 10.0" + "\n");
			componentScriptChildren = transform.parent.parent.GetComponentsInChildren<ComponentScript>();
			if(!active){
			GUI.contentColor = Color.white;
			GUI.Box (new Rect(Screen.width / 2,0,400,200), "Upgraded Stats");
			GUI.skin.GetStyle("Label").alignment = TextAnchor.MiddleCenter;
			GUI.contentColor = Color.red;
			GUI.Label(new Rect(Screen.width / 2 + 5,35,390,190),
				"Cash: "+ newCash + "\n"+
				"Speed: "+ newSpeed.ToString("F1") + "/ 10.0" + "\n"+
				"Handling: "+ newHandling.ToString("F1") + "/ 10.0" + "\n"+
				"Weight: "+ newWeight.ToString("F1") + "/ 10.0" + "\n"+
				"Style: "+ newStyle.ToString("F1") + "/ 10.0" + "\n");
				CleanUp();
				}
			else{
			GUI.contentColor = Color.white;
			GUI.Box (new Rect(Screen.width / 2,0,400,200), "Upgraded Stats");
			GUI.skin.GetStyle("Label").alignment = TextAnchor.MiddleCenter;
			GUI.contentColor = Color.red;
			GUI.Label(new Rect(Screen.width / 2 + 5,35,390,190),
				"Cash: "+ PlayerPrefs.GetInt("Cash") + "\n"+
				"Speed: "+ backSpeed.ToString("F1") + "/ 10.0" + "\n"+
				"Handling: "+ backHandling.ToString("F1") + "/ 10.0" + "\n"+
				"Weight: "+ backWeight.ToString("F1") + "/ 10.0" + "\n"+
				"Style: "+ backStyle.ToString("F1") + "/ 10.0" + "\n");
				CleanUp();
			}
		
			GUI.EndGroup();
        	}
		}
}

// #pragma strict

private var Speed : float;
private var Handling : float;
private var Weight : float;
private var Style : float;
private var JCarScript;
private var TruckRigidbody : Rigidbody;

public var MassMinimum : float = 3000;
public var MassMaximum : float = 5000;

public var TorqueMinimum : float = 100;
public var TorqueMaximum : float = 300;

public var AntiRollMinimum : float = 1000;
public var AntiRollMaximum : float = 1500;

public var SpringMinimum : float = 15000;
public var SpringMaximum : float = 25000;

function Start () {
	Speed = PlayerPrefs.GetFloat("Speed") / 10;
	Handling = PlayerPrefs.GetFloat("Handling") / 10;
	Weight = PlayerPrefs.GetFloat("Weight") / 10;
	Style = PlayerPrefs.GetFloat("Style") / 10;
	ReadValues();
	JCarScript = GetComponent("JCarModified");
	TruckRigidbody = GetComponent(Rigidbody);
	SetJCarParams();
}

function Update () {
	Debug.Log(" Speed: " + Speed +
		", Handling: " + Handling + 
		", Weight: " + Weight + 
		", Style: " + Style);

	if (Input.GetKeyDown(KeyCode.R)) {
		ReadValues();
		SetJCarParams();
	}
}

function ReadValues() {

}

function SetJCarParams() {
	TruckRigidbody.mass = (MassMinimum + (Weight * (MassMaximum - MassMinimum)));
	JCarScript.torque = (TorqueMinimum + (Speed * (TorqueMaximum - TorqueMinimum)));
	JCarScript.commonWheelParameters.spring = (SpringMinimum + (Handling * (SpringMaximum - SpringMinimum)));
	JCarScript.antiRollValue = (AntiRollMinimum + (Handling * (AntiRollMaximum - AntiRollMinimum)));
}
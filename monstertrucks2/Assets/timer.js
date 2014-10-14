public var startTime;
public var restSeconds : int;
private var roundedRestSeconds : int;
private var displaySeconds : int;
private var displayMinutes : int;
public var font : Font;
var countDownSeconds : int;
public var loadlevel : String;
public var endscreen : String;

function Awake() {
    startTime = Time.time;
}


function OnGUI () {
    //make sure that your time is based on when this script was first called
    //instead of when your game started
    var guiTime = Time.time - startTime;
    GUI.skin.font = font;
   	GUI.contentColor = Color.red;

    restSeconds = countDownSeconds - (guiTime);

  //display points
    var points = PlayerPrefs.GetFloat("points");

    //display messages or whatever here -->do stuff based on your timer
    if (restSeconds == 60) {
        print ("One Minute Left");
    }
    if (restSeconds == 0) {
		var playerCash = PlayerPrefs.GetInt("Cash");
        PlayerPrefs.SetInt("Cash", playerCash + Mathf.RoundToInt(points*.1));
        PlayerPrefs.SetInt("round score", Mathf.RoundToInt(points));
        PlayerPrefs.SetInt("Total Score", PlayerPrefs.GetInt("Total Score") + PlayerPrefs.GetInt("round score"));
        if (PlayerPrefs.GetInt("Highest Score - Round") < PlayerPrefs.GetInt("round score")) {
        PlayerPrefs.SetInt("Highest Score - Round", PlayerPrefs.GetInt("round score"));
        }
   		Application.LoadLevel(endscreen);
    }
    
    if (restSeconds > countDownSeconds - 5) {
    	var text2 = "WASD or arrow keys to drive, IJKL to do air moves, Enter to reset";
    	GUI.Label (Rect (0, Screen.height - 50, 1200, 50), text2);
    }
    if ( restSeconds > countDownSeconds - 10 && restSeconds < countDownSeconds - 6) {
    	var text3 = "Press End to Return to the Main Menu";
    	GUI.Label (Rect (0, Screen.height - 50, 1200, 50), text3);
    }
   	if (Event.current.Equals(Event.KeyboardEvent("end"))) {
		Application.LoadLevel(loadlevel);	
	}

    //display the timer
    roundedRestSeconds = Mathf.CeilToInt(restSeconds);
    displaySeconds = roundedRestSeconds % 60;
    displayMinutes = roundedRestSeconds / 60; 
  
    text1 = Mathf.CeilToInt(points).ToString(); 
    GUI.Label (Rect (50, 50, 200, 30), text1);
    
    
    text = String.Format ("{0:00}:{1:00}", displayMinutes, displaySeconds); 
    GUI.Label (Rect (Screen.width - 200, 50, 300, 30), text);
    }
    

var levelToLoad : String;
var soundhover : AudioClip;
var beep : AudioClip;
var QuitButton : boolean = false;
function OnStart(){
renderer.material.color = Color.black;
}

function OnMouseEnter(){
audio.PlayOneShot(soundhover);
renderer.material.color = Color.red;
}
function OnMouseExit(){
renderer.material.color = Color.black;
}
function OnMouseUp(){
audio.PlayOneShot(beep);
yield new WaitForSeconds(0.35);
if(QuitButton){
Application.Quit();
}
else{
Application.LoadLevel(levelToLoad);
}
}
@script RequireComponent(AudioSource)
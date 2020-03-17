var force : Vector3; //variable for "lift" of the rocket
 
var relativeTorque : Vector3; //variable for torque (spin) of rocket
 
var liftSpeed : float;    //determines how much force will be applied
 
var turnSpeed : float; //determines how much torque will be applied
 
function Update () {
 
if (Input.GetButtonDown("Fire1")) {
 
GetComponent.<ConstantForce>().force = Vector3.up * liftSpeed; //determines the "lift" of the rocket, hence the "up" times the liftSpeed
 
GetComponent.<ConstantForce>().relativeTorque= Vector3(0,turnSpeed,0); //determines torque placed on rocket in order to turn
 
GetComponent.<AudioSource>().Play(); //plays the audio clip attached to the model
 
}
 
} 
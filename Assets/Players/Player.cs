using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;

public class Player : NetworkBehaviour {
	
	public float speed = 10.0f;
	public float rotationSpeed = 100.0f;
	
		
	// Update is called once per frame
	void Update () {
		if (!isLocalPlayer) {
			return;
		}
		
		//Input handling for local player only				
		Debug.Log ("H: " + CrossPlatformInputManager.GetAxis("Horizontal"));
		Debug.Log ("V: " + CrossPlatformInputManager.GetAxis("Vertical"));
		
		float translation = CrossPlatformInputManager.GetAxis("Vertical") * speed;
		float rotation = CrossPlatformInputManager.GetAxis("Horizontal") * rotationSpeed;
		
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;				
		
		transform.Translate (0,0,translation);
		transform.Rotate(0,rotation,0);
		
//		Alternative player input control code
//
//		private Vector3 inputValue;
//
//		inputValue.x = CrossPlatformInputManager.GetAxis("Horizontal");
//		inputValue.y = 0f;
//		inputValue.z = CrossPlatformInputManager.GetAxis("Vertical");
//		
//		transform.Translate (inputValue);

	}
	
	
	
}

using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {
	
	public float speed = 10.0f;
	public float rotationSpeed = 100.0f;
		
	// Update is called once per frame
	void Update () {
		Debug.Log ("H: " + CrossPlatformInputManager.GetAxis("Horizontal"));
		Debug.Log ("V: " + CrossPlatformInputManager.GetAxis("Vertical"));
	
		float translation = CrossPlatformInputManager.GetAxis("Vertical") * speed;
		float rotation = CrossPlatformInputManager.GetAxis("Horizontal") * rotationSpeed;
		
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;				
		
		transform.Translate (0,0,translation);
		transform.Rotate(0,rotation,0);
		
//		if (CrossPlatformInputManager.GetAxis("Horizontal")) {
//			this.transform.position += Vector3.left * speed * Time.deltaTime;
//		}
//		else if (CrossPlatformInputManager.GetButtonDown("Right")) {
//			this.transform.position += Vector3.right * speed * Time.deltaTime;
//		}

	}
	
	
	
}

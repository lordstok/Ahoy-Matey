using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {

	public void MyStartHost (){
		Debug.Log ("Starting Network Host at " + Time.timeSinceLevelLoad);
		StartHost();
	}

	public override void OnStartHost() {
		Debug.Log ("Network Host started at " + Time.timeSinceLevelLoad);
	}

}

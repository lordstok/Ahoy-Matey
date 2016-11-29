using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {

	public void MyStartHost (){
		Debug.Log (Time.timeSinceLevelLoad + ": Starting Network Host");
		StartHost();
	}

	public override void OnStartHost() {
		Debug.Log (Time.timeSinceLevelLoad + ": Network Host started");
	}

	public override void OnStartClient(NetworkClient myClient) {
		Debug.Log (Time.timeSinceLevelLoad + ": Client start requested");
		InvokeRepeating ("Blinker", 1.0f, 1.0f);
	}

	public override void OnClientConnect (NetworkConnection conn) {
		CancelInvoke();
		Debug.Log (Time.timeSinceLevelLoad + ": Client is connected to IP: " + conn.address);

	}

	void Blinker () {
		print (".");
	}

}

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
	}

	public override void OnClientConnect (NetworkConnection conn) {
		Debug.Log (Time.timeSinceLevelLoad + ": Client is connected to IP: " + conn.address);
	}

}

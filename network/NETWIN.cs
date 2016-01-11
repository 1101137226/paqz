using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class NETWIN : NetworkBehaviour {
	public GameObject master;
	float timer;

	void Start () {
		master = GameObject.Find (GameObject.Find ("UIRoot").GetComponent<NETSAVE> ().thisname).gameObject;
		if (master.GetComponent<NETstaus> ().nowhp <= 0) {
				
		
						Instantiate (Resources.Load ("de"));
		
				} else {
				
			Instantiate (Resources.Load ("VIC"));
		
		}


	}

	void Update () {
		timer += Time.deltaTime;


		if (timer > 8f) {

			GameObject.Find ("Lobby").GetComponent<NetworkLobbyManager> ().SendReturnToLobby();
			GameObject.Find ("Lobby").GetComponent<NetworkLobbyManager> ().StopHost ();
			
			GameObject.Find ("Lobby").GetComponent<NetworkLobbyManager> ().StopClient ();
		}
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class NETWIN : NetworkBehaviour {
	public GameObject master;
	float timer;
	// Use this for initialization
	void Start () {
		master = GameObject.Find (GameObject.Find ("UIRoot").GetComponent<NETSAVE> ().thisname).gameObject;
		if (master.GetComponent<NETstaus> ().nowhp <= 0) {
				
		
						Instantiate (Resources.Load ("de"));
		
				} else {
				
			Instantiate (Resources.Load ("VIC"));
		
		}


	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;


		if (timer > 8f) {
				
		
			GameObject.Find ("Lobby").GetComponent<NetworkLobbyManager> ().SendReturnToLobby();
		
		}
	}
}

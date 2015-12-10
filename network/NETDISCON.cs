using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class NETDISCON : NetworkBehaviour
{
		public NetworkLobbyManager m;
		// Use this for initialization
		void Start ()
		{
				m = GameObject.Find ("Lobby").GetComponent<NetworkLobbyManager> ();
		}

		public void OnPress (bool ispress)
		{
				//	manager.networkAddress = GameObject.Find ("IPadd").GetComponent<UIInput> ().value;
		
				//	manager.StartClient();
		
				if (ispress) {
						m.networkAddress = GameObject.Find ("IPadd").GetComponent<UIInput> ().value;
						GameObject.Find("Cli").GetComponent<gotoothernetwork>().big=false;
						m.StopHost ();

						m.StopClient ();
				}
		}
		// Update is called once per frame
		void Update ()
		{
				//this.transform.localPosition = new Vector3 (1250, -250, 0);
		}
}

using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class NETDISCON : NetworkBehaviour
{
		public NetworkLobbyManager m;
		
		void Start ()
		{
				m = GameObject.Find ("Lobby").GetComponent<NetworkLobbyManager> ();
		}

		public void OnPress (bool ispress)
		{				
		
				if (ispress) {
						m.networkAddress = GameObject.Find ("IPadd").GetComponent<UIInput> ().value;
						GameObject.Find("Cli").GetComponent<gotoothernetwork>().big=false;
						m.StopHost ();

						m.StopClient ();
				}
		}
		
		void Update ()
		{
				
		}
}

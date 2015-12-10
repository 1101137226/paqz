using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class gotoothernetwork : MonoBehaviour
{
		public NetworkManager manager;
		public NetworkLobbyManager m;
		string ipadd;
		public bool big;

		void Awake ()
		{
				this.enabled = true;
				//manager =GameObject.Find("NET").GetComponent<NetworkManager>();

				m = GameObject.Find ("Lobby").GetComponent<NetworkLobbyManager> ();
				GameObject.Find ("Connect Hall").GetComponent<UIPanel> ().alpha = 1;
				GameObject.Find ("Connect Room").GetComponent<UIPanel> ().alpha = 0;
		big = false;
		}
		// Use this for initialization
		public void OnPress (bool ispress)
		{
				//	manager.networkAddress = GameObject.Find ("IPadd").GetComponent<UIInput> ().value;

				//	manager.StartClient();

				if (ispress) {
						m.networkAddress = GameObject.Find ("IPadd").GetComponent<UIInput> ().value;
						m.StartClient ();
						GameObject.Find ("Connect Hall").GetComponent<UIPanel> ().alpha = 0;
						GameObject.Find ("Connect Room").GetComponent<UIPanel> ().alpha = 1;
						big=true;
						//GameObject.Find("Camera").transform.localPosition=new Vector3(1000,0,0);
				}
		}

		void Update ()
		{

		}
}

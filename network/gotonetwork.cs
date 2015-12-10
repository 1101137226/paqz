using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class gotonetwork : MonoBehaviour
{
		public NetworkManager manager;
		public NetworkLobbyManager m;

		void Awake ()
		{
				//manager =GameObject.Find("NET").GetComponent<NetworkManager>();
				m = GameObject.Find ("Lobby").GetComponent<NetworkLobbyManager> ();
				GameObject.Find ("Connect Hall").GetComponent<UIPanel> ().alpha = 1;
				GameObject.Find ("Connect Room").GetComponent<UIPanel> ().alpha = 0;
		}
		// Use this for initialization
		public void OnPress (bool ispress)
		{
				//manager.StartHost ();
				if (ispress) {


						m.StartHost ();
						GameObject.Find ("Connect Hall").GetComponent<UIPanel> ().alpha = 0;
						GameObject.Find ("Connect Room").GetComponent<UIPanel> ().alpha = 1;
						GameObject.Find ("Stage").GetComponent<UIPanel> ().alpha = 1;
						//GameObject.Find ("Camera").transform.localPosition = new Vector3 (1000, 0, 0);
				}
		}
}

using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class gotonetwork : MonoBehaviour
{
		public NetworkManager manager;
		public NetworkLobbyManager m;

		void Awake ()
		{
				m = GameObject.Find ("Lobby").GetComponent<NetworkLobbyManager> ();
				GameObject.Find ("Connect Hall").GetComponent<UIPanel> ().alpha = 1;
				GameObject.Find ("Connect Room").GetComponent<UIPanel> ().alpha = 0;
		}
		public void OnPress (bool ispress)
		{
				if (ispress) {


						m.StartHost ();
						GameObject.Find ("Connect Hall").GetComponent<UIPanel> ().alpha = 0;
						GameObject.Find ("Connect Room").GetComponent<UIPanel> ().alpha = 1;
						GameObject.Find ("Stage").GetComponent<UIPanel> ().alpha = 1;
				}
		}
}

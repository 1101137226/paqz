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

		m = GameObject.Find ("Lobby").GetComponent<NetworkLobbyManager> ();
		GameObject.Find ("Connect Hall").GetComponent<UIPanel> ().alpha = 1;
		GameObject.Find ("Connect Room").GetComponent<UIPanel> ().alpha = 0;
		big = false;
	}

	public void OnPress (bool ispress)
	{
		if (ispress) {
			m.networkAddress = GameObject.Find ("IPadd").GetComponent<UIInput> ().value;
			m.StartClient ();
			GameObject.Find ("Connect Hall").GetComponent<UIPanel> ().alpha = 0;
			GameObject.Find ("Connect Room").GetComponent<UIPanel> ().alpha = 1;
			big = true;
		}
	}

	void Update ()
	{

	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class NETReady : MonoBehaviour {
	public bool ready;
	public string master;
	UILabel o;
	// Use this for initialization
	void Start () {
		ready = false;
		o = this.transform.GetChild (0).GetComponent<UILabel> ();
	}
	public void OnPress(bool ispress){
		
		GameObject m = GameObject.Find (master).gameObject;
		//	manager.networkAddress = GameObject.Find ("IPadd").GetComponent<UIInput> ().value;
		
		//	manager.StartClient();
		
		if (ispress) {
			if(!ready)
			{
				ready=true;

				m.GetComponent<LobbyPlayerCTRL>().GetReady();
				o.text="Ready";

			}else if(ready)
			{

				m.GetComponent<LobbyPlayerCTRL>().NOTReady();
				ready=false;
				o.text="Click to Ready";
			}
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}

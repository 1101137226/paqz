using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class NETReady : MonoBehaviour {
	public bool ready;
	public string master;
	UILabel o;

	void Start () {
		ready = false;
		o = this.transform.GetChild (0).GetComponent<UILabel> ();
	}
	public void OnPress(bool ispress){
		
		GameObject m = GameObject.Find (master).gameObject;	
		
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

	void Update () {
	
	}
}

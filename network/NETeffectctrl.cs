using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class NETeffectctrl : NetworkBehaviour{



	float time;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time > 0.5f) {
				
			Destroy(this.gameObject);
			NetworkServer.Destroy(this.gameObject);
		
		}
	
	}
	

}

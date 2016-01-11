using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class NETeffectctrl : NetworkBehaviour{



	float time;

	void Start () {
	
	}

	void Update () {
		time += Time.deltaTime;
		if (time > 0.5f) {
				
			Destroy(this.gameObject);
			NetworkServer.Destroy(this.gameObject);
		
		}
	
	}
	

}

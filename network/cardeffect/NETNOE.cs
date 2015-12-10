using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class NETNOE :NetworkBehaviour {
	[SyncVar]public byte num;
	[SyncVar]public byte team;
	float efftime;
	public float passtime;

	// Use this for initialization
	void Start () {
	
		if (num == 62) {
				
						efftime = 3f;
		
				}

		if (num == 63) {
				
			efftime=5f;
					}





		this.transform.parent = GameObject.Find ("other").transform;

	}
	
	// Update is called once per frame
	void Update () {

		passtime += Time.deltaTime;
		this.name="GOPure";

		if (team == 1) {
				
			NETnewtempoP2.ispure=true;

			if (passtime > efftime) {
				
				
				NETnewtempoP2.ispure=false;
				
				team=3;
				
				
			}




		}else if (team == 2) {
			
			NETnewtempo.ispure=true;
			
			if (passtime > efftime) {
				
				
				NETnewtempo.ispure=false;
				
				team=3;
				
				
			}
			
			
		}
	
		if (passtime > 6f) {
				
		
			Destroy(this.gameObject);
		
		}


	
	}
}

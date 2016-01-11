using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class NETCardDis : NetworkBehaviour
{
	[SyncVar]
	public string who;
	[SyncVar]
	public string master;
	float time;

	void Start ()
	{

		if (master != GameObject.Find ("UIRoot").GetComponent<NETSAVE> ().thisname) {
			GameObject.Find (who).GetComponent<carddis> ().poi = true;
		}
	}

	void Update ()
	{
	
		time += Time.deltaTime;
		if (time > 1.25f) {
				
		
			Destroy (this.gameObject);
		
		}



	}


}

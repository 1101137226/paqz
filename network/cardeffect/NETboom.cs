using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class NETboom : NetworkBehaviour {
	[SyncVar]public byte team;
	[SyncVar]public byte num;
	[SyncVar]public string master;
	GameObject target;
	float passtime;
	float efftime;
	short startcombo;
	short nowcombo;
	short maxcombo;
	bool inin=false;
	// Use this for initialization
	void Start () {
	

		if(team==1)
		{
			
			if (GameObject.Find ("Script/P1Boom").transform.childCount != 0)
			{Destroy(GameObject.Find("Script/P1Boom/Boom").gameObject);}
			this.transform.parent=GameObject.Find("Script/P1Boom").transform;
			
			
		}else if(team==2)
		{

				
				if (GameObject.Find ("Script/P2Boom").transform.childCount != 0)
				{Destroy(GameObject.Find("Script/P2Boom/Boom").gameObject);}
			this.transform.parent=GameObject.Find("Script/P2Boom").transform;
		
			
		}
		string t = GameObject.Find ("UIRoot").GetComponent<NETSAVE> ().thisname;
		if (t != master) {
				
		
			target=GameObject.Find(t).gameObject;
			startcombo=target.GetComponent<NETBS>().combo;
			inin=true;
		}

		if (num == 64) {
			efftime=10f;
		
		
		}else if (num == 65) {
			efftime=15f;
			
			
		}else if (num == 66) {
			efftime=20f;
			
			
		}



	}
	
	// Update is called once per frame
	void Update () {

						passtime += Time.deltaTime;
						this.name = "Boom";
						if (passtime < efftime && inin) {
				
								short combo = target.GetComponent<NETBS> ().combo;
								if (combo == 0) {
										startcombo = 0;
								}
								nowcombo = (short)(combo - startcombo);
			
								if (nowcombo > maxcombo) {
										maxcombo = nowcombo;
				
								}
		
		
						}
						if (passtime >= efftime ) {
								if (maxcombo <= 15 && inin) {

										if (num == 64) {
												target.GetComponent<NETstaus> ().GetBoom (15f);
												

										} else if (num == 65) {
												target.GetComponent<NETstaus> ().GetBoom (25f);
												
					
										} else if (num == 66) {
												target.GetComponent<NETstaus> ().GetBoom (40f);
												
					
										}



								}
								
								Destroy (this.gameObject);
						}

				

	
	}
}

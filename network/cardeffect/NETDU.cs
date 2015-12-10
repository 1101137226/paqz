using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class NETDU : NetworkBehaviour {
	[SyncVar]public byte team;
	[SyncVar]public byte num;
	[SyncVar]public bool jk;
	[SyncVar]public string master;
	GameObject target;
	GameObject me;
	float passtime;
	float efftime;
	float timer;
	byte jtimes;
	short startcombo;
	short nowcombo;
	short maxcombo;
	// Use this for initialization
	void Start () {

		if (team == 1)
		{
			if (GameObject.Find ("Script/P1DU").transform.childCount != 0)
			{Destroy(GameObject.Find ("Script/P1DU/DU").gameObject);}
			target = GameObject.Find ("P2").gameObject;
			this.transform.parent=GameObject.Find("Script/P1DU").transform;
		} 
		else if (team == 2) 
		{
			if (GameObject.Find ("Script/P2DU").transform.childCount != 0)
			{Destroy(GameObject.Find ("Script/P2DU/DU").gameObject);}
			target=GameObject.Find("P1").gameObject;
			this.transform.parent=GameObject.Find("Script/P2DU").transform;
		
		}

	if (num == 59) 
		{
			efftime=5f;
			jtimes=1;
		
		}else if (num == 60) 
		{
			efftime=10f;	
			jtimes=2;
		}else if (num == 61) 
		{
			efftime=15f;	
			jtimes=3;
		}

		me = GameObject.Find (master).gameObject;
		startcombo=me.GetComponent<NETBS>().combo;
	}
	
	// Update is called once per frame
	void Update () {

		this.name="DU";



		passtime += Time.deltaTime;
		if (!jk) {
				
		
		
						if (passtime >= 1.8f && passtime < 5f) {

								timer += Time.deltaTime;
								if (timer > 1f) {
										target.GetComponent<net> ().CmdCreatDu ();
										timer = 0f;

								}
			
						} else if (passtime >= 5f) {
								passtime = 0;
								jtimes--;

						}
		
						if (jtimes == 0) {

								Destroy (this.gameObject);

						}


		
				} else if (jk) 
			{
						
					
			if(passtime<efftime)
			{
				short combo=me.GetComponent<NETBS>().combo;
				if(combo==0)
				{startcombo=0;}
				nowcombo=(short)(combo-startcombo);

				if(nowcombo>maxcombo)
				{
					maxcombo=nowcombo;

				}

				jtimes=(byte)(maxcombo/5);
			}else if(passtime>=efftime)
			{




				timer += Time.deltaTime;
				if(timer>1f)
				{
					target.GetComponent<net> ().CmdCreatDu ();
					timer = 0f;
					jtimes--;
				}

				if(jtimes==0)
				{
					Destroy(this.gameObject);


				}


			}


		
		
		
			}




	
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class NETDrawfly : NetworkBehaviour {

	public GameObject back;

	[SyncVar]public byte who;
	[SyncVar]public string master;
	[SyncVar]public byte team;
	float time;
	// Use this for initialization
	void Start () {
	
		if (this.name == "Draw(Clone)") {
				



		
		
			if(master!=GameObject.Find("UIRoot").GetComponent<NETSAVE>().thisname)
			{

				if(GameObject.Find("UIRoot").GetComponent<NETSAVE>().thisteam==1)
				{team=2;}
				else if(GameObject.Find("UIRoot").GetComponent<NETSAVE>().thisteam==2)
				{team=1;}

			GameObject yo=(GameObject)Instantiate(back);
				yo.transform.parent=GameObject.Find("UIRoot").transform;
				yo.transform.localScale=new Vector3(1,1,1);
				yo.transform.localPosition=new Vector3(-6600+who*1800,-4000+(team-1)*8400,0);
				string qw=who.ToString()+"S";
				yo.name=qw;
			
			
				if(team==1)
				{

					yo.GetComponent<NETcardfly>().who=who;
					yo.GetComponent<NETcardfly>().fly=true;
				}
				else if(team==2)
				{
					yo.GetComponent<NETcardfly>().who=who;
					yo.GetComponent<NETcardfly>().flydown=true;

				}


			
			}
		
		
		
		

	
		
		}


	}
	
	// Update is called once per frame
	void Update () {
	

		time += Time.deltaTime;
		if (time > 0.5f) {
				
		
			Destroy(this.gameObject);
		
		}
		
		
		


	}
}

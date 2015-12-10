using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class NETchange :NetworkBehaviour {
	[SyncVar]public string num;
	[SyncVar]public byte team;
	public float passtime;
	bool who;

	float effecttime;
	GameObject colorch;
	public byte n;
	// Use this for initialization
	void Start () {




		if (team == 1) 
		{
			if (GameObject.Find ("Script/P1change").transform.childCount != 0)
			{GameObject.Find ("Script/P1change/change").GetComponent<NETchange>().n=0;}
			colorch = GameObject.Find ("trdown").gameObject;
			GameObject.Find ("P1").GetComponent<net> ().bpm = 0.8f;
			NETnewtempo.isgu=false;
			NETnewtempo.isba=false;
			NETnewtempo.issm=false;
			NETnewtempo.ispi=false;
			who=false;
			this.transform.parent=GameObject.Find ("Script/P1change").transform;

		}
		else if(team==2)
		{
			if (GameObject.Find ("Script/P2change").transform.childCount != 0)
			{GameObject.Find ("Script/P2change/change").GetComponent<NETchange>().n=0;}
			colorch = GameObject.Find ("trup").gameObject;
			GameObject.Find ("P2").GetComponent<net> ().bpm = 0.8f;	
			NETnewtempoP2.isgu=false;
			NETnewtempoP2.isba=false;
			NETnewtempoP2.issm=false;
			NETnewtempoP2.ispi=false;
			who=true;
			this.transform.parent=GameObject.Find ("Script/P2change").transform;
		}
	


		 n = System.Convert.ToByte(num);

	
	}
	
	// Update is called once per frame
	void Update () {

		this.name = "change";

		passtime += Time.deltaTime;
		switch (n) {
		case 0:
			if (team == 1) 
			{
			NETnewtempo.isgu=false;
			NETnewtempo.isba=false;
			NETnewtempo.issm=false;
			NETnewtempo.ispi=false;
			GameObject.Find ("P1").GetComponent<net> ().bpm = 0.8f;
			}
			else if(team==2)
			{
			NETnewtempoP2.isgu=false;
			NETnewtempoP2.isba=false;
			NETnewtempoP2.issm=false;
			NETnewtempoP2.ispi=false;
			GameObject.Find ("P2").GetComponent<net> ().bpm = 0.8f;
			}
			Destroy(this.gameObject);
			break;
		case 1:
			colorch.GetComponent<SpriteRenderer>().color=new Color(255,0,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
			effecttime = 5f;
			if(!who){NETnewtempo.isgu=true;}
			if(who){NETnewtempoP2.isgu=true;}
		//	GameObject [] gg=GameObject.f
			if (passtime >= effecttime) {

				if(!who){NETnewtempo.isgu=false;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.8f;}
				if(who){NETnewtempoP2.isgu=false;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.8f;}

				Destroy(this.gameObject);
				
			}
			
			
			break;
		case 2:
			colorch.GetComponent<SpriteRenderer>().color=new Color(255,0,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
			effecttime = 10f;
			if(!who){NETnewtempo.isgu=true;}
			if(who){NETnewtempoP2.isgu=true;}

			if (passtime >= effecttime) {
				
				if(!who){NETnewtempo.isgu=false;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.8f;}
				if(who){NETnewtempoP2.isgu=false;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.8f;}		

				n=0;
				
			}
			
			
			break;
		case 3:
			colorch.GetComponent<SpriteRenderer>().color=new Color(255,0,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
			effecttime = 15f;
			if(!who){NETnewtempo.isgu=true;}
			if(who){NETnewtempoP2.isgu=true;}
			if (passtime >= effecttime) {

				if(!who){NETnewtempo.isgu=false;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.8f;}
				if(who){NETnewtempoP2.isgu=false;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.8f;}


				n=0;
				
			}
			
			
			break;
		case 4:
			colorch.GetComponent<SpriteRenderer>().color=new Color(0,255,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
			effecttime = 5f;
			if(!who){NETnewtempo.isba=true;}
			if(who){NETnewtempoP2.isba=true;}
			if (passtime >= effecttime) {

				if(!who){NETnewtempo.isba=false;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.8f;}
				if(who){NETnewtempoP2.isba=false;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.8f;}
				n=0;
				
			}
			
			
			break;
		case 5:
			colorch.GetComponent<SpriteRenderer>().color=new Color(0,255,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
			effecttime = 10f;
			if(!who){NETnewtempo.isba=true;}
			if(who){NETnewtempoP2.isba=true;}
			if (passtime >= effecttime) {


				if(!who){NETnewtempo.isba=false;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.8f;}
				if(who){NETnewtempoP2.isba=false;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.8f;}
				n=0;
				
			}
			break;
		case 6:
			colorch.GetComponent<SpriteRenderer>().color=new Color(0,255,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
			effecttime = 15f;
			if(!who){NETnewtempo.isba=true;}
			if(who){NETnewtempoP2.isba=true;}
			if (passtime >= effecttime) {

				if(!who){NETnewtempo.isba=false;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.8f;}
				if(who){NETnewtempoP2.isba=false;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.8f;}
				n=0;
				
			}
			break;
		case 7:
			colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
			effecttime = 5f;
			if(!who){NETnewtempo.issm=true;}
			if(who){NETnewtempoP2.issm=true;}
			if (passtime >= effecttime) {

				if(!who){NETnewtempo.issm=false;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.8f;}
				if(who){NETnewtempoP2.issm=false;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.8f;}
				n=0;
				
			}
			
			break;
		case 8:
			colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
			effecttime = 10f;
			if(!who){NETnewtempo.issm=true;}
			if(who){NETnewtempoP2.issm=true;}
			if (passtime >= effecttime) {

				if(!who){NETnewtempo.issm=false;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.8f;}
				if(who){NETnewtempoP2.issm=false;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.8f;}
				n=0;
				
			}
			
			break;
		case 9:
			colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
			effecttime = 15f;
			if(!who){NETnewtempo.issm=true;}
			if(who){NETnewtempoP2.issm=true;}
			if (passtime >= effecttime) {

				if(!who){NETnewtempo.issm=false;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.8f;}
				if(who){NETnewtempoP2.issm=false;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.8f;}
				n=0;
				
			}
			
			break;
		case 10:
			colorch.GetComponent<SpriteRenderer>().color=new Color(0,0,255);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
			effecttime = 5f;
			if(!who){NETnewtempo.ispi=true;}
			if(who){NETnewtempoP2.ispi=true;}
			if (passtime >= effecttime) {

				if(!who){NETnewtempo.ispi=false;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.8f;}
				if(who){NETnewtempoP2.ispi=false;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.8f;}
				bpm.tempobpm = 0.8f;
				n=0;
				
			}
			
			break;
		case 11:
			colorch.GetComponent<SpriteRenderer>().color=new Color(0,0,255);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
			effecttime = 10f;
			if(!who){NETnewtempo.ispi=true;}
			if(who){NETnewtempoP2.ispi=true;}
			if (passtime >= effecttime) {

				if(!who){NETnewtempo.ispi=false;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.8f;}
				if(who){NETnewtempoP2.ispi=false;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.8f;}
				n=0;
				
			}
			
			break;
		case 12:
			colorch.GetComponent<SpriteRenderer>().color=new Color(0,0,255);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
			effecttime = 15f;
			if(!who){NETnewtempo.ispi=true;}
			if(who){NETnewtempoP2.ispi=true;}
			if (passtime >= effecttime) {

				if(!who){NETnewtempo.ispi=false;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.8f;}
				if(who){NETnewtempoP2.ispi=false;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.8f;}
				n=0;
			}
			
			break;
			
		case 13:
			colorch.GetComponent<SpriteRenderer>().color=new Color(255,0,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
			effecttime = 7f;
			if(!who){NETnewtempo.isgu=true;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.4f;}
			if(who){NETnewtempoP2.isgu=true;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.4f;}
			if (passtime >= effecttime) {

				if(!who){NETnewtempo.isgu=false;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.8f;}
				if(who){NETnewtempoP2.isgu=false;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.8f;}
				n=0;
			}
			
			break;
		case 14:
			colorch.GetComponent<SpriteRenderer>().color=new Color(255,0,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
			effecttime = 10f;
			if(!who){NETnewtempo.isgu=true;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.4f;}
			if(who){NETnewtempoP2.isgu=true;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.4f;}
			if (passtime >= effecttime) {

				if(!who){NETnewtempo.isgu=false;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.8f;}
				if(who){NETnewtempoP2.isgu=false;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.8f;}
				n=0;
			}
			
			break;
		case 15:
			colorch.GetComponent<SpriteRenderer>().color=new Color(255,0,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
			effecttime = 13f;
			if(!who){NETnewtempo.isgu=true;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.4f;}
			if(who){NETnewtempoP2.isgu=true;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.4f;}
			if (passtime >= effecttime) {

				if(!who){NETnewtempo.isgu=false;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.8f;}
				if(who){NETnewtempoP2.isgu=false;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.8f;}
				n=0;
			}
			
			break;
		case 16:
			colorch.GetComponent<SpriteRenderer>().color=new Color(0,255,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
			effecttime = 7f;
			if(!who){NETnewtempo.isba=true;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.4f;}
			if(who){NETnewtempoP2.isba=true;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.4f;}
			if (passtime >= effecttime) {

				if(!who){NETnewtempo.isba=false;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.8f;}
				if(who){NETnewtempoP2.isba=false;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.8f;}
				n=0;
			}
			
			break;
		case 17:
			colorch.GetComponent<SpriteRenderer>().color=new Color(0,255,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
			effecttime = 10f;
			if(!who){NETnewtempo.isba=true;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.4f;}
			if(who){NETnewtempoP2.isba=true;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.4f;}

			if (passtime >= effecttime) {

				if(!who){NETnewtempo.isba=false;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.8f;}
				if(who){NETnewtempoP2.isba=false;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.8f;}
				n=0;
			}
			
			break;
		case 18:
			colorch.GetComponent<SpriteRenderer>().color=new Color(0,255,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
			effecttime = 13f;
			if(!who){NETnewtempo.isba=true;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.4f;}
			if(who){NETnewtempoP2.isba=true;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.4f;}
			if (passtime >= effecttime) {

				if(!who){NETnewtempo.isba=false;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.8f;}
				if(who){NETnewtempoP2.isba=false;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.8f;}
				n=0;
			}
			
			break;
		case 19:
			colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
			effecttime = 7f;
			if(!who){NETnewtempo.issm=true;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.4f;}
			if(who){NETnewtempoP2.issm=true;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.4f;}
			if (passtime >= effecttime) {

				if(!who){NETnewtempo.issm=false;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.8f;}
				if(who){NETnewtempoP2.issm=false;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.8f;}
				n=0;
			}
			
			break;
		case 20:
			colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
			effecttime = 10f;
			if(!who){NETnewtempo.issm=true;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.4f;}
			if(who){NETnewtempoP2.issm=true;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.4f;}
			if (passtime >= effecttime) {

				if(!who){NETnewtempo.issm=false;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.8f;}
				if(who){NETnewtempoP2.issm=false;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.8f;}
				n=0;
			}
			
			break;
		case 21:
			colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
			effecttime = 13f;
			if(!who){NETnewtempo.issm=true;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.4f;}
			if(who){NETnewtempoP2.issm=true;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.4f;}
			if (passtime >= effecttime) {

				if(!who){NETnewtempo.issm=false;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.8f;}
				if(who){NETnewtempoP2.issm=false;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.8f;}
				n=0;	
			}
			
			break;
		case 22:
			colorch.GetComponent<SpriteRenderer>().color=new Color(0,0,255);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
			effecttime = 7f;
			if(!who){NETnewtempo.ispi=true;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.4f;}
			if(who){NETnewtempoP2.ispi=true;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.4f;}
			if (passtime >= effecttime) {

				if(!who){NETnewtempo.ispi=false;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.8f;}
				if(who){NETnewtempoP2.ispi=false;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.8f;}
				n=0;
			}
			
			break;
		case 23:
			colorch.GetComponent<SpriteRenderer>().color=new Color(0,0,255);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
			effecttime = 10f;
			if(!who){NETnewtempo.ispi=true;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.4f;}
			if(who){NETnewtempoP2.ispi=true;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.4f;}
			if (passtime >= effecttime) {

				if(!who){NETnewtempo.ispi=false;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.8f;}
				if(who){NETnewtempoP2.ispi=false;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.8f;}
				n=0;
			}
			
			break;
		case 24:
			colorch.GetComponent<SpriteRenderer>().color=new Color(0,0,255);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
			effecttime = 13f;
			if(!who){NETnewtempo.ispi=true;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.4f;}
			if(who){NETnewtempoP2.ispi=true;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.4f;}
			if (passtime >= effecttime) {

				if(!who){NETnewtempo.ispi=false;GameObject.Find ("P1").GetComponent<net> ().bpm = 0.8f;}
				if(who){NETnewtempoP2.ispi=false;GameObject.Find ("P2").GetComponent<net> ().bpm = 0.8f;}
				n=0;	
			}
			
			break;
			
		}







	
	}
}

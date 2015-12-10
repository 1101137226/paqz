using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class NETaccel : NetworkBehaviour {
	[SyncVar]public byte num;
	[SyncVar]public byte team;
	[SyncVar]public bool jk;
	public GameObject speed;
	public GameObject slow;
	float effecttime;
	public float passtime;
	GameObject goo;

	// Use this for initialization
	void Start () {



		if (team == 1) {
			if (GameObject.Find ("Script/P1Speed").transform.childCount != 0)
			{GameObject.Find ("Script/P1Speed/accel").GetComponent<NETaccel>().num=0;}
		if(!jk)
			{

			goo=(GameObject)Instantiate(speed);
				goo.transform.localPosition=new Vector3(15,15,0);
			
			}
		else if(jk)
			{

				goo=(GameObject)Instantiate(slow);
				goo.transform.localPosition=new Vector3(-15,15,0);
			}
			this.transform.parent=GameObject.Find("P1Speed").transform;
		
		}else if (team == 2) {
			if (GameObject.Find ("Script/P2Speed").transform.childCount != 0)
			{GameObject.Find ("Script/P1Speed/accel").GetComponent<NETaccel>().num=0;}
			if(!jk)
			{
				
				goo=(GameObject)Instantiate(speed);
				goo.transform.localPosition=new Vector3(15,-15,0);
			}
			else if(jk)
			{
				
				goo=(GameObject)Instantiate(slow);
				goo.transform.localPosition=new Vector3(-15,-15,0);
			}
			
			this.transform.parent=GameObject.Find("P2Speed").transform;
		}


	
	}
	
	// Update is called once per frame
	void Update () {
		this.name = "accel";
		passtime += Time.deltaTime;

		switch (num) 
		{
		case 0:
			if(team==1)
			{
					NETnewtempoP2.scriptupdown=1f;
			}
			else if(team==2)
			{
					NETnewtempo.scriptupdown=1f;
				
			}
			Destroy(goo.gameObject);
			Destroy(this.gameObject);
			break;
		case 39:
			effecttime = 5f;
			if(team==1)
			{
				if(!jk)
				{NETnewtempoP2.scriptupdown=1.5f;}
				if(jk)
				{NETnewtempoP2.scriptupdown=0.8f;}

			}else if(team==2)
			{
				if(!jk)
				{NETnewtempo.scriptupdown=1.5f;}
				if(jk)
				{NETnewtempo.scriptupdown=0.8f;}
				
			}
			if(passtime>effecttime)
				{

					num=0;
				}

			break;
			case 40:
				effecttime = 10f;
				if(team==1)
				{
					if(!jk)
					{NETnewtempoP2.scriptupdown=1.5f;}
					if(jk)
					{NETnewtempoP2.scriptupdown=0.8f;}
					
				}else if(team==2)
				{
					if(!jk)
					{NETnewtempo.scriptupdown=1.5f;}
					if(jk)
					{NETnewtempo.scriptupdown=0.8f;}
					
				}
				if(passtime>effecttime)
				{
					
					num=0;
				}
				
				break;
			case 41:
				effecttime = 15f;
				if(team==1)
				{
					if(!jk)
					{NETnewtempoP2.scriptupdown=1.5f;}
					if(jk)
					{NETnewtempoP2.scriptupdown=0.8f;}
					
				}else if(team==2)
				{
					if(!jk)
					{NETnewtempo.scriptupdown=1.5f;}
					if(jk)
					{NETnewtempo.scriptupdown=0.8f;}
					
				}
				if(passtime>effecttime)
				{
					
					num=0;
				}
				
				break;
			case 42:
				effecttime = 5f;
				if(team==1)
				{
					if(!jk)
					{NETnewtempoP2.scriptupdown=2;}
					if(jk)
					{NETnewtempoP2.scriptupdown=0.6f;}
					
				}else if(team==2)
				{
					if(!jk)
					{NETnewtempo.scriptupdown=2;}
					if(jk)
					{NETnewtempo.scriptupdown=0.6f;}
					
				}
				if(passtime>effecttime)
				{
					
					num=0;
				}
				
				break;
			case 43:
				effecttime = 10f;
				if(team==1)
				{
					if(!jk)
					{NETnewtempoP2.scriptupdown=2;}
					if(jk)
					{NETnewtempoP2.scriptupdown=0.6f;}
					
				}else if(team==2)
				{
					if(!jk)
					{NETnewtempo.scriptupdown=2;}
					if(jk)
					{NETnewtempo.scriptupdown=0.6f;}
					
				}
				if(passtime>effecttime)
				{
					
					num=0;
				}
				
				break;
			case 44:
				effecttime = 15f;
				if(team==1)
				{
					if(!jk)
					{NETnewtempoP2.scriptupdown=2;}
					if(jk)
					{NETnewtempoP2.scriptupdown=0.6f;}
					
				}else if(team==2)
				{
					if(!jk)
					{NETnewtempo.scriptupdown=2;}
					if(jk)
					{NETnewtempo.scriptupdown=0.6f;}
					
				}
				if(passtime>effecttime)
				{
					
					num=0;
				}
				
				break;
			case 45:
				effecttime = 5f;
				if(team==1)
				{
					if(!jk)
					{NETnewtempoP2.scriptupdown=3;}
					if(jk)
					{NETnewtempoP2.scriptupdown=0.4f;}
					
				}else if(team==2)
				{
					if(!jk)
					{NETnewtempo.scriptupdown=3;}
					if(jk)
					{NETnewtempo.scriptupdown=0.4f;}
					
				}
				if(passtime>effecttime)
				{
					
					num=0;
				}
				
				break;
			case 46:
				effecttime = 10f;
				if(team==1)
				{
					if(!jk)
					{NETnewtempoP2.scriptupdown=3;}
					if(jk)
					{NETnewtempoP2.scriptupdown=0.4f;}
					
				}else if(team==2)
				{
					if(!jk)
					{NETnewtempo.scriptupdown=3;}
					if(jk)
					{NETnewtempo.scriptupdown=0.4f;}
					
				}
				if(passtime>effecttime)
				{
					
					num=0;
				}
				
				break;
			case 47:
				effecttime = 15f;
				if(team==1)
				{
					if(!jk)
					{NETnewtempoP2.scriptupdown=3;}
					if(jk)
					{NETnewtempoP2.scriptupdown=0.4f;}
					
				}else if(team==2)
				{
					if(!jk)
					{NETnewtempo.scriptupdown=3;}
					if(jk)
					{NETnewtempo.scriptupdown=0.4f;}
					
				}
				if(passtime>effecttime)
				{
					
					num=0;
				}
				
				break;

	
		}


	
	}
}

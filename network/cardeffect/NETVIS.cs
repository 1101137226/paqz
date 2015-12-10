using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class NETVIS : NetworkBehaviour {
	[SyncVar]public byte num;
	[SyncVar]public byte team;
	public  float passtime;
	// Use this for initialization
	void Start () {

		this.transform.parent = GameObject.Find ("other").transform;
	}
	
	// Update is called once per frame
	void Update () {
		passtime += Time.deltaTime;
		this.name="VIS";
		switch (num) {
		case 0:
			if (team == 1) 
			{
				NETnewtempoP2.isvis = false;
			} 
			else if (team == 2) 
			{
				NETnewtempo.isvis = false;
			}
			Destroy(this.gameObject);
			break;
		case 54:
			if (team == 1) 
			{
				NETnewtempoP2.isvis = true;
			} 
			else if (team == 2) 
			{
				NETnewtempo.isvis = true;
			}
			if(passtime>5f)
			{num=0;}
			break;
		case 55:
			if (team == 1) 
			{
				NETnewtempoP2.isvis = true;
			} 
			else if (team == 2) 
			{
				NETnewtempo.isvis = true;
			}
			if(passtime>7f)
			{num=0;}
			break;
		case 56:
			if (team == 1) 
			{
				NETnewtempoP2.isvis = true;
			} 
			else if (team == 2) 
			{
				NETnewtempo.isvis = true;
			}
			if(passtime>10f)
			{num=0;}
			break;
		
		
		
		
		
		
		
		
		
		
		
		}


	}
}

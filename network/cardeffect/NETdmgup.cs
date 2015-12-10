using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class NETdmgup : NetworkBehaviour {
	public byte num;
	public string master;
	public byte team;
	float effecttime;
	public  float passtime;
	GameObject target;

	// Use this for initialization
	void Start () {

		if (GameObject.Find ("Script/dmgup").transform.childCount != 0)
		{GameObject.Find ("Script/dmgup/upup").GetComponent<NETdmgup>().num=0;}



		this.transform.parent = GameObject.Find ("Script/dmgup").transform;

		target = GameObject.Find (master).gameObject;
		target.GetComponent<NETBS>().CmdGO(team);
	}

	// Update is called once per frame
	void Update () {
		this.name="upup";

		passtime += Time.deltaTime;
		switch (num) {
		case 0 :
			target.GetComponent<NETBS>().guup=1f;
			target.GetComponent<NETBS>().smup=1f;
			target.GetComponent<NETBS>().baup=1f;
			target.GetComponent<NETBS>().piup=1f;
			target.GetComponent<NETBS>().allup=1f;
			target.GetComponent<NETBS>().CmdDes(team);
			Destroy(this.gameObject);
			break;
		case 25:
			
			target.GetComponent<NETBS>().guup=1.5f;
			effecttime=15f;
			if(passtime>=effecttime)
			{target.GetComponent<NETBS>().guup=1f;target.GetComponent<NETBS>().CmdDes(team);Destroy(this.gameObject);}
			break;
		case 26:
			target.GetComponent<NETBS>().guup=2.0f;
			effecttime=13f;
			if(passtime>=effecttime)
			{target.GetComponent<NETBS>().guup=1f;target.GetComponent<NETBS>().CmdDes(team);Destroy(this.gameObject);}
			break;
		case 27:
			target.GetComponent<NETBS>().guup=3.0f;
			effecttime=10f;
			if(passtime>=effecttime)
			{target.GetComponent<NETBS>().guup=1f;target.GetComponent<NETBS>().CmdDes(team);Destroy(this.gameObject);}
			break;
		case 28:
			target.GetComponent<NETBS>().baup=1.5f;
			effecttime=15f;
			if(passtime>=effecttime)
			{target.GetComponent<NETBS>().baup=1f;target.GetComponent<NETBS>().CmdDes(team);Destroy(this.gameObject);}
			break;
		case 29:
			target.GetComponent<NETBS>().baup=2.0f;
			effecttime=13f;
			if(passtime>=effecttime)
			{target.GetComponent<NETBS>().baup=1f;target.GetComponent<NETBS>().CmdDes(team);Destroy(this.gameObject);}
			break;
		case 30:
			target.GetComponent<NETBS>().baup=3.0f;
			effecttime=10f;
			if(passtime>=effecttime)
			{target.GetComponent<NETBS>().baup=1f;target.GetComponent<NETBS>().CmdDes(team);Destroy(this.gameObject);}
			break;
		case 31:
			target.GetComponent<NETBS>().smup=1.5f;
			effecttime=15f;
			if(passtime>=effecttime)
			{target.GetComponent<NETBS>().smup=1f;target.GetComponent<NETBS>().CmdDes(team);Destroy(this.gameObject);}
			break;
		case 32:
			target.GetComponent<NETBS>().smup=2.0f;
			effecttime=13f;
			if(passtime>=effecttime)
			{target.GetComponent<NETBS>().smup=1f;target.GetComponent<NETBS>().CmdDes(team);Destroy(this.gameObject);}
			break;
		case 33:
			target.GetComponent<NETBS>().smup=3.0f;
			effecttime=10f;
			if(passtime>=effecttime)
			{target.GetComponent<NETBS>().smup=1f;target.GetComponent<NETBS>().CmdDes(team);Destroy(this.gameObject);}
			break;
		case 34:
			target.GetComponent<NETBS>().piup=1.5f;
			effecttime=15f;
			if(passtime>=effecttime)
			{target.GetComponent<NETBS>().piup=1f;target.GetComponent<NETBS>().CmdDes(team);Destroy(this.gameObject);}
			break;
		case 35:
			target.GetComponent<NETBS>().piup=2.0f;
			effecttime=13f;
			if(passtime>=effecttime)
			{target.GetComponent<NETBS>().piup=1f;target.GetComponent<NETBS>().CmdDes(team);Destroy(this.gameObject);}
			break;
		case 36:
			target.GetComponent<NETBS>().piup=3.0f;
			effecttime=10f;
			if(passtime>=effecttime)
			{target.GetComponent<NETBS>().piup=1f;target.GetComponent<NETBS>().CmdDes(team);Destroy(this.gameObject);}
			break;
		case 37:
			target.GetComponent<NETBS>().allup=1.5f;
			effecttime=13f;
			if(passtime>=effecttime)
			{target.GetComponent<NETBS>().allup=1f;target.GetComponent<NETBS>().CmdDes(team);Destroy(this.gameObject);}
			break;
		case 38:
			target.GetComponent<NETBS>().allup=2.0f;
			effecttime=10f;
			if(passtime>=effecttime)
			{target.GetComponent<NETBS>().allup=1f;target.GetComponent<NETBS>().CmdDes(team);Destroy(this.gameObject);}
			break;
			
			
			
		}






	
	}
}

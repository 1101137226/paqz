using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class NETBattleCtrl : NetworkBehaviour {

	public GameObject loww;
	public GameObject highh;
	GameObject low;
	Vector3 jpos;
	Vector3 kpos;
	bool inin;
	bool changeflag;

	Transform father;

	void Awake()
	{
		


		
	}
	// Use this for initialization
	void Start () {


		if (!isLocalPlayer) 
			return;
		father = GameObject.Find ("UIRoot").transform;
		
		GameObject[] p=GameObject.FindGameObjectsWithTag("Who");
		if (this.name == p [0].name) {
			jpos=new Vector3 (-10184, -718, 0);
			kpos=new Vector3 (-5184, -718, 0);
			
			this.transform.parent = father;
			this.transform.localPosition = jpos;
			this.transform.localScale = new Vector3 (800, 800, 800);
		} else if (this.name != p [0].name) {
			jpos=new Vector3 (-10184, 913, 0);
			kpos=new Vector3 (-5184, 913, 0);
			this.transform.parent = father;
			this.transform.localPosition = jpos;
			this.transform.localScale = new Vector3 (800, 800, 800);
			
		}
		

	}

	
	// Update is called once per frame
	void Update () {

	

		if (!isLocalPlayer)
			return;


		if(Input.GetKeyDown (KeyCode.K) && changeflag == true)
		{
			this.transform.localPosition=kpos;
		
			changeflag=false;

		}else if(Input.GetKeyDown (KeyCode.K) && changeflag == false)
		{
			this.transform.localPosition=jpos;
		
			changeflag=true;
			
		}





	}







	[Command]
	void CmdCreat(Vector3 pos,string name,GameObject what,bool who)
	{

		low = (GameObject)Instantiate(loww);

		NetworkServer.Spawn (low);

		
	}
	[Command]
	void CmdDestory()
	{
		
		
		
	}



}

using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class net : NetworkBehaviour{
 	public GameObject to;
	public GameObject to2;
	public Transform me;
	public float bpm;
	float time;
	public bool isdu;

	[SyncVar(hook="SyncStop")]public bool Stop=false;
	// Use this for initialization

	void Awake()
	{


		NETnewtempo.isba = false;
		NETnewtempo.isgu = false;
		NETnewtempo.ispi = false;
		NETnewtempo.issm = false;
		NETnewtempo.isvis = false;
		NETnewtempo.ispure = false;
		NETnewtempoP2.isba = false;
		NETnewtempoP2.isgu = false;
		NETnewtempoP2.ispi = false;
		NETnewtempoP2.issm = false;
		NETnewtempoP2.isvis = false;
		NETnewtempoP2.ispure = false;

	}
	void Start () {
		bpm = 0.8f;
	}
	void SyncStop(bool b)
	{

		Stop = b;
	
	}
	// Update is called once per frame
	void Update () {

		if (Stop)
		{
			time=0;
		}


		if (Stop)
			return;
		time += Time.deltaTime;		
		if (time > bpm) {
				
		
			CmdNew();
			time=0;
		
		}
				
	}
	[Command]
	public void CmdCreatDu()
	{
		if (this.tag == "P1Base") {
			GameObject too = (GameObject)Instantiate (to);
			

			too.GetComponent<NETnewtempo>().isdu=true;
			
			NetworkServer.Spawn (too);

		} else if (this.tag == "P2Base"){
			
			GameObject too = (GameObject)Instantiate (to2);
			
			too.GetComponent<NETnewtempoP2>().isdu=true;
			
			
			NetworkServer.Spawn (too);

			
		}
	
	}

	[Command]
	void CmdNew()
	{	

		if (this.tag == "P1Base") {
						GameObject too = (GameObject)Instantiate (to);


						

						NetworkServer.Spawn (too);

				} else if (this.tag == "P2Base"){
				
			GameObject too = (GameObject)Instantiate (to2);
			
			

			
			NetworkServer.Spawn (too);
		
		
		}
	}

}

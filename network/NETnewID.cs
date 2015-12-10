using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class NETnewID : NetworkBehaviour  {
	[SyncVar]private string playerID;
	[SyncVar]public byte ID;
	
	NetworkInstanceId NET_ID;
	Transform me;
	// Use this for initialization
	public override void OnStartLocalPlayer()
	{
		
		GetNETID();
		SetID();
		
		
	}
	void Awake () {
		me = transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (me.name == "" || me.name == "NETjk(Clone)") {
			
			
			
			SetID();
		}
		
		
	}
	
	[Client]
	void GetNETID()
	{
		NET_ID = this.GetComponent<NetworkIdentity> ().netId;
		
		CmdSayMyID(myID());
		
		
	}
	void SetID()
	{
		if (!isLocalPlayer) {
			
			me.name = playerID;
			
			
		} else {
			
			
			me.name=myID();
			
		}
		
	}
	string myID()
	{
		string Name = "Player" + System.Convert.ToString(NET_ID);
		return Name;
		
	}
	[Command]
	void CmdSayMyID(string name)
	{
		
		playerID = name;
		
		
	}
}

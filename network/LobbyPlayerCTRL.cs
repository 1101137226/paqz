using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class LobbyPlayerCTRL : NetworkLobbyPlayer
{
	[SyncVar(hook="myNameChange")]
	public string
		myname;
	[SyncVar]
	private string
		playerID;
	[SyncVar]
	public byte
		ID;
	NetworkInstanceId NET_ID;
	Transform me;
	[SyncVar(hook="biger")]
	public bool bigg;
	public GameObject mapselect;

	public override void OnClientEnterLobby ()
	{
		base.OnClientEnterLobby ();

		//if we return from a game, color of text can still be the one for "Ready"

		//setup the player data on UI. The value are SyncVar so the player
		//will be created with the right value currently on server
	}

	void biger (bool b)
	{

		bigg = b;
	
	}

	void myNameChange (string n)
	{
		myname = n;
	}

	void Awake ()
	{
		me = transform;
		mapselect = GameObject.Find ("donotkillme").gameObject;
	}

	[Command]
	void CmdMap ()
	{
		mapselect.GetComponent<NETmapselect> ().mapnum = GameObject.Find ("Stage").GetComponent<VSStageManager> ().battle_Stage;


	}

	[Command]
	void Cmdnnn (string n)
	{

		myname = n;
	}

	[Command]
	void Cmdbbb (bool b)
	{
		
		bigg = b;
	}

	void Update ()
	{
				
		if (me.name != myname) {
			GetNETID ();
			SetID ();
		}

		if (Application.loadedLevelName == "vsroom") {


			if (isLocalPlayer) {
				Cmdnnn (GameObject.Find ("Name").GetComponent<UIInput> ().value);
				GameObject.Find ("Ready").GetComponent<NETReady> ().master = myname;
			}
			if (GameObject.Find ("Previous").GetComponent<VSStageSelect> ().ismove) {
				
				GameObject.Find ("Previous").GetComponent<VSStageSelect> ().ismove = false;
				CmdMap ();
		
			}
			if (GameObject.Find ("Next").GetComponent<VSStageSelect> ().ismove) {
			
				GameObject.Find ("Next").GetComponent<VSStageSelect> ().ismove = false;
				CmdMap ();
			
			}
			if (isLocalPlayer) {
				Cmdbbb (GameObject.Find ("Cli").GetComponent<gotoothernetwork> ().big);
			}

				
		} else {
				
			if (bigg) {

				GameObject.Find ("P2name").GetComponent<UILabel> ().text = this.name;

			} else if (!bigg) {

				GameObject.Find ("P1name").GetComponent<UILabel> ().text = this.name;
			}
		
		}
	}

	public void NOTReady ()
	{
		readyToBegin = false;
	}
	
	public void GetReady ()
	{
		SendReadyToBeginMessage ();
	}
	
	[Client]
	void GetNETID ()
	{
		NET_ID = this.GetComponent<NetworkIdentity> ().netId;
		
		CmdSayMyID (myID ());
	}

	void SetID ()
	{
		if (!isLocalPlayer) {
			me.name = playerID;
		} else {
			me.name = myID ();
		}
	}

	string myID ()
	{
		string Name = myname;
		return Name;
	}

	[Command]
	void CmdSayMyID (string name)
	{
		playerID = name;
	}
}

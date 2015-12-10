using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class NETnewtempoP2 : NetworkBehaviour {
	public float timer;
	public static int speed;
	public float nowPosition;
	public static bool isgu;
	public static bool ispi;
	public static bool issm;
	public static bool isba; 
	public static bool issonic;
	public static bool isvis;
	public static bool ispure;

	public Texture2D sonic;
	public Texture2D gu;
	public Texture2D pi;
	public Texture2D ba;
	public Texture2D sm;
	public Texture2D pure;
	public Texture2D du;
	string who;
	public static float scriptupdown;
	bool inin;
	float givetime;
	Transform P1;
	Transform P2;
	[SyncVar(hook="DUDU")]public bool isdu=false;
	[SyncVar(hook="todoku")]public bool todoke=false;
	[SyncVar(hook="gave")]public bool give=false;
	[SyncVar(hook="gotout")]public bool getout=false;
	[SyncVar(hook="Sdie1")]public bool die1=false;

	[SyncVar(hook="SyncDead")]public bool Dead = false;
	// Use this for initialization
	void Start () {
		inin = true;
		todoke = false;
		give = false;
		P1 = GameObject.Find ("P1").transform;
		P2 = GameObject.Find ("P2").transform;
		this.transform.parent=GameObject.Find("P2").transform;
			this.transform.localPosition=new Vector3(17000,0, -100);
			this.transform.localScale=new Vector3(800,800,800);
		scriptupdown = 1f;
		speed = 12000;
	}
	void todoku(bool t)
	{
		todoke = t;
		
	}
	void gave(bool g)
	{
		give = g;
		
	}
	void gotout(bool g)
	{
		
		getout = g;
	}
	void DUDU(bool d)
	{
		isdu = du;

	}
	void Sdie1(bool d)
	{
		
		die1 = d;
	}
	void SyncDead(bool de)
	{

		Dead = de;
	
	}


	// Update is called once per frame
	void Update () {

		nowPosition = 17000 - timer * speed*scriptupdown;
		if (Dead) {
			if(inin)
			{
				string aaaa=	GameObject.Find("UIRoot").GetComponent<NETSAVE>().thisname;
				
				GameObject.Find(aaaa).GetComponent<NETBS>().CmdDie(this.gameObject);

				inin=false;
			}

		}
	
		if (give) 
		{
			todoke=false;
			getout=false;
			givetime+=Time.deltaTime;
			this.transform.localPosition=new Vector3(nowPosition,0-givetime*5000,0);
			if(givetime>0.3f)
			{

				this.tag="P1";
				this.transform.parent = P1;

			
			}
			
		}
		if (todoke) 
		{
			give=false;
			getout=false;
			givetime+=Time.deltaTime;
			this.transform.localPosition=new Vector3(nowPosition,0+givetime*5000,0);
			if(givetime>0.3f)
			{

				this.tag="P2";
				this.transform.parent = P2;

			}
			
		}
		if (getout) 
		{
			give=false;
			todoke=false;
			givetime+=Time.deltaTime;

			if(this.tag=="P1")
			{this.transform.localPosition=new Vector3(nowPosition,0-givetime*10000,0);}
			else if(this.tag=="P2")
			{this.transform.localPosition=new Vector3(nowPosition,0+givetime*10000,0);}
			if(givetime>0.3f)
			{
				Destroy(this.gameObject);
				NetworkServer.Destroy (this.gameObject);
			}
			
		}
		if (givetime > 0.33f)
		{
			give=false;
			todoke=false;
			
		}
		if(this.tag=="P2" && !todoke && !give  && !getout)
		{

		timer += Time.deltaTime;
		this.transform.localPosition=new Vector3(nowPosition,0, -100);
			if(Dead)
			{
				this.GetComponent<UITexture> ().mainTexture =null;
				
			}
			else if (issonic && !ispure) 
		{
			this.GetComponent<UITexture> ().mainTexture = sonic;
		}
			else if(isdu && !ispure)
		{
			this.GetComponent<UITexture> ().mainTexture =du;
				
		}
			else if (isgu && !ispure)
		{
			this.GetComponent<UITexture> ().mainTexture = gu;
			
		} 
			else if(isba && !ispure)
		{
			this.GetComponent<UITexture> ().mainTexture = ba;
		}
			else if(issm && !ispure)
		{
			this.GetComponent<UITexture> ().mainTexture = sm;
		}
			else if(ispi && !ispure)
		{
			this.GetComponent<UITexture> ().mainTexture = pi;
		}
		else {
			this.GetComponent<UITexture>().mainTexture=pure;
		}

		if (isvis) {
			this.GetComponent<UITexture>().color=new Color(255,255,255,0.1f);	
		}else 
		{
			this.GetComponent<UITexture>().color=new Color(255,255,255,1f);
		}

		}else if(this.tag=="P1" && !todoke && !give  && !getout)
		{
			
			timer += Time.deltaTime;
			this.GetComponent<NetworkTransform>().transform.localPosition=new Vector3(nowPosition,0, -100);
			if(Dead)
			{
				this.GetComponent<UITexture> ().mainTexture =null;
				
			}
			else if (NETnewtempo.issonic) 
			{
				this.GetComponent<UITexture> ().mainTexture = sonic;
			}
			else if (NETnewtempo.isgu)
			{
				this.GetComponent<UITexture> ().mainTexture = gu;
				
			} 
			else if(NETnewtempo.isba)
			{
				this.GetComponent<UITexture> ().mainTexture = ba;
			}
			else if(NETnewtempo.issm)
			{
				this.GetComponent<UITexture> ().mainTexture = sm;
			}
			else if(NETnewtempo.ispi)
			{
				this.GetComponent<UITexture> ().mainTexture = pi;
			}
			else {
				this.GetComponent<UITexture>().mainTexture=pure;
			}
			
			if (NETnewtempo.isvis) {
				this.GetComponent<UITexture>().color=new Color(255,255,255,0.1f);	
			}else 
			{
				this.GetComponent<UITexture>().color=new Color(255,255,255,1f);
			}
			
		}



		if (this.transform.position.x <= -35f) {
			if(!Dead)
			{
			byte t=GameObject.Find("UIRoot").GetComponent<NETSAVE>().thisteam;
			string w=GameObject.Find("UIRoot").GetComponent<NETSAVE>().thisname;
			
			if(this.tag=="P1" && t==1)
			{
				GameObject.Find (w).GetComponent<NETBS> ().CmdComboZero();
				GameObject.Find (w).GetComponent<NETBS> ().drawcombo = 0;
			}
			if(this.tag=="P2"&&t==2)
			{
				GameObject.Find (w).GetComponent<NETBS> ().CmdComboZero();
				GameObject.Find (w).GetComponent<NETBS> ().drawcombo = 0;
				
			}
			}
			NetworkServer.Destroy (this.gameObject);
			Destroy(this.gameObject);
			
		}
		

	}
}

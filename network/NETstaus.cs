using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class NETstaus : NetworkBehaviour {
	public  float maxhp;
	[SyncVar(hook="Hurt")]public  float nowhp;
	public byte team;
	[SyncVar(hook="DefUpDown")]public  float nowdeff;
	public  float hurt;
	[SyncVar(hook="AtkUpDown")]public  float nowatk;
	public float rec;
	Queue defupup =new Queue();
    Queue atkupup =new Queue();
	float defuptime;
	float atkuptime;
	public string name;
	[SyncVar(hook="Reduce")]public byte reduceflag;
	float time;
	[SyncVar(hook="ReduceTime")]float reducetime;
	GameObject mybar;
	[SyncVar(hook="Syncweakrec")]public bool weakrec=false;
	[SyncVar(hook="Syncweakdef")]public float weakbrokendef=0f;
	[SyncVar(hook="SyncDie")]public byte die=0;
	[SyncVar(hook="SyncReady")]public bool ready=false;

	// Use this for initialization
	void Start () {

		
		PlayerPrefs.SetFloat("ATK",1200);
		maxhp=PlayerPrefs.GetFloat("HP")*0.5f;

		nowhp = maxhp;

		nowatk=PlayerPrefs.GetFloat("ATK")*3f;
		rec=PlayerPrefs.GetFloat("REC")*0.5f;
		nowdeff=PlayerPrefs.GetFloat("DEF")*0.25f;
		team = this.GetComponent<NETBS> ().ourteam;
		if (team == 1) {
				
			mybar=GameObject.Find("hpbar").gameObject;
		
		}else if (team == 2) {
			
			mybar=GameObject.Find("ehpbar").gameObject;
			
		}
		weakrec = false;
		weakbrokendef = 1f;
	}
	void SyncReady(bool s)
	{
		
		ready = s;
		
	}
	[Command]
	public void CmdReset()
	{
		nowhp = maxhp;
		
		nowatk=PlayerPrefs.GetFloat("ATK")*3f;
		rec=PlayerPrefs.GetFloat("REC")*0.5f;
		nowdeff=PlayerPrefs.GetFloat("DEF")*0.25f;
		atkupup.Clear();
		defupup.Clear();

	
	}
	[Command]
	public	void CmdSet()
	{
		if (!ready) {
				
			ready=true;
		}else if (ready) {
			
			ready=false;
		}
		
	}

	void Syncweakrec(bool w)
	{

		weakrec = w;
	
	}
	void Syncweakdef(float w)
	{

		weakbrokendef = w;
	}
	void SyncDie(byte d)
	{

		die = d;
	}
	public void Heal(float up)
	{
		nowhp += up;
	
	}

	[Command]
	public void CmdHealDmg(float dmg)
	{

	
	}
	public void Gethurt(float dmg)
	{
		if (!weakrec) {
						if (dmg > nowdeff * 1.5f) {
								if (reduceflag == 1) {
										nowhp -= 1;
								} else {
										nowhp = nowhp - (dmg - nowdeff * 1.5f);
								}
								if (nowhp > maxhp) {
										nowhp = maxhp;
								}
		
						}
				}
		else if (weakrec) 
		{
				
			nowhp+=dmg;
			if(nowhp>maxhp)
			{nowhp=maxhp;}
		}
	
	}
	public void GetBass(bool jork)
	{
		if (!jork) 
		{nowdeff = nowdeff * 0.95f;}
		else if(jork)
		{
			nowdeff-=nowdeff*0.01f;


		}
	
	}

	public void GetPiano(bool jork,float up)
	{
		
		if (!jork) 
		{
				
	//		nowdeff+=10;
			CmdDefUp();
		}
		if (jork) 
		{
				
			nowdeff+=up;
		
		}

	}
	public void GetGu()
	{
		CmdGuAtkUP();
	
	}
	public void Getreduce(byte n)
	{

		if (n == 48) 
		{reducetime = 3f;}
		if (n == 49) 
		{reducetime = 4f;}
		if (n == 50) 
		{reducetime = 5f;}
		CmdSetreduceflag();
	}
	public void GetBoom(float p)
	{
		float d = nowhp*(p/100f);
		CmdGetBoomHurt (d);
	
	}
	void Reduce(byte r)
	{
		reduceflag = r;
	}
	void DefUpDown(float d)
	{
		nowdeff = d;
	}
	void AtkUpDown(float a)
	{
		nowatk=a;
	}
	void Hurt(float h)
	{
		nowhp = h;
	 
	
	}
	void ReduceTime(float r)
	{
		reducetime = r;
	}
	[Command]
	void CmdGetBoomHurt(float dmg)
	{
		if(!weakrec)
		{nowhp -= dmg;}
		else if(weakrec)
		{
			nowhp+=dmg;
			if(nowhp>maxhp)
			{nowhp=maxhp;}
		}
	}
	[Command]
	void CmdDefUp()
	{
		defupup.Enqueue("0");
		nowdeff += 10;
	
	}
	[Command]
	void CmdDefDown()
	{

		nowdeff -= 10;
	}
	[Command]
	public void CmdBassAttackUPDEF(float up)
	{
		
		nowdeff += up*0.01f;
	}
	[Command]
	void CmdGuAtkUP()
	{
		atkupup.Enqueue("0");
		nowatk += nowatk * 0.05f;
	
	}
	[Command]
	void CmdGuAtkDown()
	{

		nowatk -= nowatk * 0.05f;
			
	}
	[Command]
	void Cmdredecezero()
	{
		reduceflag = 0;

	}
	[Command]
	void CmdSetreduceflag()
	{

		reduceflag = 1;
	
	}
	// Update is called once per frame
	void Update () {

		if (reduceflag==1)
		{
			time+=Time.deltaTime;

			if(time>=reducetime)
			{
				reducetime=0;
				time=0;
				Cmdredecezero();

			}
		
		}

		if (defupup.Count > 0) {
			defuptime += Time.deltaTime;
			if(defuptime>=10)
			{
				CmdDefDown();
				defupup.Dequeue();
				defuptime=0f;
				
			}
			
		}

		if (atkupup.Count > 0) {
			atkuptime += Time.deltaTime;
			
			if(atkuptime>=5)
			{	
				CmdGuAtkDown();

				atkupup.Dequeue();
				atkuptime=0f;
				
			}
			
			
		}
		if (team == 1) {
			
			mybar.GetComponent<UISprite>().fillAmount = (float)(nowhp/maxhp)*0.75f;
			
		}else if (team == 2) {
			
			mybar.GetComponent<UISprite>().fillAmount = (float)(nowhp/maxhp)*0.75f+0.25f;
			
		}

	
	}
}

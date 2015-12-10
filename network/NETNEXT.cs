using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class NETNEXT : NetworkBehaviour {
	public GameObject master;
	public GameObject target;
	 UIGrid grid;
	 UIGrid grid2;
	public bool con=false;
	int a;
	int b;
	public byte team;
	public bool aa;
	public bool bb;
	bool inin;
	[SyncVar(hook="SyncCC")]public bool cc;
	// Use this for initialization
	void Start () {
		GameObject one=(GameObject)Instantiate(Resources.Load("NET/Main"));
		GameObject two=(GameObject)Instantiate(Resources.Load("NET/Sub"));
		GameObject three=(GameObject)Instantiate(Resources.Load("NET/Start"));
		one.transform.parent = this.transform;
		one.transform.localPosition = new Vector3 (62, 62, 0);
		two.transform.parent = this.transform;
		two.transform.localPosition = new Vector3 (62, -82, 0);
		three.transform.parent = this.transform;
		three.transform.localPosition = new Vector3 (67, -151, 0);
		int a = 0;
		int b = 0;
		cc = false;
		inin = true;
		this.transform.parent = GameObject.Find ("UIRoot").transform;
		this.transform.localPosition = new Vector3 (-4200, 1000, 1000);
		this.transform.GetChild (0).GetComponent<UISprite> ().depth = 50;
		this.transform.GetChild (1).GetComponent<UISprite> ().depth = 50;
		this.transform.GetChild (2).GetComponent<UISprite> ().depth = 50;

		master = GameObject.Find (GameObject.Find ("UIRoot").GetComponent<NETSAVE> ().thisname).gameObject;
		team = GameObject.Find ("UIRoot").GetComponent<NETSAVE> ().thisteam;

		grid = GameObject.Find (this.name + "Main(Clone)/maindeck").GetComponent<UIGrid>();
		grid2 = GameObject.Find (this.name + "Sub(Clone)/subdeck").GetComponent<UIGrid>();
		for (int i=0; i<30; i++) {
			if(master.GetComponent<NETBS>().handd.Count==0)
			{
				break;
			}
			string aa=(string)master.GetComponent<NETBS>().handd.Dequeue();
		
			GameObject to=(GameObject)Instantiate(Resources.Load("NETPIC/PIC_0"+aa));
			to.transform.parent=grid.transform;
			to.transform.localScale=new Vector3(1,1,1);
			to.GetComponent<UI2DSprite> ().depth = 50;

		}

		
		for (int i=0; i<20; i++) {
			if(master.GetComponent<NETBS>().Sub.Count==0)
			{
				break;
			}
			string aa=(string)master.GetComponent<NETBS>().Sub.Dequeue();
			GameObject to=(GameObject)Instantiate(Resources.Load("NETPIC/PIC_0"+aa));
			to.transform.parent=grid2.transform;
			to.transform.localScale=new Vector3(1,1,1);
			to.GetComponent<UI2DSprite> ().depth = 50;
		}

		grid.repositionNow = true;
		grid2.repositionNow = true;
		this.transform.localScale = new Vector3 (25, 25, 25);



		
		GameObject[] p=GameObject.FindGameObjectsWithTag("Who");
		
		if (p [0].name == master.name) {
			target=p[1].gameObject;
			
			
		} else if (p [1].name == master.name) {
			
			
			target=p[0].gameObject;
		}
		GameObject Script = GameObject.Find ("Script").gameObject;
		for (int c=0; c<12; c++) 
		{
			GameObject ScriptType=Script.transform.GetChild(c).gameObject;
			
			if(ScriptType.transform.childCount!=0)
			{
				GameObject ScriptName =ScriptType.transform.GetChild(0).gameObject;
				string ccc=ScriptName.name;
				
				if(ScriptType.name=="other")
				{
					int am	=ScriptType.transform.childCount;
					for(int t=0;t<am;t++)
					{
						string ccb=ScriptType.transform.GetChild(t).name;
						if(ccb=="dmgheal")
						{
							
							ScriptType.transform.GetChild(t).GetComponent<NETdmgheal>().passtime=100f;
							
						}else if(ccb=="JK")
						{
							
							ScriptType.transform.GetChild(t).GetComponent<NETJKctrl>().passtime=100f;
							
						}else if(ccb=="GOPure")
						{
							
							ScriptType.transform.GetChild(t).GetComponent<NETNOE>().passtime=100f;
							
						}else if(ccb=="SPC")
						{
							
							ScriptType.transform.GetChild(t).GetComponent<NETSPC>().passtime=100f;
							
						}else if(ccb=="VIS")
						{
							
							ScriptType.transform.GetChild(t).GetComponent<NETVIS>().passtime=100f;
							
						}
						
						
						
					}
					
					
					
				}
				else if(ccc=="accel")
				{
					
					ScriptName.GetComponent<NETaccel>().passtime=100f;
					
				}else if(ccc=="Boom")
				{
					
					Destroy(ScriptName.gameObject);
					
				}else if(ccc=="change")
				{
					
					ScriptName.GetComponent<NETchange>().passtime=100f;
					
				}else if(ccc=="upup")
				{
					
					ScriptName.GetComponent<NETdmgup>().passtime=100f;
					
				}else if(ccc=="DU")
				{
					
					Destroy(ScriptName.gameObject);
					
				}
				
				
				
				
				
			}

		}

		master.GetComponent<NETBS> ().Stop = true;
		target.GetComponent<NETBS> ().Stop = true;
		GameObject.Find("P1").GetComponent<net> ().Stop = true;
		GameObject.Find("P2").GetComponent<net> ().Stop = true;
	}
	[Command]
	void CmdCC()
	{
		cc = true;

	}
	void SyncCC(bool s)
	{

		cc = s;
	
	}
	// Update is called once per frame
	void Update () {

		 aa = master.GetComponent<NETstaus> ().ready;
		 bb = target.GetComponent<NETstaus> ().ready;
		if (aa && bb) {
				
		
			cc=true;
		
		}

		if (cc) {
			if(inin)
			{
			Debug.Log("123");
			GameObject aaa=GameObject.Find (this.name + "Main(Clone)/maindeck").gameObject;
			GameObject bbb=GameObject.Find (this.name + "Sub(Clone)/subdeck").gameObject;
			 a=aaa.transform.childCount;
			 b=bbb.transform.childCount;

			string [] deck=new string[30];
			Debug.Log(a);

			for (int i=0; i<a; i++) {
				Debug.Log(i);

				string abc =aaa.transform.GetChild (i).GetComponent<UI2DSprite> ().sprite2D.name;
				deck[i]=abc;
				


			}
			for (int q=1; q<1000; q++) {
				
				int o = Random.Range (0, a);
				int p = Random.Range (0, a);
				
				string change = deck [o];
				deck [o] = deck [p];
				deck [p] = change;
				
				
				
			}
			for (int i=a-1; i>=0; i--) {

				master.GetComponent<NETBS>().handd.Enqueue(deck[i]);
				
				
				
			}
			for (int i=b-1; i>=0; i--) {
				
				//	PlayerPrefs.SetInt ("001_amount", 3);
				//Debug.Log (aaa.transform.GetChild (i).GetComponent<UI2DSprite> ().sprite2D.name);
				string abc =bbb.transform.GetChild (i).GetComponent<UI2DSprite> ().sprite2D.name;
				master.GetComponent<NETBS>().Sub.Enqueue(abc);
				
				
				
			}
			master.GetComponent<NETBS>().deckleft=(short)master.GetComponent<NETBS>().handd.Count;
			
			master.GetComponent<NETstaus>().CmdSet();
			master.GetComponent<NETBS> ().Stop = false;

				master.GetComponent<NETstaus>().CmdReset();
				
				master.GetComponent<NETBS>().DrawFull();

			
			
				inin=false;
			}

			if(!aa && !bb)
			{
				GameObject.Find("P1").GetComponent<net> ().Stop = false;
				GameObject.Find("P2").GetComponent<net> ().Stop = false;

				Destroy(this.gameObject);
				NetworkServer.Destroy(this.gameObject);

			}

		}



	
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class NETSPC : NetworkBehaviour {
	[SyncVar]public byte team;
	[SyncVar]public byte num;
	[SyncVar]public string master;
	[SyncVar]public bool jk;
	byte n;
	public float passtime;
	bool where;
	GameObject me;
	GameObject target;
	short startcombo;
	short jcombo;
	short kcombo;
	bool inin;
	byte mecounter=0;
	byte targetcounter=0;
	public GameObject eff1;
	public GameObject eff2;
	GameObject r;
	// Use this for initialization
	void Start () {
		byte t = GameObject.Find ("UIRoot").GetComponent<NETSAVE> ().thisteam;
		if (team == t) {
				
						where = false;
		
				} else if (team != t) {
				
		
			where=true;
				}

		GameObject[] p=GameObject.FindGameObjectsWithTag("Who");
		if (p [0].name == master) {
			
			me =	p[0].gameObject;
			target = p [1].gameObject;
			
		} else if (p [1].name == master) {

			me =	p[1].gameObject;
			target = p [0].gameObject;
			
		}
		if(num!=73 && num!=74 && num!=75)
		{me.GetComponent<NETBS>().isspc=true;}
		inin = true;
		n = num;


		mecounter=0;
		targetcounter=0;
		this.transform.parent = GameObject.Find ("other").transform;

	} 
	
	// Update is called once per frame
	void Update () {
		this.name = "SPC";
		passtime += Time.deltaTime;
	switch (num) 
		{
		case 0:
			if(n!=73 && n!=74 && n!=75)
			{me.GetComponent<NETBS>().isspc=false;}
			Destroy(this.gameObject);
			if(team==1)
			{
				
				NETnewtempo.issonic=false;
			}else if(team==2)
			{
				
				NETnewtempoP2.issonic=false;
				
			}
			
			num=0;

			break;
		case 70:
			if(inin)
			{
				startcombo = me.GetComponent<NETBS> ().combo;
				inin=false;
			}
			short combo=me.GetComponent<NETBS> ().combo;
			if(combo==0)
			{
				startcombo=0;
				jcombo=0;
				kcombo=0;

			}
			if(combo>startcombo)
			{
				startcombo=combo;
				bool jork 	=	me.GetComponent< NETBS>().jk;

			if(!jork)
				{
					jcombo++;
					if(jcombo>=2)
					{
						jcombo=0;
							if(team==1)
							{
								string tar="P2";
								foreach(GameObject fooObj in GameObject.FindGameObjectsWithTag(tar))
								{
								if(fooObj.name=="NETnoeff(Clone)")
								{
									fooObj.GetComponent<NETnewtempo>().give=true;
								}
								if(fooObj.name=="NETnoeffP2(Clone)")
								{
									fooObj.GetComponent<NETnewtempoP2>().give=true;
								}
								break;
								}
							}else if(team==2)
							{
								string tar="P1";
								foreach(GameObject fooObj in GameObject.FindGameObjectsWithTag(tar))
								{
								if(fooObj.name=="NETnoeff(Clone)")
								{
									fooObj.GetComponent<NETnewtempo>().todoke=true;
								}
								else if(fooObj.name=="NETnoeffP2(Clone)")
								{
									fooObj.GetComponent<NETnewtempoP2>().todoke=true;
								}
								break;
								}
							}
					
					}
					kcombo=0;

				}else if(jork)
				{
					jcombo=0;
					kcombo++;
					if(kcombo>=4)
					{
						kcombo=0;
						if(team==1)
						{
							string tar="P2";

							foreach(GameObject fooObj in GameObject.FindGameObjectsWithTag(tar))
							{

								if(fooObj.name=="NETnoeff(Clone)")
								{
									fooObj.GetComponent<NETnewtempo>().getout=true;
								}
								if(fooObj.name=="NETnoeffP2(Clone)")
								{
									fooObj.GetComponent<NETnewtempoP2>().getout=true;

								}
								break;
							}
						}else if(team==2)
						{
							string tar="P1";
							foreach(GameObject fooObj in GameObject.FindGameObjectsWithTag(tar))
							{
								if(fooObj.name=="NETnoeff(Clone)")
								{
									fooObj.GetComponent<NETnewtempo>().getout=true;
								}
								else if(fooObj.name=="NETnoeffP2(Clone)")
								{
									fooObj.GetComponent<NETnewtempoP2>().getout=true;
								}
								break;
							}
						}
						
					}

				}

			}

			if(passtime>10f)
			{
				num=0;
			}

			break;
		case 71:

				if(passtime<5f)
				{
					if(!jk)
					{

						if(inin)
						{
						if(where)
						{
							startcombo = target.GetComponent<NETBS> ().combo;
						}
							inin=false;
						}
						if(where)
						{
						short comboo=target.GetComponent<NETBS> ().combo;
						if(comboo==0)
						{
							startcombo=0;

						}
						if(comboo>startcombo)
						{
							target.GetComponent<NETBS>().heald(target.GetComponent<NETstaus>().rec);

						}

						startcombo=comboo;
					}
					}else if(jk)
					{
					if(where)
					{
						target.GetComponent<NETBS>().weakup=2f;
					}
					if(inin)
					{
						if(team==1)
						{
							r=(GameObject)Instantiate(eff2);
						}
						if(team==2)
						{
							r=(GameObject)Instantiate(eff1);
						}
						inin=false;
					}
						if(passtime>=4.9f)
						{
						if(where)
						{
							target.GetComponent<NETBS>().weakup=1f;
						}
						Destroy(r.gameObject);

						}
					}

				}



				if(passtime>5f)
				{
					if(!jk)
				{
					if(!inin)
					{
						if(team==1)
						{
							r=(GameObject)Instantiate(eff1);
						}
						if(team==2)
						{
							r=(GameObject)Instantiate(eff2);
						}
						inin=true;

					}
					me.GetComponent<NETBS>().weakup=2f;
					target.GetComponent<NETstaus>().weakbrokendef=0f;
				}else if(jk)
				{


					me.GetComponent<NETstaus>().weakrec=true;

				}

				}


			if(passtime>10f)
			{


				if(!jk)
				{
					Destroy(r.gameObject);

				}
				me.GetComponent<NETBS>().weakup=1f;

				target.GetComponent<NETstaus>().weakbrokendef=1f;
				me.GetComponent<NETstaus>().weakrec=false;

				num=0;

			}




			break;
		case 72:
			if(!jk)
			{
				if(inin)
				{
					if(team==1)
					{
						r=(GameObject)Instantiate(eff1);
					}
					if(team==2)
					{
						r=(GameObject)Instantiate(eff2);
					}
					inin=false;
				}
			me.GetComponent<NETBS>().powerup=4f;
			}
			else if(jk)
			{

				me.GetComponent<NETstaus>().nowhp=me.GetComponent<NETstaus>().maxhp*0.5f;
				me.GetComponent<NETstaus>().nowatk+=me.GetComponent<NETstaus>().nowatk*0.5f;
				me.GetComponent<NETstaus>().nowdeff=me.GetComponent<NETstaus>().nowdeff*0.5f;
				num=0;
			}

			if(passtime>10f)
			{
				if(team==1)
				{
					Destroy(GameObject.Find("P1eff(Clone)").gameObject);

				}else if(team==2)
				{
					Destroy(GameObject.Find("P2eff(Clone)").gameObject);
					
				}
				me.GetComponent<NETBS>().powerup=0f;
				me.GetComponent<NETstaus>().nowhp=me.GetComponent<NETstaus>().nowhp*0.5f;
				num=0;

			}
			break;
		case 73:

			if(inin && passtime>0.8f && passtime<1.5f)
			{
				for(int i=0;i<5;i++)
				{

				if(!where)
				{
					if(me.GetComponent<NETBS>().ishand[i])
					{


						me.GetComponent<NETBS>().ishand[i]=false;
						GameObject.Find(i.ToString()).GetComponent<carddis>().poi=true;
						me.GetComponent<NETBS>().CmdCDis(i.ToString()+"S");
						mecounter++;
					

					}
				}
				if(where)
				{

					if(target.GetComponent<NETBS>().ishand[i])
					{
						
						
						target.GetComponent<NETBS>().ishand[i]=false;
						GameObject.Find(i.ToString()).GetComponent<carddis>().poi=true;
						target.GetComponent<NETBS>().CmdCDis(i.ToString()+"S");
						targetcounter++;
						
						
					}

				}

				}
		
				inin=false;
			}

			if(passtime>1.5f && !inin)
			{
				if(!where)
				{
				for(int i=0;i<mecounter;i++)
				{
						me.GetComponent<NETBS>().Draw();
					

				}
				}
				if(where)
				{
					for(int i=0;i<targetcounter;i++)
					{
						target.GetComponent<NETBS>().Draw();
						
						
					}
				}
				inin=true;
			}
			if(passtime>1.8f)
			{
				num=0;
			}
			break;
		case 74:

			if(where)
			{

				Random.seed = System.Guid.NewGuid().GetHashCode();	
				int i= Random.Range(0,4);

				target.GetComponent<NETBS>().ishand[i]=false;
				GameObject.Find(i.ToString()).GetComponent<carddis>().poi=true;
				target.GetComponent<NETBS>().CmdCDis(i.ToString()+"S");
				num=0;
			

			}
			break;
		case 75:
			if(!where)
			{
			if(inin)
			{
					int [] b = new int[5];

					for(int i=0;i<5;i++)
					{
						if(!me.GetComponent<NETBS>().ishand[i])
						{
							mecounter++;

						}else if(me.GetComponent<NETBS>().ishand[i])
						{


							b[targetcounter]=i;
							targetcounter++;
						}

					}
					if(mecounter==5)
					{
						num=0;

					}
					Random.seed = System.Guid.NewGuid().GetHashCode();	
					int j= Random.Range(0,System.Convert.ToInt16(targetcounter));

					me.GetComponent<NETBS>().ishand[b[j]]=false;
					GameObject.Find(b[j].ToString()).GetComponent<carddis>().poi=true;
					me.GetComponent<NETBS>().CmdCDis(b[j].ToString()+"S");


					inin=false;
			}

				if(passtime>1f)
				{
					me.GetComponent<NETBS>().Draw();
					me.GetComponent<NETBS>().Draw();
					where=true;

				}

			}
			if(passtime>1.5f)
			{
			
				num=0;
			}
			break;
		case 80:

			if(team==1)
			{

				NETnewtempo.issonic=true;
			}else if(team==2)
			{

				NETnewtempoP2.issonic=true;

			}
			if(passtime>=10f)
			{
				if(team==1)
				{
					
					NETnewtempo.issonic=false;
				}else if(team==2)
				{
					
					NETnewtempoP2.issonic=false;
					
				}

				num=0;

			}

			break;
		
		}
	}
}

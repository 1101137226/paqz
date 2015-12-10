using UnityEngine;
using System.Collections;

public class boss10map : MonoBehaviour {
	public float HP;
	float skilldelaytime;
	public static byte noise;
	float maxdef=1000;
	float def;
	Queue defupup =new Queue();
	public float defuptime;
	float nowtime;
	float rec=2000;
	public float nowhp;
	float bosschange;
	float skillcount;
	byte p;
	bool flag10;
	bool flag30;
	public GameObject attack; 
	public  float atk;
	float jktime;
	byte o;
	float skilldelay;
	public GameObject bossskill;
	GameObject colorch;
	bool inin;

	string dis1;string dis2;
	public Texture2D skillpic;
	public Texture2D skillpic2;
	public Texture2D skillpic3;
	public Texture2D skillpic4;
	public Texture2D recsskill;
	public Texture2D skillpic5;
	public Texture2D skillpic6;
	public GameObject allup;
	float enhp100;
	float myhp100;
	// Use this for initialization
	void Start () {
		atk = 2000;
		HP = 500000;
		flag10 = true;
		flag30 = true;
		enhp100 = 0;
		myhp100 = 0;
		emenyhit.enhp = HP;
		bpm.enemybpm = 0.8f;
		emenyhit.greathit = 1;
		emenyhit.fronthit =4;
		emenyhit.realhit = 4;
		emenyhit.enemyatk = atk;
		inin = true;

		nowhp = HP;
		def = maxdef;
		newtempoeneny.enemyspeed = 8000;
		colorch = GameObject.Find ("trup").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
				nowtime += Time.deltaTime;
				jktime += Time.deltaTime;
				if (jktime > 3f && bactrl.enjk == true) {
						bactrl.enchjk = true;
						jktime = 0;
				}
				if (jktime > 7f && bactrl.enjk == false) {
						bactrl.enchjk = true;
						jktime = 0;
				}
		
		
		
		
				bosschange += Time.deltaTime;
		
		
		if (aaaaa.recdown) {
			aaaaa.recdown=false;		
			rec=rec*0.99f;
		}



				if (nowhp <= 0) {
						GameObject.Find ("she").GetComponent<face> ().winn = true;
						Instantiate (Resources.Load ("VIC"));
						Destroy (this.gameObject);
				}
				if (nowhp >= 0.1f * HP) {
	
						if (bosschange < 6.0f) {
								colorch.GetComponent<SpriteRenderer> ().color = new Color (255, 0, 0);
								if (bosschange > 0.175f) {
										colorch.GetComponent<SpriteRenderer> ().color = new Color (255, 255, 255);
								}
								newtempoeneny.iseba = true;
				
						} else if (bosschange >= 10.0f) {
				
								bosschange = 0.0f;
				
						} else if (bosschange >= 6.0f) {
				

								newtempoeneny.iseba = false;
				
						} 
				}

		if (flag30) {
			if(GameObject.Find("skillboss").gameObject.transform.childCount!=0)
			{
				GameObject.Find("bossskill(Clone)").name="getout";
				
				
			}
			Instantiate(bossskill);
			GameObject.Find("bossskill(Clone)").GetComponent<UITexture>().mainTexture=recsskill;
				
			atk=atk*1.5f;
			rec=rec*1.5f;
			def=def*1.5f;
			Instantiate (allup);
			GameObject.Find ("123(Clone)").transform.parent = GameObject.Find("UIRoot").transform;
			GameObject.Find ("123(Clone)").transform.localPosition = new Vector3 (578,1788, 0);
			flag30=false;
		}
		if (nowtime>=0f && nowtime<=10f &&  flag10) {
			skilldelay+=Time.deltaTime;
			
			if(inin)
			{
				if(GameObject.Find("skillboss").gameObject.transform.childCount!=0)
				{
					GameObject.Find("bossskill(Clone)").name="getout";
				}
				
				Instantiate(bossskill);
				GameObject.Find("bossskill(Clone)").GetComponent<UITexture>().mainTexture=skillpic;
				newtempo.eaccel=1.5f;
				newtempoeneny.meslowdown=1.5f;
				inin=false;   
				
			}
			
			
			if(skilldelay>10f)
			{  
				newtempo.eaccel=1f;
				newtempoeneny.meslowdown=1f;
				inin=true;
				skilldelay=0;
			}
			
			
		}

		if (nowtime>=10f && nowtime<=20f &&  flag10) {
			skilldelay+=Time.deltaTime;
			
			if(inin)
			{
				if(GameObject.Find("skillboss").gameObject.transform.childCount!=0)
				{
					GameObject.Find("bossskill(Clone)").name="getout";
					
					
				}
				
				Instantiate(bossskill);
				GameObject.Find("bossskill(Clone)").GetComponent<UITexture>().mainTexture=skillpic2;
				atk=atk*0.5f;
				charstuas.nowatk=charstuas.nowatk*0.5f;

				inin=false;   
				
			}
			
			
			if(skilldelay>10f)
			{ 
				atk=atk*2f;
				charstuas.nowatk=charstuas.nowatk*2f;
				inin=true;
				skilldelay=0; 
			}
			
			
		} 
		if (nowtime>=20f && nowtime<=30f &&  flag10) {
			skilldelay+=Time.deltaTime;
			
			if(inin)
			{
				if(GameObject.Find("skillboss").gameObject.transform.childCount!=0)
				{
					GameObject.Find("bossskill(Clone)").name="getout";
				}
				
				Instantiate(bossskill);

				GameObject.Find("bossskill(Clone)").GetComponent<UITexture>().mainTexture=skillpic3;
				def=def*0.5f;
				charstuas.nowdeff=charstuas.nowdeff*0.5f;
				inin=false; 
				
			}
			
			
			if(skilldelay>10f)
			{    
				def=def*2f;
				charstuas.nowdeff=charstuas.nowdeff*2f;
				inin=true;
				skilldelay=0;
			}
			
			
		} 
		if (nowtime>=30f && nowtime<=40f &&  flag10) {
			skilldelay+=Time.deltaTime;
			
			if(inin)
			{
				if(GameObject.Find("skillboss").gameObject.transform.childCount!=0)
				{
					GameObject.Find("bossskill(Clone)").name="getout";
					
					
				}
				Debug.Log ("123");
				Instantiate(bossskill);
				enhp100=nowhp/HP;
				myhp100=charstuas.nowhp/charstuas.maxhp;
				Debug.Log (enhp100);
				Debug.Log (myhp100);
				GameObject.Find("bossskill(Clone)").GetComponent<UITexture>().mainTexture=skillpic4;
				if(enhp100 >= myhp100)
				{

					nowhp=HP;
				}
				else
				{
					charstuas.nowhp=charstuas.maxhp;
				}
				inin=false;   
				
			}
			
			
			if(skilldelay>10f)
			{    
				inin=true;
				skilldelay=0;
			}
			
			
		} 
		if (nowtime>=40f && nowtime<=50f &&  flag10) {
			skilldelay+=Time.deltaTime;
			
			if(inin)
			{
				if(GameObject.Find("skillboss").gameObject.transform.childCount!=0)
				{
					GameObject.Find("bossskill(Clone)").name="getout";
					
					
				}
				
				Instantiate(bossskill);
				GameObject.Find("bossskill(Clone)").GetComponent<UITexture>().mainTexture=skillpic5;
				Instantiate(Resources.Load("flyboommany"),new Vector3(0,-0.8f,0),Quaternion.identity);
				GameObject.Find("give").GetComponent<AudioSource>().Play();
				foreach(GameObject fooObj in GameObject.FindGameObjectsWithTag("early"))
				{
					if(fooObj.name == "noeff(Clone)")
					{
						fooObj.GetComponent<newtempo>().todoke=true;
					}
					if(fooObj.name == "due(Clone)")
					{
						fooObj.GetComponent<dudue>().todoke=true;
					}
				}
				inin=false;   

				
			}
			
			
			if(skilldelay>10f)
			{
				inin=true;    
				skilldelay=0;
			}
			
			
		} 
		if (nowtime>=50f && nowtime<=60f &&  flag10) {
			skilldelay+=Time.deltaTime;
			
			if(inin)
			{
				if(GameObject.Find("skillboss").gameObject.transform.childCount!=0)
				{
					GameObject.Find("bossskill(Clone)").name="getout";
					
					
				}
				
				Instantiate(bossskill);
				GameObject.Find("bossskill(Clone)").GetComponent<UITexture>().mainTexture=skillpic6;
				//起原之音50%
				inin=false;  
				
			}

			
			if(skilldelay>10f)
			{
				inin=true;
				skilldelay=0;
			}
			
			
		} 

		





















		
		
		
		if (bass.bassdown) {
			bass.bassdown=false;
			charstuas.nowdeff=charstuas.nowdeff+def*0.02f+emenyhit.enemyatk*0.02f+rec*0.02f;
			def=def-def*0.02f;
			emenyhit.enemyatk=emenyhit.enemyatk-emenyhit.enemyatk*0.02f;
			rec=rec-rec*0.02f;
			
			
			
		}
		if (bass.bassreduce) {
			
			def=def-maxdef*0.1f;
			bass.bassreduce=false;
			
			
		}
		
		if (emenyhit.hprec == true) {
			emenyhit.hprec=false;
			nowhp=nowhp+rec*emenyhit.encombodamage;
			
			
		}
		if (emenyhit.iskrec) {
			
			if(!emenyhit.turn)
			{
				nowhp+=rec;		
				emenyhit.iskrec=false;
				charstuas.hurt=rec*emenyhit.encombodamage-rec;
			}
			if(emenyhit.turn)
			{
				nowhp+=rec;		
				emenyhit.iskrec=false;
				damage.isdamage=rec*emenyhit.encombodamage-rec;
				
				
			}
			
			
		}
		if (emenyhit.isduo == true) {
			emenyhit.isduo=false;		
			nowhp=nowhp-HP*0.05f;
			
		}
		
		if (damage.isdamage != 0) {
			Debug.Log(damage.isdamage);
			if((damage.isdamage-def*1.5f)>0)
			{
				nowhp=nowhp-(damage.isdamage-def*1.5f*weak.weakreduce);
				
			}
			if (aaaaa.suckblood==true) {
				aaaaa.suckblood=false;		
				if(charstuas.nowhp/charstuas.maxhp < nowhp/HP){
					aaaaa.dicombo++;
					if(aaaaa.dicombo>=5)
					{
						aaaaa.dicombo=0;
						charstuas.nowhp=charstuas.nowhp+damage.isdamage;
					}
				}
			}
			damage.isdamage=0;
			
			
		}
		if (damage.isdeffdown) {
			damage.isdeffdown=false;
			def=def*0.95f;
			
			
		}
		if (emenyhit.defupflag == true) {
			emenyhit.defupflag=false;
			def=def+10;
			defupup.Enqueue("0");
			
		}
		if (emenyhit.weakhprec) {
			emenyhit.weakhprec=false;
			nowhp=nowhp+rec;
			
		}
		if (defupup.Count > 0) {
			defuptime += Time.deltaTime;
			if(defuptime>=10)
			{
				def=def-10;
				defupup.Dequeue();
				defuptime=0f;
				
			}
			
			
			
		}
		
		
		if(dark.isaru)
		{
			emenyhit.greathit = 0;
			emenyhit.fronthit = 2;
			emenyhit.realhit = 3;
			
			
			
		}else
		{
			
			emenyhit.greathit = 1;
			emenyhit.fronthit = 4;
			emenyhit.realhit = 4;
			
			
		}
		
		if (aaaaa.iskbasson) {
			aaaaa.iskbasson=false;
			
			charstuas.nowdeff+=def*0.01f;
			def=def-def*0.01f;
			
		}
		if (emenyhit.iskbasson) {
			
			emenyhit.iskbasson=false;
			def=charstuas.nowdeff*0.01f;
			charstuas.nowdeff=charstuas.nowdeff-charstuas.nowdeff*0.01f;
			
			
			
		}
		if (emenyhit.iskpiano!=0) {
			
			
			
			def+=emenyhit.iskpiano;
			emenyhit.iskpiano=0;
			
		}
		
		
		GameObject.Find ("ehpbar").GetComponent<UISprite> ().fillAmount = (float)(nowhp/HP)*0.75f+0.25f;
	}
}


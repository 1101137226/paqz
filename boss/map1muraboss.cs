using UnityEngine;
using System.Collections;

public class map1muraboss : MonoBehaviour {
	public float HP;
	bool skillwalk;
	float skilldelaytime;
	public static byte readonly noise;
	float readonly maxdef=100;
	float def;
	readonly Queue defupup =new Queue();
	public float defuptime;
	float rec=100;
	public float nowhp;
	float bosschange;
	float skillcount;
	float skilldelay;
	bool flag30;
	bool flag10;
	public GameObject atkup;
	float hpuptime;
	public GameObject attack; 
	public  float atk;
	float jktime;
	byte o;

	public GameObject bossskill;
	GameObject colorch;
	bool inin;

	string dis1;string dis2;

	public Texture2D recsskill;
	public Texture2D skillpic3;

	void Start () {
		atk = 400;
		HP = 20000;
		newtempoeneny.isegu = true;
		flag30 = true;
		flag10 = true;
		skillwalk= true;
		bpm.enemybpm = 0.4f;
		emenyhit.greathit = 1;
		emenyhit.fronthit =4;
		emenyhit.realhit = 4;
		emenyhit.enemyatk = atk;
		inin = true;
		emenyhit.enhp = HP;
		nowhp = HP;
		def = maxdef;
		newtempoeneny.enemyspeed = 8000;
		colorch = GameObject.Find ("trup").gameObject;
	}

	void Update () {

		jktime += Time.deltaTime;
		if (jktime > 3f && bactrl.enjk==true) {
			bactrl.enchjk = true;
			jktime=0;
		}
		if(jktime>7f && bactrl.enjk==false)
		{
			bactrl.enchjk=true;
			jktime=0;
		}
		
		
		
		
		bosschange+=Time.deltaTime;
		
		if (aaaaa.recdown) {
			aaaaa.recdown=false;		
			rec=rec*0.99f;
		}
		
		
		
		
		if (nowhp <= 0) {
			GameObject.Find("she").GetComponent<face>().winn=true;
			Instantiate(Resources.Load("VIC"));
			Destroy(this.gameObject);
		}
		if (nowhp >= 0.1f * HP) {
			
			
			
			
			if (bosschange < 6.0f) {
				colorch.GetComponent<SpriteRenderer>().color=new Color(255,0,0);
				if(bosschange>0.175f)
				{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
				newtempoeneny.iseba = true;
				
			} else if (bosschange >= 10.0f) {
				
				bosschange = 0.0f;
				
			} else if (bosschange >= 6.0f) {
				
				
				newtempoeneny.iseba = false;
				
			} 
		}

		skillcount += Time.deltaTime;
		if (skillcount >= 7 && skillwalk) {
			skillcount=0;
			flag30=true;
			
			
		}





		if (nowhp < 0.3f * HP && flag10 == true) {	
			if(inin)
			{
				if(GameObject.Find("skillboss").gameObject.transform.childCount!=0)
				{
					GameObject.Find("bossskill(Clone)").name="getout";

				}
				
				Instantiate(bossskill);
				GameObject.Find("bossskill(Clone)").GetComponent<UITexture>().mainTexture=recsskill;
				nowhp=nowhp+10000;
			}
			
			if(nowhp>0.3f*HP){		
				flag10=false;

			}
			
			
		} 




		if (nowhp<=0.3f* HP && flag30 == true) {
			skillwalk=false;
			
			skilldelay+=Time.deltaTime;
			
			if(inin)
			{
				if (GameObject.Find ("skillboss").gameObject.transform.childCount != 0) {
					GameObject.Find ("bossskill(Clone)").name = "getout";

				}
				
				Instantiate (bossskill);
				GameObject.Find ("bossskill(Clone)").GetComponent<UITexture> ().mainTexture = skillpic3;
				
				Instantiate(Resources.Load("flyboommany"),new Vector3(0,-0.8f,0),Quaternion.identity);
				GameObject.Find("give").GetComponent<AudioSource>().Play();
				foreach(GameObject fooObj in GameObject.FindGameObjectsWithTag("early"))
				{
					if(fooObj.name == "noeff(Clone)")
					{
						fooObj.GetComponent<newtempo>().gogo=true;
					}
					if(fooObj.name == "due(Clone)")
					{
						fooObj.GetComponent<dudue>().gogo=true;
					}
				}
				
				
				
				
				
				skilldelaytime=1f;
				inin=false;
				
			}
			
			
			if(skilldelay>skilldelaytime)
			{
				Destroy(GameObject.Find("flyboommany(Clone)").gameObject);
				inin=true;
				flag30=false;
				skilldelay=0;
				skillcount=0;
				skillwalk=true;
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

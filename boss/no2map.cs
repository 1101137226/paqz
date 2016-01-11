using UnityEngine;
using System.Collections;

public class no2map : MonoBehaviour
{
	public float HP;
	public static byte noise;
	float maxdef = 300;
	float def;
	Queue defupup = new Queue ();
	public float defuptime;
	float rec = 800;
	public float nowhp;
	float bosschange;
	float skillcount;
	bool flag30;
	bool flag15;
	bool flag10;
	public GameObject attack;
	public  float atk;
	float jktime;
	byte o;
	float skilldelay;
	float upatk;
	float upatktime;
	public GameObject bossskill;
	GameObject colorch;
	bool inin;
	bool comein;
	bool skillwalk;
	string dis1;
	string dis2;
	string dis3;
	string dis4;
	bool flag2020;
	float skilldelaytime;
	public Texture2D recsskill;
	public Texture2D skillpic3;
	public Texture2D skillpic4;
	public Texture2D skillpic5;
	public Texture2D skillpic6;
	public Texture2D skillpic7;
	public Texture2D skillpic8;
	byte p;
	public GameObject myspeedup;
	public GameObject enspeedup;
	public GameObject myspeedslow;

	void Start ()
	{
		atk = 700;
		HP = 80000;
		newtempoeneny.iseba = true;
		flag30 = true;
		flag15 = true;
		flag10 = true;
		comein = true;
		emenyhit.enhp = HP;
		bpm.enemybpm = 0.4f;
		emenyhit.greathit = 1;
		emenyhit.fronthit = 4;
		emenyhit.realhit = 4;
		emenyhit.enemyatk = atk;
		inin = true;
		
		nowhp = HP;
		def = maxdef;
		newtempoeneny.enemyspeed = 8000;
		colorch = GameObject.Find ("trup").gameObject;
	}

	void Update ()
	{

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
			aaaaa.recdown = false;		
			rec = rec * 0.99f;
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

	


		Random.seed = System.Guid.NewGuid ().GetHashCode ();

		skillcount += Time.deltaTime;
		if (skillcount >= 7 && skillwalk) {
			skillcount = 0;
			flag30 = true;
			
			
		}


		if (flag10) {
			upatk += Time.deltaTime;
			if (GameObject.Find ("skillboss").gameObject.transform.childCount != 0) {
				GameObject.Find ("bossskill(Clone)").name = "getout";
				
				
			}
			Instantiate (bossskill);
			if (comein) {
				GameObject.Find ("bossskill(Clone)").GetComponent<UITexture> ().mainTexture = skillpic8;
				newtempoeneny.meslowdown = 1.5f;
				newtempo.eaccel = 1.5f;
				Instantiate (myspeedup);
				GameObject.Find ("SPEEDGOGO(Clone)").transform.parent = GameObject.Find ("UIRoot").transform;
				Instantiate (enspeedup);
				GameObject.Find ("ENSPEEDGOGO(Clone)").transform.parent = GameObject.Find ("UIRoot").transform;
				upatktime = 20f;
				comein = false;
			}
			if (upatk > upatktime) {
				flag10 = false;
				Destroy (GameObject.Find ("SPEEDGOGO(Clone)").gameObject);
				Destroy (GameObject.Find ("ENSPEEDGOGO(Clone)").gameObject);
			}
			
		}
		
		if (nowhp >= 0.6f * HP && nowhp < 0.9f * HP && flag30 == true) {
			skillwalk = false;
			
			skilldelay += Time.deltaTime;
			
			int oo = Random.Range (0, 3);
			if (inin) {
				p = (byte)oo;
				
				

				if (GameObject.Find ("skillboss").gameObject.transform.childCount != 0) {
					GameObject.Find ("bossskill(Clone)").name = "getout";
					
					
				}
				
				Instantiate (bossskill);
				if (p == 0) {
					GameObject.Find ("bossskill(Clone)").GetComponent<UITexture> ().mainTexture = recsskill;
					skilldelaytime = 5f;
				}
				
				if (p == 1) {
					GameObject.Find ("bossskill(Clone)").GetComponent<UITexture> ().mainTexture = skillpic3;
					skilldelaytime = 3f;
					
				}
				if (p == 2) {
					GameObject.Find ("bossskill(Clone)").GetComponent<UITexture> ().mainTexture = skillpic4;
					skilldelaytime = 3f;
					charstuas.nowhp = charstuas.nowhp * 0.9f;	
					inin = false;
				}
			}
			if (p == 0) {
				scriptchange.guchange = false;
				scriptchange.painochange = false;
				scriptchange.posichange = false;
				scriptchange.basschange = false;
				scriptchange.smallchange = false;
				newtempoeneny.ispure = true;
				newtempoeneny.isegu = false;
				newtempoeneny.isepi = false;
				newtempoeneny.iseba = false;
				newtempoeneny.isesm = false;
				inin = false;
				
			}
			if (p == 1) {
				scriptchange.guchange = false;
				scriptchange.painochange = false;
				scriptchange.posichange = false;
				scriptchange.basschange = false;
				scriptchange.smallchange = true;
				newtempoeneny.ispure = false;
				newtempoeneny.isegu = false;
				newtempoeneny.isepi = false;
				newtempoeneny.iseba = false;
				newtempoeneny.isesm = true;
				inin = false;
				
			}
			


			
			
			if (skilldelay > skilldelaytime) {
				inin = true;
				flag30 = false;
				skilldelay = 0;
				skillcount = 0;
				skillwalk = true;
				skilldelaytime = 0;
			}
			
			
			
		}
								

		if (nowhp >= 0.2f * HP && nowhp < 0.6f * HP && flag30 == true) {
			skillwalk = false;
			
			skilldelay += Time.deltaTime;
			
			int oo = Random.Range (0, 3);
			if (inin) {
			
				p = (byte)oo;
			
				if (GameObject.Find ("skillboss").gameObject.transform.childCount != 0) {
					GameObject.Find ("bossskill(Clone)").name = "getout";
					
					
				}
				
				Instantiate (bossskill);
			
				if (p == 0) {
					GameObject.Find ("bossskill(Clone)").GetComponent<UITexture> ().mainTexture = skillpic5;
					skilldelaytime = 3f;
					inin = false;
					def = def + 10000;
				}
				
				if (p == 1) {
					GameObject.Find ("bossskill(Clone)").GetComponent<UITexture> ().mainTexture = skillpic6;
					skilldelaytime = 3f;
					charstuas.nowatk = charstuas.nowatk - 200;
					inin = false;
					
				}
				if (p == 2) {
					GameObject.Find ("bossskill(Clone)").GetComponent<UITexture> ().mainTexture = skillpic7;
					skilldelaytime = 5f;
					Instantiate (myspeedslow);
					GameObject.Find ("MYSPEEDSLOW(Clone)").transform.parent = GameObject.Find ("UIRoot").transform;
					newtempo.eaccel = 0.5f;
					inin = false;
				}
			
			
			
			
			
			
			}
			
			
			
			if (skilldelay > skilldelaytime) {
				if (p == 0) {
					def = def - 10000;
				}
				if (p == 1) {
					charstuas.nowatk = charstuas.nowatk + 200;

				}
				if (p == 2) {
					Destroy (GameObject.Find ("MYSPEEDSLOW(Clone)").gameObject);
					newtempo.eaccel = 1f;
				}

				inin = true;
				flag30 = false;
				skilldelay = 0;
				skillcount = 0;
				skillwalk = true;
				skilldelaytime = 0;
			}
			
			
			
		}









		if (nowhp <= 0.2f * HP && flag15 == true) {
			skillwalk = false;
			skilldelay += Time.deltaTime;


			if (inin) {

				
				if (GameObject.Find ("skillboss").gameObject.transform.childCount != 0) {
					GameObject.Find ("bossskill(Clone)").name = "getout";
				}
				
				Instantiate (bossskill);
				bpm.tempobpm = 0.2f;
				skilldelaytime = 15f;
				inin = false;
				flag2020 = true;
			}
			if (skilldelay >= 2f && flag2020) {
				

				byte descount = 0;
				for (int i=0; i<5; i++) {
						
					if (descount == 4) {
						break;
							
					}
						
					if (bactrl.ishand [i]) {							
						if (descount == 0) {
							dis1 = System.Convert.ToString (i);
						} else if (descount == 1) {
							dis2 = System.Convert.ToString (i);
						} else if (descount == 2) {
							dis3 = System.Convert.ToString (i);
						} else if (descount == 3) {
							dis4 = System.Convert.ToString (i);
						}


						bactrl.ishand [i] = false;
						descount++;
							
					}
						
				}

					

				if (skilldelay >= 2f && skilldelay < 2.5f && flag2020) {
					GameObject.Find ("backgr").GetComponent<Animator> ().SetBool ("allmove", true);
				} else if (skilldelay >= 2.5f && skilldelay < 3.0f) {
					GameObject.Find ("backgr").GetComponent<Animator> ().SetBool ("allmove", false);
					if (dis1 != null) {
						GameObject.Find (dis1).transform.localPosition = new Vector3 (-6600 + System.Convert.ToByte (dis1) * 1800, -2800 - skilldelay * 200f, 0);
					}
					if (dis2 != null) {
						GameObject.Find (dis2).transform.localPosition = new Vector3 (-6600 + System.Convert.ToByte (dis2) * 1800, -2800 - skilldelay * 200f, 0);
					}
					if (dis3 != null) {
						GameObject.Find (dis2).transform.localPosition = new Vector3 (-6600 + System.Convert.ToByte (dis3) * 1800, -2800 - skilldelay * 200f, 0);
					}
					if (dis4 != null) {
						GameObject.Find (dis2).transform.localPosition = new Vector3 (-6600 + System.Convert.ToByte (dis4) * 1800, -2800 - skilldelay * 200f, 0);
					}
				} else if (skilldelay < 3.5 && flag2020) {
					if (dis1 != null) {
						GameObject.Find (dis1).GetComponent<UITexture> ().color = new Color (255, 255, 255, 3.5f - skilldelay * 1.1f);
					}
					if (dis2 != null) {
						GameObject.Find (dis2).GetComponent<UITexture> ().color = new Color (255, 255, 255, 3.5f - skilldelay * 1.1f);
					}
					if (dis3 != null) {
						GameObject.Find (dis3).GetComponent<UITexture> ().color = new Color (255, 255, 255, 3.5f - skilldelay * 1.1f);
					}
					if (dis4 != null) {
						GameObject.Find (dis4).GetComponent<UITexture> ().color = new Color (255, 255, 255, 3.5f - skilldelay * 1.1f);
					}
				}
			
				if (skilldelay >= 3.0 && flag2020) { 
					flag2020 = false;
					if (dis1 != null) {
						Destroy (GameObject.Find (dis1).gameObject);
					}
					if (dis2 != null) {
						Destroy (GameObject.Find (dis2).gameObject);
					}
					if (dis3 != null) {
						Destroy (GameObject.Find (dis3).gameObject);
					}
					if (dis4 != null) {
						Destroy (GameObject.Find (dis4).gameObject);
					}

				}
			}
			
			
			
			if (skilldelay > skilldelaytime) {	
				flag15 = false;
				bpm.tempobpm = 0.8f;
				inin = true;
				skilldelay = 0;
				skillcount = 0;
				skillwalk = true;
				skilldelaytime = 0;
				charstuas.nowhp = charstuas.nowhp * 0;
			}
			
			
			
		}

		
		if (bass.bassdown) {
			bass.bassdown = false;
			charstuas.nowdeff = charstuas.nowdeff + def * 0.02f + emenyhit.enemyatk * 0.02f + rec * 0.02f;
			def = def - def * 0.02f;
			emenyhit.enemyatk = emenyhit.enemyatk - emenyhit.enemyatk * 0.02f;
			rec = rec - rec * 0.02f;
			
			
			
		}
		if (bass.bassreduce) {
			
			def = def - maxdef * 0.1f;
			bass.bassreduce = false;
			
			
		}
		
		if (emenyhit.hprec == true) {
			emenyhit.hprec = false;
			nowhp = nowhp + rec * emenyhit.encombodamage;
			
			
		}
		if (emenyhit.iskrec) {
			
			if (!emenyhit.turn) {
				nowhp += rec;		
				emenyhit.iskrec = false;
				charstuas.hurt = rec * emenyhit.encombodamage - rec;
			}
			if (emenyhit.turn) {
				nowhp += rec;		
				emenyhit.iskrec = false;
				damage.isdamage = rec * emenyhit.encombodamage - rec;
				
				
			}
			
			
		}
		if (emenyhit.isduo == true) {
			emenyhit.isduo = false;		
			nowhp = nowhp - HP * 0.05f;
			
		}
		
		if (damage.isdamage != 0) {

			if ((damage.isdamage - def * 1.5f) > 0) {
				nowhp = nowhp - (damage.isdamage - def * 1.5f * weak.weakreduce);
			}
			if (aaaaa.suckblood == true) {
				aaaaa.suckblood = false;		
				if (charstuas.nowhp / charstuas.maxhp < nowhp / HP) {
					aaaaa.dicombo++;
					if (aaaaa.dicombo >= 5) {
						aaaaa.dicombo = 0;
						charstuas.nowhp = charstuas.nowhp + damage.isdamage;
					}
				}
			}
			damage.isdamage = 0;
			
			
		}
		if (damage.isdeffdown) {
			damage.isdeffdown = false;
			def = def * 0.95f;
			
			
		}
		if (emenyhit.defupflag == true) {
			emenyhit.defupflag = false;
			def = def + 10;
			defupup.Enqueue ("0");
			
		}
		if (emenyhit.weakhprec) {
			emenyhit.weakhprec = false;
			nowhp = nowhp + rec;
			
		}
		if (defupup.Count > 0) {
			defuptime += Time.deltaTime;
			if (defuptime >= 10) {
				def = def - 10;
				defupup.Dequeue ();
				defuptime = 0f;
				
			}
			
			
			
		}
		
		
		if (dark.isaru) {
			emenyhit.greathit = 0;
			emenyhit.fronthit = 2;
			emenyhit.realhit = 3;
			
			
			
		} else {
			
			emenyhit.greathit = 1;
			emenyhit.fronthit = 4;
			emenyhit.realhit = 4;
			
			
		}
		
		if (aaaaa.iskbasson) {
			aaaaa.iskbasson = false;
			
			charstuas.nowdeff += def * 0.01f;
			def = def - def * 0.01f;
			
		}
		if (emenyhit.iskbasson) {
			
			emenyhit.iskbasson = false;
			def = charstuas.nowdeff * 0.01f;
			charstuas.nowdeff = charstuas.nowdeff - charstuas.nowdeff * 0.01f;
			
			
			
		}
		if (emenyhit.iskpiano != 0) {
			
			
			
			def += emenyhit.iskpiano;
			emenyhit.iskpiano = 0;
			
		}
		
		
		GameObject.Find ("ehpbar").GetComponent<UISprite> ().fillAmount = (float)(nowhp / HP) * 0.75f + 0.25f;
	}
}

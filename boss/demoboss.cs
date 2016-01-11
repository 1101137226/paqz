using UnityEngine;
using System.Collections;

public class demoboss : MonoBehaviour
{
	public float HP;
	public static byte noise;
	float maxdef = 700;
	float def;
	Queue defupup = new Queue ();
	public float defuptime;
	float nowtime;
	float rec = 4000;
	public float nowhp;
	float bosschange;
	float skillcount;
	bool halfflag;
	bool flag30;
	bool inin10;
	public GameObject attack;
	public  float atk;
	float jktime;
	byte o;
	float skilldelay;
	public GameObject bossskill;
	public Texture2D ishi;
	public Texture2D bassreduce;
	public Texture2D poi;
	public Texture2D highspeed;
	public Texture2D boomrun;
	bool skillwalk;
	GameObject colorch;
	bool inin;
	bool inin50;
	bool inin3030;
	string dis1;
	string dis2;
	bool inin1010;
	bool isin;

	void Start ()
	{
		atk = 2800;
		HP = 230000;
		halfflag = true;
		flag30 = true;
		inin10 = true;
		inin1010 = false;
		bpm.enemybpm = 0.8f;
		skillwalk = true;
		emenyhit.greathit = 4;
		emenyhit.fronthit = 2;
		emenyhit.realhit = 2;
		emenyhit.enemyatk = atk;
		emenyhit.enhp = HP;
		inin = true;
		isin = true;
		nowhp = HP;
		def = maxdef;
		newtempoeneny.enemyspeed = 8000;
		colorch = GameObject.Find ("trup").gameObject;
		newtempoeneny.iseba = false;
		newtempoeneny.isegu = false;
		newtempoeneny.isesm = false;
		newtempoeneny.isepi = false;
	}

	void Update ()
	{
		if (isin) {
			nowhp = HP;
			isin = false;
			
			
		}
		nowtime += Time.deltaTime;
		jktime += Time.deltaTime;
		if (jktime > 4f && bactrl.enjk == true) {
			bactrl.enchjk = true;
			jktime = 0;
		}
		if (jktime > 6f && bactrl.enjk == false) {
			bactrl.enchjk = true;
			jktime = 0;
		}

		bosschange += Time.deltaTime;

		if (nowhp <= 0) {
			GameObject.Find ("she").GetComponent<face> ().winn = true;
			Instantiate (Resources.Load ("VIC"));
			Destroy (this.gameObject);
		}
		if (nowhp >= 0.1f * HP) {
			if (bosschange < 10.0f) {
				colorch.GetComponent<SpriteRenderer> ().color = new Color (255, 0, 0);
				if (bosschange > 0.175f) {
					colorch.GetComponent<SpriteRenderer> ().color = new Color (255, 255, 255);
				}
				newtempoeneny.isegu = true;
			
			} else if (bosschange >= 13.0f) {
			
				bosschange = 0.0f;
			
			} else if (bosschange >= 10.0f) {
		
		
				newtempoeneny.isegu = false;
		
			} 
		} else if (nowhp < 0.1f * HP) {

			inin1010 = true;
		}
		
		if (inin1010) {

			jktime = 0;
			
			if (inin) {
				skilldelay = 0;
				Instantiate (Resources.Load ("999"));
				if (GameObject.Find ("skillboss").gameObject.transform.childCount != 0) {
					GameObject.Find ("bossskill(Clone)").GetComponent<bossskillmove> ().getout = true;
					
					
				}

				if (bactrl.enjk) {
					bactrl.enchjk = true;


				}
				Instantiate (bossskill);
				GameObject.Find ("bossskill(Clone)").GetComponent<UITexture> ().mainTexture = boomrun;
				inin = false;
				GameObject.Find ("boomrun").GetComponent<AudioSource> ().Play ();
			}
			skilldelay += Time.deltaTime;
			Random.seed = System.Guid.NewGuid ().GetHashCode ();
			if (inin10) {
				newtempoeneny.isegu = false;
				inin10 = false;
				def = 0;
				bosschange = 0.0f;
				emenyhit.enemyatk = atk * 4f;
				bpm.enemybpm = 0.2f;
				newtempoeneny.enemyspeed = 12000;
				
				o = (byte)Random.Range (0, 4);
			}
			if (bosschange < 5.0f) {
				this.GetComponent<AudioSource> ().Play ();
				if (o == 0) {
					colorch.GetComponent<SpriteRenderer> ().color = new Color (255, 0, 0);
					if (bosschange > 0.175f) {
						colorch.GetComponent<SpriteRenderer> ().color = new Color (255, 255, 255);
					}
					newtempoeneny.isegu = true;
				} else if (o == 1) {
					colorch.GetComponent<SpriteRenderer> ().color = new Color (0, 255, 0);
					if (bosschange > 0.175f) {
						colorch.GetComponent<SpriteRenderer> ().color = new Color (255, 255, 255);
					}
					newtempoeneny.iseba = true;
				} else if (o == 2) {
					colorch.GetComponent<SpriteRenderer> ().color = new Color (255, 255, 0);
					if (bosschange > 0.175f) {
						colorch.GetComponent<SpriteRenderer> ().color = new Color (255, 255, 255);
					}
					newtempoeneny.isesm = true;
				} else if (o == 3) {
					colorch.GetComponent<SpriteRenderer> ().color = new Color (0, 0, 255);
					if (bosschange > 0.175f) {
						colorch.GetComponent<SpriteRenderer> ().color = new Color (255, 255, 255);
					}
					newtempoeneny.isepi = true;
				}
				
				
			} else if (bosschange >= 6.0f) {
				
				bosschange = 0.0f;
				o = (byte)Random.Range (0, 4);
			} else if (bosschange >= 5.0f) {
				
				
				newtempoeneny.isegu = false;
				newtempoeneny.iseba = false;
				newtempoeneny.isesm = false;
				newtempoeneny.isepi = false;
			} 
			
			if (skilldelay >= 10) {
				nowhp = 0;
				
			}
			

			
		}

		skillcount += Time.deltaTime;
		if (skillcount >= 7 && skillwalk) {
			skillcount = 0;
			Instantiate (attack);
		
		}

		if (nowhp < 0.5f * HP && halfflag == true) {


			skillwalk = false;
			skilldelay += Time.deltaTime;
			if (inin) {
				inin = false;
				if (GameObject.Find ("skillboss").gameObject.transform.childCount != 0) {
					GameObject.Find ("bossskill(Clone)").name = "getout";
					
					
				}
				
				Instantiate (bossskill);
				Instantiate (Resources.Load ("123"));
				GameObject.Find ("bossskill(Clone)").GetComponent<UITexture> ().mainTexture = ishi;
				def = def + maxdef;
				inin = false;
				inin50 = true;
				GameObject.Find ("tetsuishi").GetComponent<AudioSource> ().Play ();
			}
			if (skilldelay >= 2f && inin50 == true) {	
				Destroy (GameObject.Find ("123(Clone)").gameObject);
				inin50 = false;
				if (GameObject.Find ("skillboss").gameObject.transform.childCount != 0) {
					GameObject.Find ("bossskill(Clone)").name = "getout";										
				}
				
				Instantiate (bossskill);
			
				GameObject.Find ("bossskill(Clone)").GetComponent<UITexture> ().mainTexture = bassreduce;


				Instantiate (Resources.Load ("basssonic"));
				GameObject.Find ("bassreduce").GetComponent<AudioSource> ().Play ();
						
			}
			if (skilldelay >= 3.5f && inin50 == false) {
				Destroy (GameObject.Find ("basssonic(Clone)").gameObject);
				aaaaa.combo = 0;
				aaaaa.drawcombo = 0;
				soul.soulcombo = 0;
				bass.basscombok = 0;
				inin = true;
				skillwalk = true;
				skilldelay = 0.0f;
				halfflag = false;



			}
		
		} else if (nowhp < 0.3f * HP && flag30 == true) {
			skillwalk = false;
			skilldelay += Time.deltaTime;

			if (inin) {
				if (GameObject.Find ("skillboss").gameObject.transform.childCount != 0) {
					GameObject.Find ("bossskill(Clone)").name = "getout";
					
					
				}

				Instantiate (bossskill);
				GameObject.Find ("bossskill(Clone)").GetComponent<UITexture> ().mainTexture = poi;
				Instantiate (Resources.Load ("deflow"));
				charstuas.nowdeff = charstuas.nowdeff - charstuas.nowdeff * 0.5f;
				inin = false;
				GameObject.Find ("posionwater").GetComponent<AudioSource> ().Play ();

			}

			 
			if (skilldelay >= 2f) {

				if (inin3030) {
					if (GameObject.Find ("skillboss").gameObject.transform.childCount != 0) {
						GameObject.Find ("bossskill(Clone)").name = "getout";
					

					}
				
					Instantiate (bossskill);
					GameObject.Find ("highspeed").GetComponent<AudioSource> ().Play ();
					GameObject.Find ("bossskill(Clone)").GetComponent<UITexture> ().mainTexture = highspeed;
					byte descount = 0;
					for (int i=0; i<5; i++) {
						
						if (descount == 2) {
							break;
							
						}
						
						if (bactrl.ishand [i]) {
							if (descount == 0) {
								dis1 = System.Convert.ToString (i);
							} else if (descount == 1) {
								dis2 = System.Convert.ToString (i);
							}
							bactrl.ishand [i] = false;
							descount++;
							
						}
						
					}
					inin3030 = false;

				}
				if (skilldelay >= 2f && skilldelay < 2.5f) {
					GameObject.Find ("backgr").GetComponent<Animator> ().SetBool ("allmove", true);
				} else if (skilldelay >= 2.5f && skilldelay < 3.0f) {
					GameObject.Find ("backgr").GetComponent<Animator> ().SetBool ("allmove", false);
					if (dis1 != null) {
						GameObject.Find (dis1).transform.localPosition = new Vector3 (-6600 + System.Convert.ToByte (dis1) * 1800, -2800 - skilldelay * 200f, 0);
					}
					if (dis2 != null) {
						GameObject.Find (dis2).transform.localPosition = new Vector3 (-6600 + System.Convert.ToByte (dis2) * 1800, -2800 - skilldelay * 200f, 0);
					}

				} else if (skilldelay < 3.5) {
					if (dis1 != null) {
						GameObject.Find (dis1).GetComponent<UITexture> ().color = new Color (255, 255, 255, 3.5f - skilldelay * 1.1f);
					}
					if (dis2 != null) {
						GameObject.Find (dis2).GetComponent<UITexture> ().color = new Color (255, 255, 255, 3.5f - skilldelay * 1.1f);
					}

				}
				if (skilldelay >= 3.0) {
					if (dis1 != null) {
						Destroy (GameObject.Find (dis1).gameObject);
					}
					if (dis2 != null) {
						Destroy (GameObject.Find (dis2).gameObject);
					}
					inin3030 = false;
					inin = true;
					skillwalk = true;
					skilldelay = 0.0f;
					flag30 = false;
				}
			} else if (skilldelay >= 1.5f && inin3030 == false) {
				Destroy (GameObject.Find ("deflow(Clone)").gameObject);
				inin3030 = true;
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
			nowhp += rec;		
			emenyhit.iskrec = false;
			charstuas.hurt = rec * emenyhit.encombodamage - rec;
		
		
		
		}
		if (emenyhit.isduo == true) {
			emenyhit.isduo = false;		
			nowhp = nowhp - HP * 0.05f;
			
		}
		
		if (damage.isdamage != 0) {
			if ((damage.isdamage - def * 1.5f) > 0) {
				nowhp = nowhp - (damage.isdamage - def * 1.5f * weak.weakreduce);

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
			emenyhit.greathit = 3;
			emenyhit.fronthit = 1;
			emenyhit.realhit = 1;

			
			
		} else {
			
			emenyhit.greathit = 4;
			emenyhit.fronthit = 2;
			emenyhit.realhit = 2;
			
			
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

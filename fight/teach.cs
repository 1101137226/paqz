using UnityEngine;
using System.Collections;

public class teach : MonoBehaviour
{
	byte step;
	public UILabel card;
	Queue handd = new Queue ();
	bool inin;
	bool next;
	bool start;
	float time;
	byte carddeck;
	public GameObject highh;
	public GameObject loww;
	public GameObject eloww;
	public Texture2D fullopen;
	Transform lowpoi;
	Transform highpoi;
	Transform elowpoi;
	Transform ehighpoi;
	Transform father;
	short nowcombo;
	public static bool jk;
	public GameObject bossskill;
	public Texture2D we;
	public Texture2D EN;
	public Texture2D TPFR;
	public Texture2D hit5;
	public Texture2D enhit5;
	public Texture2D ENTPFR;
	public Texture2D handdis;
	public Texture2D combodis;
	public Texture2D usecard;
	public Texture2D outeffect;
	public Texture2D lowbeats;
	public Texture2D draw;
	public Texture2D leftcard;
	public Texture2D changetohigh;
	public Texture2D highbeats;
	public Texture2D SPcard;
	public Texture2D SPcardlow;
	public Texture2D enskill;
	public Texture2D exit;
	public Texture2D step01;
	public Texture2D step11;
	public Texture2D step21;
	public Texture2D step22;
	public Texture2D step31;
	public Texture2D step32;
	public Texture2D step33;
	public Texture2D step34;
	public Texture2D step41;
	public Texture2D step42;
	public Texture2D step51;
	public Texture2D step52;
	public Texture2D step53;
	public Texture2D step54;
	public Texture2D step61;
	public Texture2D step62;
	public Texture2D step63;
	public Texture2D end;
	float timer;
	float enetime;
	float tempobpm;
	float  enemybpm;
	float nowhp;
	float hp = 100000;
	float atk;
	float def = 100;
	public UITexture tempo;
	public UITexture enemytempo;
	bool isin;
	void Start ()
	{
		GameObject.Find ("Interface").GetComponent<UIPanel> ().alpha = 0;

		isin = true;
		cardeffect.test = true;
		aaaaa.combo = 0;
		scriptchange.guchange = false;
		scriptchange.painochange = false;
		scriptchange.posichange = false;
		scriptchange.basschange = false;
		scriptchange.smallchange = false;
		scriptchange.guchange = false;

		father = GameObject.Find ("UIRoot").transform;
		step = 0;
		handd.Enqueue ("3");
		handd.Enqueue ("44");
		handd.Enqueue ("6");
		handd.Enqueue ("9");
		handd.Enqueue ("12");
		handd.Enqueue ("44");
		handd.Enqueue ("27");
		handd.Enqueue ("27");
		handd.Enqueue ("6");
		handd.Enqueue ("9");
		handd.Enqueue ("12");
		handd.Enqueue ("15");
		handd.Enqueue ("15");
		handd.Enqueue ("15");
		handd.Enqueue ("18");
		handd.Enqueue ("18");
		handd.Enqueue ("18");
		handd.Enqueue ("3");
		handd.Enqueue ("30");
		handd.Enqueue ("30");
		handd.Enqueue ("53");
		handd.Enqueue ("57");
		handd.Enqueue ("58");
		handd.Enqueue ("61");
		handd.Enqueue ("62");
		handd.Enqueue ("70");
		handd.Enqueue ("71");
		handd.Enqueue ("72");
		handd.Enqueue ("77");
		handd.Enqueue ("80");

		for (int q=0; q<5; q++) {
			Instantiate (Resources.Load ("hand/" + handd.Peek ()));
			GameObject.Find (handd.Peek () + "(Clone)").transform.parent = GameObject.Find ("UIRoot").transform;
			GameObject.Find (handd.Peek () + "(Clone)").transform.localScale = new Vector3 (1, 1, 1);
			GameObject.Find (handd.Peek () + "(Clone)").transform.localPosition = new Vector3 (-6600 + q * 1800, -3300, 0);
			GameObject.Find (handd.Dequeue () + "(Clone)").name = System.Convert.ToString (q);
		}
		Instantiate (eloww);
		Instantiate (loww);
		lowpoi = GameObject.Find ("low(Clone)").transform;
		elowpoi = GameObject.Find ("elow(Clone)").transform;
		effectctrl.father = lowpoi;
		effectctrl.mother = elowpoi;
		GameObject.Find ("low(Clone)").transform.parent = father;
		GameObject.Find ("low(Clone)").transform.localPosition = new Vector3 (-8000, -1200, 0);
		GameObject.Find ("elow(Clone)").transform.parent = father;
		GameObject.Find ("elow(Clone)").transform.localPosition = new Vector3 (-8000, 900, 0);
		emenyhit.greathit = 0;
		emenyhit.fronthit = 0;
		emenyhit.realhit = 0;
		carddeck = 25;
		inin = true;
		next = false;
		start = false;
		nowhp = hp;
		atk = 1500;
		emenyhit.enemyatk = atk;
		tempobpm = 0.8f;
		enemybpm = 0.8f;
		effectctrl.mother = GameObject.Find ("elow(Clone)").transform;
		GameObject.Find ("ehpbar").GetComponent<UISprite> ().fillAmount = (float)(nowhp / hp) * 0.75f + 0.25f;
		newtempoeneny.iseba = false;
		newtempoeneny.isegu = false;
		newtempoeneny.isesm = false;
		newtempoeneny.isepi = false;
		scriptchange.guchange = false;
		scriptchange.painochange = false;
		scriptchange.basschange = false;
		scriptchange.smallchange = false;
		origin.sonic = false;
		damage.isdamage = 0;
	}
	
	void Update ()
	{
		if (isin) {
			nowhp = hp;
			isin = false;
		}
		card.text = System.Convert.ToString (carddeck);
		timer += Time.deltaTime;
		enetime += Time.deltaTime;
		if (timer >= tempobpm) {
			Instantiate (tempo);
			timer = 0;
		}
		if (enetime >= enemybpm) {
			Instantiate (enemytempo);
			enetime = 0;
		}
		if (damage.isdamage != 0) {
			if ((damage.isdamage - def * 1.5f) > 0) {
				nowhp = nowhp - (damage.isdamage - def * 1.5f * weak.weakreduce);
			}
			damage.isdamage = 0;
		}
		GameObject.Find ("ehpbar").GetComponent<UISprite> ().fillAmount = (float)(nowhp / hp) * 0.75f + 0.25f;

		switch (step) {
		case 0:
			time += Time.deltaTime;


			if (time > 1f) {
				if (inin) {
					inin = false;
				}
			
				this.GetComponent<UITexture> ().mainTexture = step01;
			}


			if (time > 7f) {
				time = 0;
				step = 1;
				inin = true;
			}
			break;
		case 1:
			if (inin) {
				nowcombo = aaaaa.combo;
				inin = false;
			}
			if (aaaaa.combo >= nowcombo + 9) {
				nowcombo = 0;
				inin = true;
				step = 2;
			}
			this.GetComponent<UITexture> ().mainTexture = step11;
			break;
		case 2:
			time += Time.deltaTime;

			if (time > 1f && time < 7f) {
				if (inin) {
					inin = false;
				}
				this.GetComponent<UITexture> ().mainTexture = step21;
			}

			if (time > 7f && time < 22f) {
				if (inin) {
					inin = false;
				}
				this.GetComponent<UITexture> ().mainTexture = step22;
			}

			if (time > 22f) {
				time = 0;
				step = 3;
				inin = true;
			}

			break;
		case 3:
			time += Time.deltaTime;
			if (time > 1f && time < 13f) {
				if (inin) {
					inin = false;
				}
				this.GetComponent<UITexture> ().mainTexture = step31;
			}

			if (time > 13f && time < 28f) {
				if (inin) {
					inin = false;
				}
				this.GetComponent<UITexture> ().mainTexture = step32;
			}

			if (time > 28f && time < 43f) {
				if (inin) {
					inin = false;
				}
				this.GetComponent<UITexture> ().mainTexture = step33;
			}

			if (time > 43f && time < 53f) {
				if (inin) {
					inin = false;
				}
				this.GetComponent<UITexture> ().mainTexture = step34;
			}

			if (time > 53f) {
				time = 0;
				step = 4;
				inin = true;
			}

		
			break;
		case 4:
			time += Time.deltaTime;
			if (time > 1f && time < 7f) {
				if (inin) {
					inin = false;
				}
				this.GetComponent<UITexture> ().mainTexture = step41;
			}

			if (time > 7f && time < 22f) {
				if (inin) {
					inin = false;
				}
				this.GetComponent<UITexture> ().mainTexture = step42;
				GameObject.Find ("Interface").GetComponent<UIPanel> ().alpha = 1;
			}

			if (time > 22f) {
				time = 0;
				step = 5;
				inin = true;
			}


			break;
		case 5:
			time += Time.deltaTime;
			if (time > 1f && time < 9f) {
				if (inin) {
					inin = false;
				}
				GameObject.Find ("Interface").GetComponent<UIPanel> ().alpha = 0;
				this.GetComponent<UITexture> ().mainTexture = step51;
			}

			if (time > 9f && time < 16f) {
				if (inin) {
					inin = false;
				}
				this.GetComponent<UITexture> ().mainTexture = step52;
			}


			if (time > 16f && time < 51f) {
				if (inin) {
					inin = false;
				}
				this.GetComponent<UITexture> ().mainTexture = step53;

				if (Input.GetKeyDown (KeyCode.Q)) {
					string find0 = GameObject.Find ("UIRoot/0").GetComponent<UITexture> ().mainTexture.name;
					aaaaa.drawcombo = 0;
					cardeffect.nextcard = find0;
					GameObject.Find ("UIRoot/0").GetComponent<carddis> ().poi = true;
				}
			}

			if (time > 51f && time < 61f) {
				if (inin) {
					inin = false;
				}
				this.GetComponent<UITexture> ().mainTexture = step54;
			}

			if (time > 61f) {
				time = 0;
				step = 6;
				inin = true;
			}


			break;
		case 6:
			time += Time.deltaTime;
			if (time > 1f && time < 8f) {
				if (inin) {
					inin = false;
				}
				this.GetComponent<UITexture> ().mainTexture = step61;
			}

			if (time > 8f && time < 33f) {
				if (inin) {
					inin = false;
				}
				this.GetComponent<UITexture> ().mainTexture = step62;
			}

			if (time > 33f && time < 48f) {
				if (inin) {
					inin = false;
				}
				this.GetComponent<UITexture> ().mainTexture = step63;
			}

			if (time > 48f && time < 58f) {
				this.GetComponent<UITexture> ().mainTexture = end;
			}
			if (time > 58f) {
				Application.LoadLevel ("mainmemu");
			}


			break;
		}
	}
}

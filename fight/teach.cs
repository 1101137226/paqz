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
	Transform highpoi;
	Transform lowpoi;
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
	public Texture2D step41;
	public Texture2D step42;
	public Texture2D step51;
	public Texture2D step52;
	public Texture2D step53;
	public Texture2D step61;
	public Texture2D step62;
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
	// Use this for initialization
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
			GameObject.Find (handd.Peek () + "(Clone)").transform.localPosition = new Vector3 (-6600 + q * 1800, -2800, 0);
			GameObject.Find (handd.Dequeue () + "(Clone)").name = System.Convert.ToString (q);
		}
		Instantiate (eloww);
		Instantiate (loww);
		lowpoi = GameObject.Find ("low(Clone)").transform;
		effectctrl.father = lowpoi;
		GameObject.Find ("low(Clone)").transform.parent = father;
		GameObject.Find ("low(Clone)").transform.localPosition = new Vector3 (-10184, -718, 0);
		GameObject.Find ("elow(Clone)").transform.parent = father;
		GameObject.Find ("elow(Clone)").transform.localPosition = new Vector3 (-10184, 913, 0);
		emenyhit.greathit = 0;
		emenyhit.fronthit = 0;
		emenyhit.realhit = 0;
		carddeck = 25;
		inin = true;
		next = false;
		start = false;
		nowhp = hp;
		Debug.Log (nowhp);
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
	
	// Update is called once per frame
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

		//Tutorial Steps
		switch (step) {
		case 0:
			time += Time.deltaTime;

			//Step01
			if (time > 1f) {
				if (inin) {
					inin = false;
					Debug.Log ("Step01");
				}
				this.transform.localPosition = new Vector3 (0, 0, 0);
				this.GetComponent<UITexture> ().mainTexture = step01;
			}

			//HP Combo tpfr
//			if (time >= 2f && time < 4f) {	//HP
//				if (inin) {
//					inin = false;
//					Debug.Log ("HP");
//				}
//				this.GetComponent<UITexture> ().mainTexture = we;
//			} else if (time >= 4f && time < 6f) {//enhp
//				if (!inin) {
//					inin = true;
//					Debug.Log ("ENHP");
//				}
//				this.transform.localPosition = new Vector3 (-1802, -37, 0);
//				this.GetComponent<UITexture> ().mainTexture = EN;
//			} else if (time >= 6f && time < 8f) {	//combo
//				if (inin) {
//					inin = false;
//					Debug.Log ("tpfr");
//				}
//				this.GetComponent<UITexture> ().mainTexture = TPFR;
//				this.transform.localPosition = new Vector3 (622, 1900, 0);
//			} else if (time >= 8f && time < 10f) {	//combo
//				if (!inin) {
//					inin = true;
//					Debug.Log ("combo");
//				}
//				this.GetComponent<UITexture> ().mainTexture = combodis;
//				this.transform.localPosition = new Vector3 (-1070, -544, 0);
//			}

			//Step0 End
			if (time > 7f) {
				time = 0;
				step = 1;
				inin = true;
			}
			break;
		case 1:
			//Step11
			if (inin) {
				nowcombo = aaaaa.combo;
				Debug.Log ("Step11");
				inin = false;
			}
			if (aaaaa.combo >= nowcombo + 19) {
				nowcombo = 0;
				inin = true;
				step = 2;
			}
			this.transform.localPosition = new Vector3 (0, 0, 0);
			this.GetComponent<UITexture> ().mainTexture = step11;
			break;
		case 2:
			time += Time.deltaTime;

			//Step21
			if (time > 1f && time < 7f) {
				if (inin) {
					inin = false;
					Debug.Log ("Step21");
				}
				this.transform.localPosition = new Vector3 (0, 0, 0);
				this.GetComponent<UITexture> ().mainTexture = step21;
			}

			//Step22
			if (time > 7f) {
				if (inin) {
					inin = false;
					Debug.Log ("Step22");
				}
				this.transform.localPosition = new Vector3 (0, 0, 0);
				this.GetComponent<UITexture> ().mainTexture = step22;
			}

			//Step2 End
			if (time > 25f) {
				time = 0;
				step = 3;
				inin = true;
			}

			//en hit combo 5
//			if (inin) {
//				Debug.Log ("emenymove");
//				newtempoeneny.isegu = true;
//				inin = false;
//			}
//			if (time < 2f) {
//				this.GetComponent<UITexture> ().mainTexture = ENTPFR;
//				this.transform.localPosition = new Vector3 (622, 2500, 0);
//			}
//			if (time > 2f) {
//				this.GetComponent<UITexture> ().mainTexture = enhit5;
//				this.transform.localPosition = new Vector3 (-2073, 386, 0);
//				emenyhit.greathit = 10;
//			}
//			if (emenyhit.encombo >= 5) {
//				time = 0;
//				inin = true;
//				step = 3;
//				emenyhit.greathit = 0;
//			}
			break;
		case 3:
			time += Time.deltaTime;
			//Step31
			if (time > 1f && time < 13f) {
				if (inin) {
					inin = false;
					Debug.Log ("Step31");
				}
				this.transform.localPosition = new Vector3 (0, 0, 0);
				this.GetComponent<UITexture> ().mainTexture = step31;
			}

			//Step32
			if(time > 13f && time <31f)
			{
				if(inin)
				{
					inin=false;
					Debug.Log("Step32");
				}
				this.transform.localPosition = new Vector3(0,0,0);
				this.GetComponent<UITexture>().mainTexture=step32;
			}

			//Step33
			if(time > 31f)
			{
				if(inin)
				{
					inin=false;
					Debug.Log("Step33");
				}
				this.transform.localPosition=new Vector3(0,0,0);
				this.GetComponent<UITexture>().mainTexture=step33;
			}

			//Step3 End
			if(time > 49f)
			{
				time=0;
				step=4;
				inin=true;
			}

			//handcard 
//			newtempoeneny.isegu = false;
//			time += Time.deltaTime;
//			if (inin) {
//				Debug.Log ("handcardteach");
//				inin = false;
//			}
//			this.GetComponent<UITexture> ().mainTexture = handdis;
//			this.transform.localPosition = new Vector3 (-6073, 500, 0);
//			if (time > 4f) {
//				time = 0;
//				inin = true;
//				start = false;
//				step = 4;
//				next = false;
//			}
			break;
		case 4:
			time += Time.deltaTime;
			//Step41
			if(time > 1f && time < 7f)
			{
				if(inin)
				{
					inin = false;
					Debug.Log("Step41");
				}
				this.transform.localPosition=new Vector3(0,0,0);
				this.GetComponent<UITexture>().mainTexture =step41;
			}

			//Step42
			if(time >7f)
			{
				if(inin)
				{
					inin=false;
					Debug.Log("Step42");
				}
				this.transform.localPosition=new Vector3(0,0,0);
				this.GetComponent<UITexture>().mainTexture = step42;
				GameObject.Find ("Interface").GetComponent<UIPanel> ().alpha = 1;
			}

			//card use
//			if (inin) {
//				Debug.Log ("please enter q and hit a gu");
//				inin = false;
//				this.GetComponent<UITexture> ().mainTexture = usecard;
//				this.transform.localPosition = new Vector3 (-6073, 500, 0);
//			}
//			if (Input.GetKeyDown (KeyCode.Q) && !start) {
//				string find0 = GameObject.Find ("UIRoot/0").GetComponent<UITexture> ().mainTexture.name;
//				aaaaa.drawcombo = 0;
//				cardeffect.nextcard = find0;
//				GameObject.Find ("UIRoot/0").GetComponent<carddis> ().poi = true;
//				start = true;
//			}
//			if (start) {
//				time += Time.deltaTime;
//				if (time >= 15f) {
//					Instantiate (Resources.Load ("hand/3"));
//					GameObject.Find ("3(Clone)").transform.parent = GameObject.Find ("UIRoot").transform;
//					GameObject.Find ("3(Clone)").transform.localScale = new Vector3 (1, 1, 1);
//					GameObject.Find ("3(Clone)").transform.localPosition = new Vector3 (-6600, -2800, 0);
//					GameObject.Find ("3(Clone)").name = "0";
//					this.GetComponent<UITexture> ().mainTexture = outeffect;
//					this.transform.localPosition = new Vector3 (-3073, 500, 0);
//					Debug.Log ("again");
//					start = false;
//				}
//			}
//			if (time >= 15f) {	
//				time += Time.deltaTime;
//				if (time > 18f) {
//					this.GetComponent<UITexture> ().mainTexture = usecard;
//					this.transform.localPosition = new Vector3 (-6073, 500, 0);
//					Debug.Log ("again");
//					time = 0;
//				}
//			}
//			if (nowhp < hp) {
//				next = true;
//			}
//			if (next) {
//				next = false;
//				start = false;
//				Debug.Log ("low effect press space next");
//				this.GetComponent<UITexture> ().mainTexture = lowbeats;
//				this.transform.localPosition = new Vector3 (-3073, 300, 0);
//				this.transform.localScale = new Vector3 (2, 1, 1);
//				inin = true;
//				step = 5;
//			}
			break;
		case 5:
			if (inin) {
				if (Input.GetKey (KeyCode.Space)) {
					inin = false;
					next = true;
				}
			}
			if (next) {
				Debug.Log ("please hit 5 combo to draw");
				this.transform.localScale = new Vector3 (1, 1, 1);
				this.GetComponent<UITexture> ().mainTexture = draw;
				next = false;
				start = true;
				aaaaa.drawcombo = 0;
			}
			if (start && aaaaa.drawcombo >= 10) {
				aaaaa.drawcombo = 0;
				GameObject.Find ("drawSE").GetComponent<AudioSource> ().Play ();
				carddeck--;
				Instantiate (Resources.Load ("hand/" + handd.Peek ()));
				GameObject.Find (handd.Peek () + "(Clone)").transform.parent = GameObject.Find ("UIRoot").transform;
				GameObject.Find (handd.Peek () + "(Clone)").transform.localScale = new Vector3 (1, 1, 1);
				GameObject.Find (handd.Peek () + "(Clone)").transform.localPosition = new Vector3 (-6600, -4000, 0);
				GameObject.Find (handd.Peek () + "(Clone)").GetComponent<cardfly> ().fly = true;
				GameObject.Find (handd.Dequeue () + "(Clone)").name = "0";
				start = false;
			}
			if (!start && !inin && !next) {
				time += Time.deltaTime;
				this.GetComponent<UITexture> ().mainTexture = leftcard;
				this.transform.localPosition = new Vector3 (-601, -1131, 0);
				if (time > 5f) {
					inin = true;
					step = 6;
					time = 0f;
				}
			}
			break;
		case 6:
			if (inin) {
				Debug.Log ("press k to change to high");
				this.GetComponent<UITexture> ().mainTexture = changetohigh;
				this.transform.localPosition = new Vector3 (-3073, 300, 0);
				inin = false;
			}
			if (Input.GetKeyDown (KeyCode.K) && !start) {
				Destroy (GameObject.Find ("low(Clone)").gameObject);
				Instantiate (highh);
				highpoi = GameObject.Find ("high(Clone)").transform;
				effectctrl.father = highpoi;
				GameObject.Find ("high(Clone)").transform.parent = father;
				GameObject.Find ("high(Clone)").transform.localPosition = new Vector3 (-5184, -718, 0);
				next = true;
			}
			if (next) {
				next = false;
				Debug.Log ("every beats in high effect  press space next");
				this.GetComponent<UITexture> ().mainTexture = highbeats;
				this.transform.localScale = new Vector3 (2, 1, 1);
				start = true;
			}
			if (start && Input.GetKey (KeyCode.Space)) {
				inin = true;
				start = false;
				step = 7;
			}
			break;
		case 7:
			if (inin) {
				inin = false;
				Debug.Log ("in high card also has different effect , press W to try accel card in k");
				this.transform.localScale = new Vector3 (1, 1, 1);
				this.GetComponent<UITexture> ().mainTexture = SPcard;
			}
			if (Input.GetKeyDown (KeyCode.W)) {
				jk = true;
				string find0 = GameObject.Find ("UIRoot/1").GetComponent<UITexture> ().mainTexture.name;
				aaaaa.drawcombo = 0;
				cardeffect.nextcard = find0;
				GameObject.Find ("UIRoot/1").GetComponent<carddis> ().poi = true;
				inin = true;
				step = 8;
			}
			break;
		case 8:
			if (inin) {
				inin = false;
				Debug.Log ("now try card in low ,press k and press q to use card");
				this.GetComponent<UITexture> ().mainTexture = SPcardlow;
				next = true;
			}
			if (Input.GetKeyDown (KeyCode.K) && next) {
				next = false;
				Destroy (GameObject.Find ("high(Clone)").gameObject);
				Instantiate (loww);
				lowpoi = GameObject.Find ("low(Clone)").transform;
				effectctrl.father = lowpoi;
				GameObject.Find ("low(Clone)").transform.parent = father;
				GameObject.Find ("low(Clone)").transform.localPosition = new Vector3 (-10184, -718, 0);
				start = true;
			}
			if (Input.GetKeyDown (KeyCode.Q) && start) {
				jk = false;
				string find0 = GameObject.Find ("UIRoot/0").GetComponent<UITexture> ().mainTexture.name;
				aaaaa.drawcombo = 0;
				cardeffect.nextcard = find0;
				GameObject.Find ("UIRoot/0").GetComponent<carddis> ().poi = true;
				start = false;
				inin = true;
				step = 9;
				time = 0;
			}
			break;
		case 9:
			time += Time.deltaTime;
			if (time < 4f) {	
				if (inin) {
					inin = false;
					Debug.Log ("you see jk is different, these more card has differernt effect with jk");
					this.GetComponent<UITexture> ().mainTexture = enskill;
					start = true;
				}
			} else if (time >= 4f && time < 8f) {
				newtempoeneny.isegu = true;
				enemybpm = 0.6f;
				if (start) {
					start = false;
					Debug.Log ("show emeney skill");
					if (GameObject.Find ("skillboss").gameObject.transform.childCount != 0) {
						GameObject.Find ("bossskill(Clone)").name = "getout";
					}
					Instantiate (bossskill);
					GameObject.Find ("bossskill(Clone)").GetComponent<UITexture> ().mainTexture = fullopen;
				}
			} else if (time > 8f) {
				enemybpm = 0.8f;
				if (!inin) {
					newtempoeneny.isegu = false;
					inin = true;
					this.GetComponent<UITexture> ().mainTexture = exit;
					Debug.Log ("you can see see how card you have and fight");
				}
				if (Input.GetKeyUp (KeyCode.Space)) {
					Debug.Log ("13");
					Application.LoadLevel ("mainmemu");
				}
			}
			break;
		}
	}
}
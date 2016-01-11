using UnityEngine;
using System.Collections;

public class boss80attack : MonoBehaviour
{
	int o;
	byte duflag = 1;
	byte windflag = 0;
	short nowcombo;
	float efftime;
	bool startfly;
	bool inin;
	public Transform father;
	public UITexture duoo;
	public GameObject darke;
	public GameObject bossskill;
	public Texture2D terreye;
	public Texture2D darkcloud;
	public Texture2D dead;
	public Texture2D fullfire;
	public Texture2D fullopen;
	public Texture2D heal;
	public Texture2D jamsonic;
	public Texture2D laser;
	public Texture2D light0;
	public Texture2D nomusic;
	public Texture2D power;
	public Texture2D tsuyosa;
	public Sprite vmp;
	public Sprite vmp2;
	public Sprite vmp3;
	public Sprite vmp4;
	public GameObject cloud;
	Transform mother;
	public GameObject fast;
	public GameObject lasereffect;
	bool ch;

	void Start ()
	{
		inin = true;

		Random.seed = System.Guid.NewGuid ().GetHashCode ();
	
		float nowhp = GameObject.Find ("boss").GetComponent<demoboss> ().nowhp;
		float maxhp = GameObject.Find ("boss").GetComponent<demoboss> ().HP;
		if (nowhp >= 0.8 * maxhp) {				
			o = Random.Range (2, 4);		
		} else if (nowhp < 0.8f * maxhp && nowhp >= 0.5f * maxhp) {					
			o = Random.Range (4, 8);		
		} else if (nowhp < 0.5f * maxhp && nowhp >= 0.3f * maxhp) {				
			o = Random.Range (8, 11);			
		} else if (nowhp < 0.3f * maxhp && nowhp >= 0.1f * maxhp) {					
			o = Random.Range (11, 13);			
		} 
		if (o == 2 || o == 3) {
			if (demoboss.noise >= 3) {
				o = 1;
			}
		}
		efftime = 0.0f;
	}

	void Update ()
	{
		efftime += Time.deltaTime;
		switch (o) {
		case 0:
			efftime = 0.0f;

			Destroy (this.gameObject);
			break;
		case 1:
			if (inin) {
				inin = false;
				demoboss.noise = 0;
				father = GameObject.Find ("UIRoot").transform;
				if (GameObject.Find ("skillboss").gameObject.transform.childCount != 0) {
					GameObject.Find ("bossskill(Clone)").name = "getout";
				}

				Instantiate (bossskill);
				GameObject.Find ("bossskill(Clone)").GetComponent<UITexture> ().mainTexture = terreye;

				Instantiate (Resources.Load ("vmp"));
				GameObject.Find ("vmp(Clone)").transform.parent = father;
				GameObject.Find ("vmp(Clone)").transform.localPosition = new Vector3 (-3000, 0, 0);
				GameObject.Find ("vmp").GetComponent<AudioSource> ().Play ();
			}
			if (efftime < 0.25) {
				GameObject.Find ("vmp(Clone)").GetComponent<SpriteRenderer> ().sprite = vmp;
			} else if (efftime >= 0.25 && efftime < 0.5) {				
				GameObject.Find ("vmp(Clone)").GetComponent<SpriteRenderer> ().sprite = vmp2;
			} else if (efftime >= 0.5 && efftime < 0.75) {				
				GameObject.Find ("vmp(Clone)").GetComponent<SpriteRenderer> ().sprite = vmp3;
			} else if (efftime > 0.75) {				
				GameObject.Find ("vmp(Clone)").GetComponent<SpriteRenderer> ().sprite = vmp4;			
			}

			if (efftime > 1f) {	
				GameObject.Find ("vmp").GetComponent<AudioSource> ().Stop ();
				Destroy (GameObject.Find ("vmp(Clone)").gameObject);
				o = 0;
			}

			break;
		case 2:
			if (inin) {
				inin = false;
				demoboss.noise++;
				if (GameObject.Find ("skillboss").gameObject.transform.childCount != 0) {
					GameObject.Find ("bossskill(Clone)").name = "getout";									
				}
				
				Instantiate (bossskill);

				GameObject.Find ("bossskill(Clone)").GetComponent<UITexture> ().mainTexture = dead;		
			}

			if (efftime > 1 && duflag == 1) {
				GameObject.Find ("dead").GetComponent<AudioSource> ().Play ();
				Instantiate (duoo);
				duflag = 2;
			} else if (efftime > 2 && duflag == 2) {
				GameObject.Find ("dead").GetComponent<AudioSource> ().Play ();
				Instantiate (duoo);
				duflag = 3;
			} else if (efftime > 3 && duflag == 3) {
				GameObject.Find ("dead").GetComponent<AudioSource> ().Play ();
				o = 0;
				Instantiate (duoo);
				duflag = 1;
			}

			break;
		case 3:
			if (inin) {
				inin = false;
				demoboss.noise++;
				if (GameObject.Find ("skillboss").gameObject.transform.childCount != 0) {
					GameObject.Find ("bossskill(Clone)").name = "getout";									
				}
				
				Instantiate (bossskill);
				GameObject.Find ("bossskill(Clone)").GetComponent<UITexture> ().mainTexture = jamsonic;
				mother = GameObject.Find ("trdown").transform;
				Instantiate (Resources.Load ("cloud"));
				GameObject.Find ("cloud(Clone)").transform.parent = mother;
				GameObject.Find ("cloud(Clone)").transform.localPosition = new Vector3 (0, -1f, 0);
				GameObject.Find ("jam").GetComponent<AudioSource> ().Play ();
			}
			if (efftime > 0.2f && GameObject.Find ("trdown").gameObject.transform.childCount != 0) {
				Destroy (GameObject.Find ("cloud(Clone)").gameObject);				
			}
			scriptchange.guchange = false;
			scriptchange.painochange = false;
			scriptchange.posichange = false;
			scriptchange.basschange = false;
			scriptchange.smallchange = false;
			if (efftime >= 2.0f) {
				o = 0;
			}

			break;
		case 4:
			if (inin) {
				inin = false;
				if (GameObject.Find ("skillboss").gameObject.transform.childCount != 0) {
					GameObject.Find ("bossskill(Clone)").name = "getout";									
				}
				
				Instantiate (bossskill);
				GameObject.Find ("bossskill(Clone)").GetComponent<UITexture> ().mainTexture = fullfire;
				this.GetComponent<AudioSource> ().Play ();
			}
			emenyhit.enemydamageup = 2.0f;
			
			if (efftime >= 5.0f) {
				emenyhit.enemydamageup = 1.0f;
				o = 0;
			}
			break;
		case 5:
			if (inin) {
				inin = false;
				if (GameObject.Find ("skillboss").gameObject.transform.childCount != 0) {
					GameObject.Find ("bossskill(Clone)").name = "getout";									
				}
				
				Instantiate (bossskill);
				GameObject.Find ("bossskill(Clone)").GetComponent<UITexture> ().mainTexture = fullopen;
				GameObject.Find ("fullopen").GetComponent<AudioSource> ().Play ();
			}
			bpm.enemybpm = 0.4f;
			if (efftime >= 5.0f) {
				bpm.enemybpm = 0.8f;
				o = 0;
			}
			break;
		case 6:
			if (inin) {
				inin = false;
				if (GameObject.Find ("skillboss").gameObject.transform.childCount != 0) {
					GameObject.Find ("bossskill(Clone)").name = "getout";								
				}
				
				Instantiate (bossskill);
				GameObject.Find ("bossskill(Clone)").GetComponent<UITexture> ().mainTexture = light0;
				GameObject.Find ("light").GetComponent<AudioSource> ().Play ();
			}
			newtempo.isvis = true;
			newtempoeneny.isvis = true;

			if (efftime >= 5.0f) {
				newtempo.isvis = false;
				newtempoeneny.isvis = false;
				o = 0;
			}

			break;
		case 7:
			if (inin) {
				inin = false;
				if (GameObject.Find ("skillboss").gameObject.transform.childCount != 0) {
					GameObject.Find ("bossskill(Clone)").name = "getout";									
				}
				
				Instantiate (bossskill);
				GameObject.Find ("bossskill(Clone)").GetComponent<UITexture> ().mainTexture = laser;
				Instantiate (Resources.Load ("laser"));
				GameObject.Find ("laser").GetComponent<AudioSource> ().Play ();
			}
			if (efftime >= 2.0f) {
				Destroy (GameObject.Find ("laser(Clone)").gameObject);
				charstuas.nowhp = charstuas.nowhp - 2500;
				o = 0;
			}
			break;
		case 8:
			if (inin) {
				if (GameObject.Find ("skillboss").gameObject.transform.childCount != 0) {
					GameObject.Find ("bossskill(Clone)").name = "getout";											
				}
					
				Instantiate (bossskill);
				GameObject.Find ("bossskill(Clone)").GetComponent<UITexture> ().mainTexture = darkcloud;

				inin = false;
				startfly = true;
				bool jk = GameObject.Find ("UIRoot").GetComponent<bactrl> ().jk;
				if (jk == false) {				
					father = GameObject.Find ("UIRoot/low").transform;				
				} else if (jk == true) {				
					father = GameObject.Find ("UIRoot/high").transform;				
				}
				Instantiate (darke);
				GameObject.Find ("darke(Clone)").transform.parent = father;
				GameObject.Find ("darke(Clone)").transform.localPosition = new Vector3 (10, 0, 0);
			}
			if (startfly) {				
				GameObject.Find ("darke(Clone)").transform.localPosition = new Vector3 (10 - efftime * 20f, 0, 0);
				
				if (efftime * 20f > 10) {
					startfly = false;					
				}				
			}
			if (efftime > 5.0f) {
				o = 0;
				Destroy (GameObject.Find ("darke(Clone)").gameObject);
			}

			break;
		case 9:
			if (inin) {
				inin = false;
				if (GameObject.Find ("skillboss").gameObject.transform.childCount != 0) {
					GameObject.Find ("bossskill(Clone)").name = "getout";									
				}
				GameObject.Find ("heal").GetComponent<AudioSource> ().Play ();
				Instantiate (bossskill);
				GameObject.Find ("bossskill(Clone)").GetComponent<UITexture> ().mainTexture = heal;
			}
			if (efftime > 1f && windflag == 0) {
				windflag++;
				GameObject.Find ("ennoeff(Clone)").name = "wind";

			} else if (efftime > 2f && windflag == 1) {
				windflag++;
				GameObject.Find ("ennoeff(Clone)").name = "wind";
			} else if (efftime > 3f && windflag == 2) {
				windflag++;
				GameObject.Find ("ennoeff(Clone)").name = "wind";
			} else if (efftime > 4f && windflag == 3) {
				windflag++;
				GameObject.Find ("ennoeff(Clone)").name = "wind";
			} else if (efftime > 5f) {
				o = 0;
			}

			break;
		case 10:
			if (inin) {
				inin = false;
				if (GameObject.Find ("skillboss").gameObject.transform.childCount != 0) {
					GameObject.Find ("bossskill(Clone)").name = "getout";									
				}
				
				Instantiate (bossskill);
				GameObject.Find ("bossskill(Clone)").GetComponent<UITexture> ().mainTexture = power;
				GameObject.Find ("powerget").GetComponent<AudioSource> ().Play ();
			}
			Instantiate (Resources.Load ("flyboommany"), new Vector3 (0, -0.8f, 0), Quaternion.identity);
			foreach (GameObject fooObj in GameObject.FindGameObjectsWithTag("early")) {
				if (fooObj.name == "noeff(Clone)") {
					fooObj.GetComponent<newtempo> ().todoke = true;
				}				
			}
			o = 0;

			break;
		case 11:
			if (inin) {
				inin = false;
				if (GameObject.Find ("skillboss").gameObject.transform.childCount != 0) {
					GameObject.Find ("bossskill(Clone)").name = "getout";									
				}
				
				Instantiate (bossskill);
				GameObject.Find ("bossskill(Clone)").GetComponent<UITexture> ().mainTexture = nomusic;
				GameObject.Find ("accelSE").GetComponent<AudioSource> ().Play ();
				Instantiate (fast);
				GameObject.Find ("SPEEDGOGO(Clone)").name = "enfast";
			}
			newtempo.eaccel = 3.0f;
			if (efftime >= 5.0f) {
				Destroy (GameObject.Find ("enfast").gameObject);
				newtempo.eaccel = 1.0f;
				o = 0;
			}

			break;
		case 12:
			if (inin) {
				if (GameObject.Find ("skillboss").gameObject.transform.childCount != 0) {
					GameObject.Find ("bossskill(Clone)").name = "getout";											
				}
					
				Instantiate (bossskill);
				GameObject.Find ("bossskill(Clone)").GetComponent<UITexture> ().mainTexture = tsuyosa;
				Instantiate (Resources.Load ("tsuyosa"));
				if (GameObject.Find ("UIRoot").GetComponent<bactrl> ().jk == true) {
					father = GameObject.Find ("UIRoot/high(Clone)").transform;
					GameObject.Find ("tsuyosa(Clone)").transform.parent = father;
					GameObject.Find ("tsuyosa(Clone)").transform.localPosition = new Vector3 (10.5f, 0, 0);
					GameObject.Find ("tsuyosa(Clone)").name = "hh";
					ch = true;
				} else if (GameObject.Find ("UIRoot").GetComponent<bactrl> ().jk == false) {
					father = GameObject.Find ("UIRoot/low(Clone)").transform;
					GameObject.Find ("tsuyosa(Clone)").transform.parent = father;
					GameObject.Find ("tsuyosa(Clone)").transform.localPosition = new Vector3 (10.5f, 0, 0);
					GameObject.Find ("tsuyosa(Clone)").name = "ll";
					ch = false;
				}
				nowcombo = aaaaa.combo;
				GameObject.Find ("haganetsuyosa").GetComponent<AudioSource> ().Play ();
				inin = false;
			}

			if (ch != GameObject.Find ("UIRoot").GetComponent<bactrl> ().changeflag) {
				if (ch) {
					Instantiate (Resources.Load ("tsuyosa"));
					father = GameObject.Find ("UIRoot/low(Clone)").transform;
					GameObject.Find ("tsuyosa(Clone)").transform.parent = father;
					GameObject.Find ("tsuyosa(Clone)").transform.localPosition = new Vector3 (10.5f, 0, 0);
					GameObject.Find ("tsuyosa(Clone)").name = "ll";
				} else if (!ch) {
					Instantiate (Resources.Load ("tsuyosa"));
					father = GameObject.Find ("UIRoot/high(Clone)").transform;
					GameObject.Find ("tsuyosa(Clone)").transform.parent = father;
					GameObject.Find ("tsuyosa(Clone)").transform.localPosition = new Vector3 (10.5f, 0, 0);
					GameObject.Find ("tsuyosa(Clone)").name = "hh";
				}

				ch = GameObject.Find ("UIRoot").GetComponent<bactrl> ().changeflag;
			}

			if (aaaaa.combo > nowcombo) {
				nowcombo = aaaaa.combo;
				charstuas.nowhp = charstuas.nowhp - 100;
			} else {
				nowcombo = aaaaa.combo;
			}

			if (efftime >= 5.0f) {
				if (ch) {
					Destroy (GameObject.Find ("hh").gameObject);
				} else if (!ch) {
					Destroy (GameObject.Find ("ll").gameObject);
				}

				o = 0;			
			}
			break;
		}
	}
}

using UnityEngine;
using System.Collections;
 
public class aaaaa : MonoBehaviour
{
	
	public static short combo;
	float limittime;
	public static short ciangcombo;
	public static short dicombo;
	public static short drawcombo;
	public GameObject atkup;
	public GameObject mm;
	public static bool iskbasson;
	public static bool hit2;
	public GameObject skull;
	bool down;
	public static string nam1;
	public static bool recdown;
	public static bool suckblood;
	float time;
	bool nametime;
	void Start ()
	{
		hit2 = false;
		nametime = true;
		dicombo = 0;
		recdown = false;
		suckblood = false;
		ciangcombo = 0;
		down = true;
		limittime = 0;
		combo = 0;
		drawcombo = 0;
		iskbasson = false;
		hit2 = false;
		nam1 = GameObject.Find ("ground3").GetComponent<SpriteRenderer> ().sprite.name;
	}

	public void damage33 (string a22)
	{
		GameObject.Find ("hitSE").GetComponent<AudioSource> ().Play ();
		if (a22 == "gu") {
			damage.isgu = true;
			if (nam1 == "暗色圖") {
				if (emenyhit.encombo < 10) {			
					recdown = true;
				}
			}	
		} else if (a22 == "ciang") {
			damage.isbass = true;
			if (nam1 == "暗色圖") {
				if (combo > 15) {
					ciangcombo++;
					if (ciangcombo == 10) {
						nametime = false;
						newtempoeneny.meslowdown = 0.5f;
						ciangcombo = 0;
					}							
				}
			}
		} else if (a22 == "piano") {
			damage.ispiano = true;
		} else if (a22 == "di") {
			damage.issmall = true;
			if (nam1 == "暗色圖") {
				suckblood = true;
			}
		} else if (a22 == "ff") {
			damage.issonic = true;
		} else if (a22 == "duo") {
			charstuas.nowhp = charstuas.nowhp - charstuas.maxhp * 0.05f;
		}		
	}

	public void damage22 (string a22)
	{
		GameObject.Find ("hitSE").GetComponent<AudioSource> ().Play ();
		if (a22 == "gu") {
			if (nam1 == "暗色圖") {
				if (emenyhit.encombo < 10) {					
					recdown = true;
				}
			}
			Instantiate (atkup);			
		} else if (a22 == "ciang") {
			iskbasson = true;			
		} else if (a22 == "piano") {
			damage.iskpiano = true;			
		} else if (a22 == "di") {
			damage.isksmall = true;
			if (nam1 == "暗色圖") {
				suckblood = true;
			}			
		} else if (a22 == "ff") {
			Instantiate (atkup);
			iskbasson = true;
			damage.iskpiano = true;
			damage.isksmall = true;
		} else if (a22 == "duo") {
		}	
	}
  
	void OnTriggerStay2D (Collider2D bbb)
	{
		if (bbb.gameObject.tag == "duo") {
			if (Input.GetKey (KeyCode.J) && down) {
				down = false;
				if (this.tag == "late") {
					Instantiate (skull);
					string a22 = bbb.GetComponent<UITexture> ().mainTexture.name;
					damage33 (a22);
					Destroy (bbb.gameObject);
				} else if (this.tag == "early") {
					Instantiate (mm);
					Destroy (bbb.gameObject);
				}								
				down = true;					
			}
		} else if (bbb.gameObject.tag == "early") {
			if (Input.GetKey (KeyCode.J) && down) {
				down = false;
				if (this.tag == "late") {				
					string a22 = bbb.GetComponent<UITexture> ().mainTexture.name;
					bbb.GetComponent<hittwice> ().hitcount++;
				
					if (this.name == "low(Clone)") {
						damage.hitpois = 1.0f;
					} else if (this.name == "front") {
						damage.hitpois = 0.7f;
					} else if (this.name == "real") {
						damage.hitpois = 0.8f;
					}
					damage33 (a22);
					Instantiate (mm);
					combo++;
					drawcombo++;
					soul.soulcombok++;
					bass.basscombo++;
					if (combo >= 3) {
						damage.combodamage += 0.02f;
					}

					Destroy (bbb.gameObject);

				} else if (this.tag == "early") {
					Instantiate (mm);

					string a22 = bbb.GetComponent<UITexture> ().mainTexture.name;
					bbb.GetComponent<hittwice> ().hitcount++;
					if (this.name == "high(Clone)") {
						damage.hitpois = 1.0f;											
					} else if (this.name == "front") {						
						damage.hitpois = 0.7f;						
					} else if (this.name == "real") {
						damage.hitpois = 0.8f;						
					}
						
					damage22 (a22);
					combo++;
					drawcombo++;
					soul.soulcombo++;
					bass.basscombok++;
					if (combo >= 3) {
						damage.combodamage += 0.02f;
					}
					Instantiate (mm);
					Destroy (bbb.gameObject);
				}											
			}
		}	
	}
		
	void Update ()
	{
		if (nametime == false) {
			limittime += Time.deltaTime;
			if (limittime > 3f) {
				newtempoeneny.meslowdown = 1f;
				limittime = 0;
				nametime = true;
			}
		}

		GameObject.Find ("combo").GetComponent<UILabel> ().text = System.Convert.ToString (combo);

		if (Input.GetKey (KeyCode.J)) {				
			time += Time.deltaTime;
			if (time > 0.1f) {
				down = false;
			}		
		}
		if (Input.GetKeyUp (KeyCode.J)) {
			time = 0f;
			down = true;
		}						
	}	
}

using UnityEngine;
using System.Collections;

public class emenyhit : MonoBehaviour {

	public static short greathit;
	public static short fronthit;
	public static short realhit;
	public static Queue atkupup =new Queue();
	public static float enemyatk;
	public static float enhp;
	public static float enemydamageup=1.0f;
	public static bool defupflag;
	public static bool hprec=false;
	public static bool isduo=false;
	public static bool weakrec=false;
	public static float weakatkup=1.0f;
	public static bool iskbasson;
	public static bool iskrec;
	public static float iskpiano;
	public static byte encombo;
	public static float encombodamage=1.0f;
	public static bool weakhprec;
	public GameObject midhit;
	bool atkup;
	static float atkuptime;
	float hitposi;
	public static int i;
	public static bool inin;
	public static bool turn;
	public static float turnsec;
	float turntime;
	void Start () {
		inin = true;
		hitposi=1f;
		encombo=0;
		turn = false;
		turnsec = 0;
	}
	public void damage22(string a22)
	{

		if (!turn) {
						
							if (a22 == "gu") {

								charstuas.hurt = enemyatk * 0.8f * 1.3f * enemydamageup * weakatkup * encombodamage * hitposi;

						} else if (a22 == "ciang") {
								charstuas.hurt = enemyatk * 0.8f * enemydamageup * weakatkup * encombodamage * hitposi;
								charstuas.nowdeff = charstuas.nowdeff * 0.95f;
						} else if (a22 == "piano") {
								charstuas.hurt = enemyatk * 0.8f * enemydamageup * weakatkup * encombodamage * hitposi;
								defupflag = true;
			
						} else if (a22 == "di") {
								charstuas.hurt = enemyatk * 0.3f * enemydamageup * weakatkup * encombodamage * hitposi;
								hprec = true;
			
						} else if (a22 == "duo") {
								isduo = true;
			
						}
				} else if (turn) {
			if (a22 == "gu") {
				
				damage.isdamage = enemyatk * 0.8f * 1.3f * enemydamageup * weakatkup * encombodamage * hitposi;
				
			} else if (a22 == "ciang") {
				damage.isdamage = enemyatk * 0.8f * enemydamageup * weakatkup * encombodamage * hitposi;
				charstuas.nowdeff = charstuas.nowdeff * 0.95f;
			} else if (a22 == "piano") {
				damage.isdamage = enemyatk * 0.8f * enemydamageup * weakatkup * encombodamage * hitposi;
				defupflag = true;
				
			} else if (a22 == "di") {
				damage.isdamage = enemyatk * 0.3f * enemydamageup * weakatkup * encombodamage * hitposi;
				hprec = true;
				
			} else if (a22 == "duo") {
				isduo = true;
				
			}
		
		
		}


		
	}
	public void damage11(string a22)
	{
		if (!turn) {
						if (a22 == "gu") {

								atkup = true;
			
						} else if (a22 == "ciang") {
								iskbasson = true;
						} else if (a22 == "piano") {
								charstuas.hurt = enemyatk * 0.8f * enemydamageup * weakatkup * 0.5f * encombodamage * hitposi;
								iskpiano = enemyatk * 0.8f * enemydamageup * weakatkup * 0.5f * 0.3f * encombodamage * hitposi;
						} else if (a22 == "di") {
								iskrec = true;
			
						} else if (a22 == "duo") {
			
						}
		
				} else if (turn) {

			if (a22 == "gu") {
				
				atkup = true;
				
			} else if (a22 == "ciang") {
				iskbasson = true;
			} else if (a22 == "piano") {
				damage.isdamage = enemyatk * 0.8f * enemydamageup * weakatkup * 0.5f * encombodamage * hitposi;
				iskpiano = enemyatk * 0.8f * enemydamageup * weakatkup * 0.5f * 0.3f * encombodamage * hitposi;
			} else if (a22 == "di") {
				iskrec = true;
				
			} else if (a22 == "duo") {
				
			}

				}
		
	}
	void OnTriggerStay2D(Collider2D bbb)
	{
		
		if (bbb.gameObject.tag == "early") {
			if(this.name=="fr" && inin)
			{
			Random.seed = System.Guid.NewGuid().GetHashCode();
			 i = Random.Range(0, 10);

				inin=false;
			}
			if(this.name=="re")
			{

				inin=true;
			}

			string a22=bbb.GetComponent<UITexture>().mainTexture.name;

			if(i<fronthit)
			{

				if(this.name=="fr")
				{

					encombo++;
					hitposi=0.7f;
				if(this.tag=="late")
				{damage22(a22);}
				else if(this.tag=="early")
				{damage11(a22);}
				
				if(encombo>=3)
				{encombodamage+=0.02f;}
					inin=true;
					GameObject go=(GameObject)Instantiate(midhit);
					go.GetComponent<emhit>().who=true;

				Destroy (bbb.gameObject);
				}
			}else if(i>=fronthit && i<fronthit+greathit)
			{

				if(this.tag=="late")
				{

					if(this.name=="elow(Clone)")
					{
						hitposi=1f;
						encombo++;
					damage22(a22);
						inin=true;
						GameObject go=(GameObject)Instantiate(midhit);
						go.GetComponent<emhit>().who=true;
						Destroy (bbb.gameObject);
					}
				
				}
				else if(this.tag=="early")
				{
					if(this.name=="ehigh(Clone)")
					{
						hitposi=1f;
						encombo++;
						damage11(a22);
						inin=true;
						GameObject go=(GameObject)Instantiate(midhit);
						go.GetComponent<emhit>().who=true;
						Destroy (bbb.gameObject);
					}
				
				
				}

				if(encombo>=3)
				{encombodamage+=0.02f;}

				
			}else if(i>=greathit+fronthit && i<greathit+fronthit+realhit)
			{
				if(this.name=="re")
				{
					hitposi=0.8f;
					encombo++;
				if(this.tag=="late")
				{damage22(a22);}
				else if(this.tag=="early")
				{damage11(a22);}
				
				if(encombo>=3)
				{encombodamage+=0.02f;}
					inin=true;
					GameObject go=(GameObject)Instantiate(midhit);
					go.GetComponent<emhit>().who=true;
				Destroy (bbb.gameObject);

				}
				
			}

			if(weakrec)
			{
				
				weakhprec=true;
				
			}

			
			
		}
	}
	void Update () {
		if (turn) {
				
			turntime+=Time.deltaTime;
		
		}

		if (turntime >= turnsec) {
				
		
			turn=false;
				turntime=0;
			turnsec=0;
		}

		if (atkup == true) {
			atkup=false;

			enemyatk=enemyatk+enemyatk*0.05f;

			atkupup.Enqueue("0");

		}
		if (atkupup.Count > 0) {
			atkuptime += Time.deltaTime;

			if(atkuptime>=10)
			{	

				enemyatk=enemyatk-enemyatk*0.05f;
				atkupup.Dequeue();
				atkuptime=0f;
				
			}
			
			
			
		}
	
		}


}

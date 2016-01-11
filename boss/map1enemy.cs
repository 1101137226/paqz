using UnityEngine;
using System.Collections;

public class map1enemy : MonoBehaviour
{

	public  float HP = 5000;
	public  float atk = 150;
	public  float maxdef = 20;
	float def;
	Queue defupup = new Queue ();
	public float defuptime;
	float skill1 = 10f;
	float nowtime;
	int rec = 30;
	float nowhp;
	bool skill2;

	void Start ()
	{
		bpm.enemybpm = 0.4f;
		newtempoeneny.isegu = true;
		emenyhit.greathit = 3;

		emenyhit.enemyatk = atk;
		nowhp = HP;
		def = maxdef;
		skill2 = true;
		emenyhit.enhp = HP;
	}
	
	void Update ()
	{
		nowtime += Time.deltaTime;
		if (bass.bassreduce) {
				
			def = def - maxdef * 0.1f;
			bass.bassreduce = false;		
		}

		if (nowtime >= skill1) {				
			newtempoeneny.isegu = false;
			newtempoeneny.ispure = true;
		}
		if (nowtime >= skill1 + 3.0f) {
			newtempoeneny.ispure = false;
			newtempoeneny.isegu = true;
			
		}
		if (nowhp <= 1500 && skill2 == true) {
				
			nowhp = nowhp + 1000;
			skill2 = false;
		}
		if (emenyhit.hprec == true) {
			emenyhit.hprec = false;
			nowhp = nowhp + rec;
		
		
		}
		if (emenyhit.isduo == true) {
			emenyhit.isduo = false;		
			nowhp = nowhp - HP * 0.05f;
		
		}

		if (damage.isdamage != 0) {

			if ((damage.isdamage - def * 1.5f) > 0) {
				nowhp = nowhp - (damage.isdamage - def * 1.5f * weak.weakreduce);
				Instantiate (Resources.Load ("skillAttack"));
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

		if (defupup.Count > 0) {
			defuptime += Time.deltaTime;
			if (defuptime >= 10) {
				def = def - 10;
				defupup.Dequeue ();
				defuptime = 0f;

			}	
		
		}


		if (dark.isaru) {
			emenyhit.greathit = 2;


			
		} else {
			
			emenyhit.greathit = 3;

			
		}
		GameObject.Find ("bosshpbar").GetComponent<UISprite> ().fillAmount = (float)(nowhp / HP);


	}
}

using UnityEngine;
using System.Collections;

public class bass : MonoBehaviour {
	public float passtime;
	public static bool bassreduce;
	public static bool bassdown;
	public static byte basscombo=0;
	public static byte basscombok=0;

	bool active;
	bool hatsudou;
	float time;
	float time2;
	Transform father;
	bool inin;
	// Use this for initialization
	void Start () {
		cardeffect.nowcard = 0;
		bactrl.isspc = true;
		basscombo=0;
		basscombok = 0;
		active = false;
		hatsudou=false;
		father = GameObject.Find ("UIRoot").transform;
		Instantiate(Resources.Load("mySkill"));
		GameObject.Find ("mySkill(Clone)").transform.parent = father;
		GameObject.Find ("mySkill(Clone)").transform.localPosition = new Vector3 (-13500, -1819, 0);
		inin = true;
	}
	
	// Update is called once per frame
	void Update () {
		passtime += Time.deltaTime;

		if (passtime < 0.3) {
			GameObject.Find("skilllight").GetComponent<UITexture>().color=new Color(1,1,1,0);
		
						GameObject.Find ("mySkill(Clone)").transform.localPosition = new Vector3 (-13500 + passtime *12000, -1819, 0);
		
				} else if (passtime >= 0.3f && passtime < 0.5f) {
				
			GameObject.Find("skilllight").GetComponent<UITexture>().color=new Color(1,1,1,0+passtime*2);
		
		}
				else if (passtime >= 0.5f && passtime <1f) {

			GameObject.Find("skilllight").transform.localScale=new Vector3(1+(passtime-0.5f),1+(passtime-0.5f),1+(passtime-0.5f));

			GameObject.Find("skilllight").transform.localEulerAngles=new Vector3(0,0,0-(passtime-0.5f)*30f);
				
		}else if (passtime >= 1f && passtime <2f) {
			
			GameObject.Find ("mySkill(Clone)").GetComponent<UITexture>().color=new Color(255,255,255,1-(passtime-1f));
			GameObject.Find ("skilllight").GetComponent<UITexture>().color=new Color(255,255,255,1-(passtime-1f));	
		}else if (passtime >= 2f && inin) {
			
			Destroy(GameObject.Find("mySkill(Clone)").gameObject);
			inin=false;
		}




		if (basscombo >= 2) {
			GameObject.Find("broken").GetComponent<AudioSource>().Play();
			Instantiate(Resources.Load("brokendef"));
			GameObject.Find("brokendef(Clone)").name="123";
			GameObject.Find("123").GetComponent<Animator>().SetBool("broken",true);
			bassreduce=true;
			basscombo=0;
			basscombok=0;
			active=true;
			
		}
		if (active) {
			time+=Time.deltaTime;
				if(time>=0.67)
			{


				Destroy(GameObject.Find("123").gameObject);
				time=0;
				active=false;
			}
		
		
		}

		if (basscombok>=2) {
			GameObject.Find("upSE").GetComponent<AudioSource>().Play();
			Instantiate(Resources.Load("cideff"));
			GameObject.Find("cideff(Clone)").transform.parent=father;
			GameObject.Find("cideff(Clone)").transform.localPosition=new Vector3(-3000,-2800,0);

			hatsudou=true;
			basscombok=0;
			basscombo=0;
			bassdown=true;
			
			
		}
		if (hatsudou) {
			time2+=Time.deltaTime;
			if(time2>=1)
			{	
				Destroy(GameObject.Find("cideff(Clone)").gameObject);
				hatsudou=false;
				time2=0;

			}
		
		
		
		}

		if (passtime >= 10) {
			if(active)
			{

				Destroy(GameObject.Find("123").gameObject);
			}
			if(hatsudou)
			{

				Destroy(GameObject.Find("cideff(Clone)").gameObject);

			}
			bassreduce=false;	
			bassdown=false;
			Destroy(this.gameObject);
			bactrl.isspc = false;
			
		}
	}
}

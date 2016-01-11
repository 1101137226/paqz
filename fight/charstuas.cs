using UnityEngine;
using System.Collections;

public class charstuas : MonoBehaviour {

	public static float maxhp;
	public static float nowhp;

	public static float nowdeff;
	public static float hurt;
	public static float nowatk;
	public static byte reducing=1;
	public static bool issoul;
	public static bool weakhpup = false;
	bool isin;
	void Start () {
	
		issoul = false;
		weakhpup = false;
		maxhp=PlayerPrefs.GetFloat("HP");
		isin=true;
		nowhp = maxhp;
		nowatk=PlayerPrefs.GetFloat("ATK");

		nowdeff=PlayerPrefs.GetFloat("DEF");

	}
	
	void Update () {
		if (isin) {
			nowhp=maxhp;
			isin=false;
			
			
		}

		if (hurt != 0) {

			if(weakhpup==false){
			if((hurt-nowdeff*1.5f)>0){

				
					GameObject.Find("she").GetComponent<face>().hitt=true;

			nowhp=nowhp-(hurt-nowdeff*1.5f)*reducing+1;
			
			}
			}else if(weakhpup)
			{


				nowhp=nowhp+hurt;
				if(nowhp>maxhp)
				{
					nowhp=maxhp;
				}

			}


			hurt=0;
		}

		if (issoul) {
				
			nowhp=nowhp-maxhp*0.015f;
			issoul=false;
		
		
		}

		this.GetComponent<UISprite> ().fillAmount = (float)(nowhp/maxhp)*0.75f;

		if (nowhp <= 0) {
			GameObject.Find("she").GetComponent<face>().diee=true;
			Instantiate(Resources.Load("de"));
		Destroy(this.gameObject);
		}

	
	}
}

using UnityEngine;
using System.Collections;

public class boom : MonoBehaviour {
	float passtime;
	float efftime;
	short startcombo;
	short nowcombo;
	short maxcombo;
	bool inin=false;
	public byte num;
	void Start () {


		if (num == 64) {
			efftime=10f;
			
			
		}else if (num == 65) {
			efftime=15f;
			
			
		}else if (num == 66) {
			efftime=20f;
			
			
		}
		inin = true;
	}
	
	void Update () {
		passtime += Time.deltaTime;

		if (passtime < efftime && inin) {
			
			byte combo = emenyhit.encombo;
			if (combo == 0) {
				startcombo = 0;
			}
			nowcombo = (short)(combo - startcombo);
			
			if (nowcombo > maxcombo) {
				maxcombo = nowcombo;
				
			}
			
			
		}

		if (passtime >= efftime ) {
			if (maxcombo <= 15 && inin) {
				
				if (num == 64) {
				float	rate=GameObject.Find("ehpbar").GetComponent<UISprite>().fillAmount;
				
					damage.isdamage=emenyhit.enhp*rate*0.15f;

					
				} else if (num == 65) {
					float	rate=GameObject.Find("ehpbar").GetComponent<UISprite>().fillAmount;
					
					damage.isdamage=emenyhit.enhp*rate*0.25f;
					
					
				} else if (num == 66) {

					
					float	rate=GameObject.Find("ehpbar").GetComponent<UISprite>().fillAmount;
					
					damage.isdamage=emenyhit.enhp*rate*0.4f;
				}
				
				
				
			}
			
			Destroy (this.gameObject);
		}


	}
}

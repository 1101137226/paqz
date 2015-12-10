using UnityEngine;
using System.Collections;

public class noeffect : MonoBehaviour {
	int nowcard;
	float effecttime;
	public float passtime;
	// Use this for initialization
	void Start () {
		cardeffect.isnoiru = true;
		nowcard = cardeffect.nowcard;
		cardeffect.nowcard = 0;
		if (nowcard == 62) {
			effecttime = 5f;		
			
			
			
		} else if (nowcard == 63) {
			
			effecttime=7f;
			
		}
	}
	
	// Update is called once per frame
	void Update () {
	

		passtime += Time.deltaTime;
		newtempoeneny.ispure = true;
		newtempoeneny.isegu = false;
		newtempoeneny.iseba = false;
		newtempoeneny.isepi = false;
		newtempoeneny.isesm = false;

		if (passtime > effecttime) {
				
			newtempoeneny.ispure=false;
			Destroy(this.gameObject);
		
		}






	}
}

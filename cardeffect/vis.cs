using UnityEngine;
using System.Collections;

public class vis : MonoBehaviour {
	byte nowcard;
	float effecttime;
	public float passtime;
	// Use this for initialization
	void Start () {
		cardeffect.isviiru = true;
		nowcard = cardeffect.nowcard;
		cardeffect.nowcard = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (cardeffect.nowcard>53 && cardeffect.nowcard <= 56 && cardeffect.nowcard != nowcard && cardeffect.nowcard!=0) {
			cardeffect.isviiru = false;
			newtempoeneny.isvison=false;
			Destroy (this.gameObject);
			
		}
		passtime += Time.deltaTime;

		switch (nowcard) {
		case 54:
			effecttime = 5f;
			newtempoeneny.isvison=true;
			if (passtime >= effecttime) {
				cardeffect.isviiru = false;
				newtempoeneny.isvison=false;
				Destroy(this.gameObject);
				
			}
						break;
		case 55:
			effecttime = 7f;
			newtempoeneny.isvison=true;
			if (passtime >= effecttime) {
				cardeffect.isviiru = false;
				newtempoeneny.isvison=false;
				Destroy(this.gameObject);
				
			}
			break;
		case 56:
			effecttime = 10f;
			newtempoeneny.isvison=true;
			if (passtime >= effecttime) {
				cardeffect.isviiru = false;
				newtempoeneny.isvison=false;
				Destroy(this.gameObject);
				
			}
			break;



				}
	}
}

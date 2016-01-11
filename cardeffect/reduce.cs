using UnityEngine;
using System.Collections;

public class reduce : MonoBehaviour {
	byte nowcard;
	float effecttime;
	public float passtime;
	void Start () {
		charstuas.reducing=1;
		cardeffect.isreiru = true;
		nowcard = cardeffect.nowcard;
		cardeffect.nowcard = 0;
	}
	
	void Update () {
	
		if (cardeffect.nowcard>47 && cardeffect.nowcard <= 50 && cardeffect.nowcard != nowcard && cardeffect.nowcard!=0) {
			cardeffect.isreiru = false;
			Destroy (this.gameObject);

		}
		passtime += Time.deltaTime;

		switch(nowcard){
		case 48:

			effecttime = 3f;
			charstuas.reducing=0;
			if (passtime >= effecttime) {
				cardeffect.isreiru = false;
				charstuas.reducing=1;
				Destroy(this.gameObject);
				
			}

			break;
		case 49:
			
			effecttime = 4f;
			charstuas.reducing=0;
			if (passtime >= effecttime) {
				cardeffect.isreiru = false;
				charstuas.reducing=1;
				Destroy(this.gameObject);
				
			}
			
			break;

		case 50:
			
			effecttime = 5f;
			charstuas.reducing=0;
			if (passtime >= effecttime) {
				cardeffect.isreiru = false;
				charstuas.reducing=1;
				Destroy(this.gameObject);
				
			}
			
			break;



		}



	}
}

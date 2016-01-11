using UnityEngine;
using System.Collections;

public class powerbone : MonoBehaviour {
	public float passtime;
	bool jk;
	bool inin;
	void Start () {
		cardeffect.nowcard = 0;
		bactrl.isspc = true;
		jk=GameObject.Find("UIRoot").GetComponent<bactrl>().jk;
		inin = true;
	}
	
	void Update () {
	
		if (jk == false) {
						passtime += Time.deltaTime;
						damage.powerboneup = 4;
			if(inin)
			{inin=false;
				Instantiate(Resources.Load("456789"));
				GameObject.Find("upSE").GetComponent<AudioSource>().Play();
			}
						if (passtime > 10.0f) {
				Destroy(GameObject.Find("456789(Clone)").gameObject);
								charstuas.nowhp = charstuas.nowhp - charstuas.nowhp * 0.5f;
								damage.powerboneup = 0;
								bactrl.isspc = false;
								Destroy (this.gameObject);
			
						}

				} else if (jk) {
			bactrl.isspc = false;
			GameObject.Find("upSE").GetComponent<AudioSource>().Play();
			charstuas.nowhp=charstuas.maxhp*0.5f;
			charstuas.nowatk=charstuas.nowatk*1.5f;
			charstuas.nowdeff=charstuas.nowdeff*0.5f;

		
			Destroy(this.gameObject);
		
		}



	}
}

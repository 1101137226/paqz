using UnityEngine;
using System.Collections;

public class weak : MonoBehaviour {
	public float passtime;
	public static short weakreduce=1;
	bool jk;
	bool inin;
	// Use this for initialization
	void Start () {
	
		cardeffect.nowcard = 0;
		bactrl.isspc = true;
		jk=GameObject.Find("UIRoot").GetComponent<bactrl>().jk;
		inin = true;

	}
	
	// Update is called once per frame
	void Update () {

		passtime += Time.deltaTime;
		if (jk == false) {
						if (passtime >= 10.0f) {
				Destroy(GameObject.Find("456789(Clone)").gameObject);
								damage.weakdamage = 1;
								weakreduce = 1;
								bactrl.isspc = false;
								Destroy (this.gameObject);
			
						}
						if (passtime < 5.0f) {
			
								emenyhit.weakrec = true;
				if(inin)
				{
					
					Instantiate(Resources.Load("hehehe"));
					inin=false;
				}



						}
						if (passtime > 5.0f) {
								if(!inin)
				{
					Destroy(GameObject.Find("hehehe(Clone)").gameObject);
					Instantiate(Resources.Load("456789"));
					inin=true;
					GameObject.Find("upSE").GetComponent<AudioSource>().Play();
				}
								emenyhit.weakrec = false;
								damage.weakdamage = 2;
								weakreduce = 0;
				bactrl.isspc = false;
						}
				} else if (jk == true) {
				
		
			if (passtime >= 10.0f) {

				bactrl.isspc = false;
				Destroy(GameObject.Find("hihihi(Clone)").gameObject);
				charstuas.weakhpup=false;
				Destroy (this.gameObject);
				
			}else if (passtime < 5.0f) {
				if(inin)
				{inin=false;
					Instantiate(Resources.Load("99"));}
				emenyhit.weakatkup=2.0f;
				
				
				
			}else if (passtime > 5.0f) {

				if(!inin)
				{inin=true;
					Destroy(GameObject.Find("99(Clone)").gameObject);
					Instantiate(Resources.Load("hihihi"));}
				emenyhit.weakatkup=1.0f;
				charstuas.weakhpup=true;
				bactrl.isspc = false;

			}
		
		
		
		
		
		}

	
	}
}

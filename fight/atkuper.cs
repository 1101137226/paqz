using UnityEngine;
using System.Collections;

public class atkuper : MonoBehaviour {
	public float atkupnowtime;
	float nowatkup;
	void Start () {

		nowatkup = charstuas.nowatk * 0.05f;
			charstuas.nowatk =charstuas.nowatk+charstuas.nowatk*0.05f;
	
	}
	
	void Update () {
	

		
		atkupnowtime += Time.deltaTime;
		if (atkupnowtime >= 10f) {
			
			atkupnowtime =0f;
			charstuas.nowatk=charstuas.nowatk-nowatkup;
			Destroy(this.gameObject);
			
		}

	}
}

using UnityEngine;
using System.Collections;

public class defup : MonoBehaviour {



	public float defupnowtime;
	// Use this for initialization
	void Start () {
	
		charstuas.nowdeff+=10;
	}
	
	// Update is called once per frame
	void Update () {
	
		defupnowtime += Time.deltaTime;
		if (defupnowtime >= 5f) {
				
			defupnowtime =0f;
			charstuas.nowdeff=charstuas.nowdeff-10;
			Destroy(this.gameObject);
		
		}



	}
}

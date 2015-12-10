using UnityEngine;
using System.Collections;

public class soul : MonoBehaviour {


	public float passtime;
	public static byte soulcombo;
	public static byte soulcombok;
	public static byte num;
	// Use this for initialization
	void Start () {
	
		cardeffect.nowcard = 0;
		soulcombo = 0;
		soulcombok = 0;
		bactrl.isspc = true;
	}
	
	// Update is called once per frame
	void Update () {
	
		passtime += Time.deltaTime;
		if (passtime > 10.0f) {
			bactrl.isspc = false;
			Destroy(this.gameObject);
		
		}

		if (soulcombo == 4) {
			GameObject.Find("soulSE").GetComponent<AudioSource>().Play();
			soulcombo=0;
			soulcombok=0;
			charstuas.issoul=true;
			GameObject.Find("ennoeff(Clone)").name="POI";
			GameObject.Find("ennoeff(Clone)").name="POI2";
			GameObject.Find("POI").GetComponent<newtempoeneny>().gogo=true;
			GameObject.Find("POI2").GetComponent<newtempoeneny>().gogo=true;

		
		
		}
		if (soulcombok == 2) {
			soulcombo=0;
			soulcombok=0;
			GameObject.Find("ennoeff(Clone)").name="nanodesu";
			GameObject.Find("nanodesu").GetComponent<newtempoeneny>().give=true;
		
		}




	}
}

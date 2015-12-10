using UnityEngine;
using System.Collections;

public class origin : MonoBehaviour {
	public float passtime;
	public static bool sonic=false;
	bool inin;
	public GameObject eff;
	// Use this for initialization
	void Start () {

		cardeffect.nowcard = 0;
		bactrl.isspc = true;
		scriptchange.guchange = false;
		scriptchange.painochange = false;
		scriptchange.posichange = false;
		scriptchange.basschange = false;
		scriptchange.smallchange = false;
		bpm.tempobpm = 0.4f;
		inin = true;

	}
	
	// Update is called once per frame
	void Update () {
	
		passtime += Time.deltaTime;
		sonic = true;
		if (inin) {
			inin=false;
			Instantiate(eff);
			GameObject.Find("maobunbun(Clone)").transform.parent=effectctrl.father;
			GameObject.Find("maobunbun(Clone)").transform.localPosition=new Vector3(0,0,0);
			GameObject.Find("maobunbun(Clone)").transform.name="mao";
		
		}
		if (bactrl.sonicflag) {
			Destroy(GameObject.Find("mao").gameObject);
			bactrl.sonicflag=false;
		
			Instantiate(eff);
			Debug.Log(effectctrl.father);
			GameObject.Find("maobunbun(Clone)").transform.parent=effectctrl.father;
			GameObject.Find("maobunbun(Clone)").transform.localPosition=new Vector3(0,0,0);
			GameObject.Find("maobunbun(Clone)").transform.name="mao";
		
		}
		if (passtime > 10.0f) {
			bactrl.isspc=false;
			sonic=false;
			bpm.tempobpm=0.8f;
			Destroy(GameObject.Find("mao").gameObject);
			Destroy(this.gameObject);
			
		}

			
	}
}

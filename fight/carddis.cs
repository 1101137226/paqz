using UnityEngine;
using System.Collections;
	
public class carddis : MonoBehaviour {
	public bool poi=false;
	float poitime;
	void Start () {
		poi = false;
	
	}
	
	void Update () {

		if (poi) 
		{
			poitime += Time.deltaTime;
			this.GetComponent<UITexture> ().color = new Color (255, 255, 255,1-0.8f*poitime);
		
		
		}
		if (this.GetComponent<UITexture> ().alpha < 0f) {
			poi=false;
			poitime=0f;
			Destroy(this.gameObject);
		
		}


	}
}

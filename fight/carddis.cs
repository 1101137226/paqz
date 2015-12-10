using UnityEngine;
using System.Collections;
	
public class carddis : MonoBehaviour {
	public bool poi=false;
	float poitime;
	// Use this for initialization
	void Start () {
		poi = false;
	
	}
	
	// Update is called once per frame
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

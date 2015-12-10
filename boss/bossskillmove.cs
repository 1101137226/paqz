using UnityEngine;
using System.Collections;

public class bossskillmove : MonoBehaviour {
	public Transform father;
	float time;

	public bool getout;
	bool outflag;
	// Use this for initialization
	void Start () {

		getout = false;
		outflag = false;
		father = GameObject.Find ("skillboss").transform;
		this.transform.parent = father;
		this.transform.localScale = new Vector3 (1,1,1);
		this.transform.localPosition = new Vector3 (0, 0, 0);
		time = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {

		time += Time.deltaTime;
		if (time >= 1.5f) {
						if (!outflag) {
								outflag = true;

						}


						this.GetComponent<UITexture> ().color = new Color (255, 255, 255, 1f - (time - 1.5f));
			
						if (time >= 2.5f) {
								Destroy (this.gameObject);
				
				
						}
				
		
				}
		if (this.name == "getout") {
				
		
		
			Destroy(this.gameObject);
		}
	
	}
}

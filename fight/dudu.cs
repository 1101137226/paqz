using UnityEngine;
using System.Collections;

public class dudu : MonoBehaviour {
	float now;
	public float timer;
	public Transform father;
	public Transform gave;
	public static bool isvison;
	public bool give;
	bool giveflag=true;
	short givepos;
	public float givedelay;
	public static int duospeed;
	void Start () {
	
		duospeed = 6000;
		father = GameObject.Find ("en").transform;
		gave =GameObject.Find("me").transform;
		this.transform.parent=father;
		this.transform.localPosition = new Vector3 (17000,0, -100);
	}
	
	void Update () {
	
		now = 17000 - timer * duospeed;

		if (give) {
			if (giveflag) {
				givepos = (short)now;
				giveflag = false;
			}
			givedelay += Time.deltaTime;
			this.transform.localPosition = new Vector3 (givepos,0-givedelay*5000, -100);	
			
			if (givedelay>0.3f) {
				give = false;
				this.transform.parent = gave;
			}
			
			
			
		}	 else if (this.transform.parent.gameObject == GameObject.Find ("en").gameObject) {
			
						timer += Time.deltaTime;
				this.transform.localPosition = new Vector3 (now,0, -100);
				
			
			if (this.transform.position.x < -36f) {
				
								Destroy (this.gameObject);
						}
		
		
		
				} else if (this.transform.parent.gameObject == GameObject.Find ("me").gameObject) {
						timer += Time.deltaTime;
			this.transform.localPosition = new Vector3 (now,0, -100);
			if (this.transform.position.x < -36f) {
				
				Destroy (this.gameObject);
			}
		
		}







	}
}

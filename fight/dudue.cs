using UnityEngine;
using System.Collections;

public class dudue : MonoBehaviour {
	float nowy;
	public float timer;
	public bool gogo;
	public Transform father;
	public Transform todoketran;
	float nowPosition;
	public  bool todoke;
	bool todokeflag=true;
	float todokedelay;
	short todokenow;
	public static int duospeed;
	void Start () {
		duospeed = 4500;
		father = GameObject.Find ("me").transform;
		todoketran=GameObject.Find("en").transform;
		this.transform.parent=father;
		this.transform.localPosition = new Vector3 (17000,0, -100);
	
	}
	
	void Update () {

		gogo = false;
		nowPosition = 17000 - timer * duospeed;
		
		
		
		if (todoke) {
			
			
			if(todokeflag)
			{
				
				todokenow=(short)nowPosition;
				todokeflag=false;
			}
			
			todokedelay+=Time.deltaTime;
			this.transform.localPosition=new Vector3(todokenow,0+todokedelay*5000,-100);
			if(todokedelay>0.3f)
			{todoke=false; this.transform.parent=todoketran;}
			
			
		} 
		else if (gogo) {

				this.name="POI";
			nowy+=Time.deltaTime;
			this.transform.localPosition = new Vector3 (nowPosition,nowy*-9000, -100);
			if(nowy>3f)
			{Destroy(this.gameObject);}
			
			
		}
		else if (this.transform.parent.gameObject == GameObject.Find ("en").gameObject) {
			
			timer += Time.deltaTime;
			this.transform.localPosition = new Vector3 (nowPosition,0, -100);
			
			
			if (this.transform.position.x <= -36f) {
				
				
				
				
				Destroy (this.gameObject);
			}
			
			
			
		} else if (this.transform.parent.gameObject == GameObject.Find ("me").gameObject) {
			timer += Time.deltaTime;
			this.transform.localPosition = new Vector3 (nowPosition,0, -100);
			if (this.transform.position.x <= -36f) {
				
				
				
				
				Destroy (this.gameObject);
			}
			
		}

	
	}
}

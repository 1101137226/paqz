using UnityEngine;
using System.Collections;

public class MainSubSwich : MonoBehaviour {
	public static bool who;
	public Texture2D a;
	public Texture2D b;
	// Use this for initialization
	void Start () {
	
	}
	public void OnPress(bool ispress){


		if (this.name == "main") {
				
			who=false;
			GameObject.Find("Swich").GetComponent<UITexture>().mainTexture=a;

		
		}
		if (this.name == "sub") {
				
		
			who=true;
			GameObject.Find("Swich").GetComponent<UITexture>().mainTexture=b;
		}




		}
	// Update is called once per frame
	void Update () {
	
	}
}

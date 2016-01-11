using UnityEngine;
using System.Collections;

public class MainSubSwich : MonoBehaviour {
	public static bool who;
	public Texture2D a;
	public Texture2D b;
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
	void Update () {
	
	}
}

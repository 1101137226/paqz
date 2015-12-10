using UnityEngine;
using System.Collections;

public class pausehover : MonoBehaviour {
	public bool here;
	public Texture2D resume;
	public Texture2D resumeL;
	public Texture2D backmain;
	public Texture2D backmainL;
	// Use this for initialization
	void Start () {
	
	}
	void OnHover( bool isOver )
	{
		if (isOver) {
			
			if(here)
			{
				GameObject.Find("resume").GetComponent<UITexture>().mainTexture=resumeL;
				GameObject.Find("mainmemu").GetComponent<UITexture>().mainTexture=backmain;
				GameObject.Find("musicgogo").GetComponent<pause>().now=true;

			}
			if(!here)
			{
				GameObject.Find("resume").GetComponent<UITexture>().mainTexture=resume;
				GameObject.Find("mainmemu").GetComponent<UITexture>().mainTexture=backmainL;
				GameObject.Find("musicgogo").GetComponent<pause>().now=false;

			}
			
			
		}
	}
	public void OnPress(bool ispress){
		if (ispress) {
			
			
			GameObject.Find("musicgogo").GetComponent<pause>().flag=true;
			
			
		}
		
	}
	// Update is called once per frame
	void Update () {
	
	}
}

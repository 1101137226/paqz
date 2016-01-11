using UnityEngine;
using System.Collections;

public class face : MonoBehaviour {
	public Sprite win;
	public Sprite hit;
	public Sprite die;
	public Sprite no;
	public bool winn;
	public bool hitt;
	public bool diee;
	float time;
	void Start () {
	
	}
	
	void Update () {
	
		if (winn) {
				
			this.GetComponent<UI2DSprite>().sprite2D=win;
		
				} else if (diee) {
				
			this.GetComponent<UI2DSprite>().sprite2D=die;
		
		}else if (hitt) {
			time+=Time.deltaTime;
			this.GetComponent<UI2DSprite>().sprite2D=hit;
		
		
		}
		if (time > 0.5f) {
			hitt=false;
		
			time=0;
			this.GetComponent<UI2DSprite>().sprite2D=no;
		
		}






	}
}

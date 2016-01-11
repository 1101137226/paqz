using UnityEngine;
using System.Collections;

public class scriptchange : MonoBehaviour {
		

	public static bool guchange;
	public static bool painochange;
	public static bool posichange;
	public static bool basschange;
	public static bool smallchange;
	public static bool getback;
	GameObject colorch;
	int nowcard;
	 float effecttime;
	public float passtime;
	void Start () {
		cardeffect.ischiru = true;
		nowcard = cardeffect.nowcard;
		cardeffect.nowcard = 0;
		guchange = false;
		painochange = false;
		posichange = false;
		basschange = false;
		smallchange = false;

		colorch = GameObject.Find ("trdown").gameObject;
	}
	
	void Update () {

						if (cardeffect.nowcard <= 24 && cardeffect.nowcard != nowcard && cardeffect.nowcard!=0) {
			cardeffect.ischiru = false;
								Destroy (this.gameObject);
								
						}
				
		passtime += Time.deltaTime;

	
		switch (nowcard) {
			
				
			
				case 1:
			colorch.GetComponent<SpriteRenderer>().color=new Color(255,0,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
						effecttime = 5f;
						guchange = true;

						if (passtime >= effecttime) {
								guchange = false;
								getback=true;
				cardeffect.ischiru = false;
				bpm.tempobpm = 0.8f;
								Destroy(this.gameObject);
								
						}
			
			
						break;
				case 2:
			colorch.GetComponent<SpriteRenderer>().color=new Color(255,0,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
						effecttime = 10f;
						guchange = true;
						if (passtime >= effecttime) {

								guchange = false;
								getback=true;
				cardeffect.ischiru = false;
				bpm.tempobpm = 0.8f;
								Destroy(this.gameObject);
								
						}
			
			
						break;
				case 3:
				colorch.GetComponent<SpriteRenderer>().color=new Color(255,0,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
						effecttime = 15f;
						guchange = true;
						if (passtime >= effecttime) {
					
								guchange = false;
								getback=true;
				cardeffect.ischiru = false;
				bpm.tempobpm = 0.8f;
								Destroy(this.gameObject);getback=true;
								
						}
			
			
						break;
				case 4:
			colorch.GetComponent<SpriteRenderer>().color=new Color(0,255,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
						effecttime = 5f;
						basschange = true;
						if (passtime >= effecttime) {
								basschange = false;
								getback=true;
				cardeffect.ischiru = false;
				bpm.tempobpm = 0.8f;
								Destroy(this.gameObject);
								
						}
			
			
						break;
				case 5:
			colorch.GetComponent<SpriteRenderer>().color=new Color(0,255,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
						effecttime = 10f;
						basschange = true;
						if (passtime >= effecttime) {
								basschange = false;
								getback=true;
				cardeffect.ischiru = false;
				bpm.tempobpm = 0.8f;
								Destroy(this.gameObject);
								
						}
						break;
				case 6:
			colorch.GetComponent<SpriteRenderer>().color=new Color(0,255,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
						effecttime = 15f;
						basschange = true;
						if (passtime >= effecttime) {
								basschange = false;
								getback=true;
				cardeffect.ischiru = false;
				bpm.tempobpm = 0.8f;
								Destroy(this.gameObject);
								
						}
						break;
				case 7:
			colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
						effecttime = 5f;
						smallchange = true;
						if (passtime >= effecttime) {
								smallchange = false;
								getback=true;
				cardeffect.ischiru = false;
				bpm.tempobpm = 0.8f;
								Destroy(this.gameObject);	
								
						}
			
						break;
				case 8:
			colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
						effecttime = 10f;
						smallchange = true;
						if (passtime >= effecttime) {
								smallchange = false;
								getback=true;
				cardeffect.ischiru = false;
				bpm.tempobpm = 0.8f;
								Destroy(this.gameObject);
								
						}
			
						break;
				case 9:
			colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
						effecttime = 15f;
						smallchange = true;
						if (passtime >= effecttime) {
								smallchange = false;
								getback=true;
				cardeffect.ischiru = false;
				bpm.tempobpm = 0.8f;
								Destroy(this.gameObject);
								
						}
			
						break;
				case 10:
			colorch.GetComponent<SpriteRenderer>().color=new Color(0,0,255);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
						effecttime = 5f;
						painochange = true;
						if (passtime >= effecttime) {
								painochange = false;
								getback=true;
				cardeffect.ischiru = false;
				bpm.tempobpm = 0.8f;
								Destroy(this.gameObject);
								
						}
			
						break;
				case 11:
			colorch.GetComponent<SpriteRenderer>().color=new Color(0,0,255);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
						effecttime = 10f;
						painochange = true;
						if (passtime >= effecttime) {
								painochange = false;
								getback=true;
				cardeffect.ischiru = false;
				bpm.tempobpm = 0.8f;
								Destroy(this.gameObject);
								
						}
			
						break;
				case 12:
			colorch.GetComponent<SpriteRenderer>().color=new Color(0,0,255);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
						effecttime = 15f;
						painochange = true;
						if (passtime >= effecttime) {
								painochange = false;
								getback=true;
				cardeffect.ischiru = false;
				bpm.tempobpm = 0.8f;
								Destroy(this.gameObject);
						}
			
						break;
			
				case 13:
			colorch.GetComponent<SpriteRenderer>().color=new Color(255,0,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
						effecttime = 7f;
						guchange = true;
						bpm.tempobpm = 0.4f;
						if (passtime >= effecttime) {
								guchange = false;
								getback=true;
				cardeffect.ischiru = false;
								bpm.tempobpm = 0.8f;
								Destroy(this.gameObject);
						}
			
						break;
				case 14:
			colorch.GetComponent<SpriteRenderer>().color=new Color(255,0,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
						effecttime = 10f;
						guchange = true;
						bpm.tempobpm = 0.4f;
						if (passtime >= effecttime) {
								guchange = false;
								getback=true;
				cardeffect.ischiru = false;
								bpm.tempobpm = 0.8f;
								Destroy(this.gameObject);
						}
			
						break;
				case 15:
			colorch.GetComponent<SpriteRenderer>().color=new Color(255,0,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
						effecttime = 13f;
						guchange = true;
						bpm.tempobpm = 0.4f;
						if (passtime >= effecttime) {
								guchange = false;
								getback=true;
				cardeffect.ischiru = false;
								bpm.tempobpm = 0.8f;
								Destroy(this.gameObject);
						}
			
						break;
				case 16:
			colorch.GetComponent<SpriteRenderer>().color=new Color(0,255,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
						effecttime = 7f;
						basschange = true;
						bpm.tempobpm = 0.4f;
						if (passtime >= effecttime) {
								basschange = false;
								getback=true;
				cardeffect.ischiru = false;
								bpm.tempobpm = 0.8f;
								Destroy(this.gameObject);
						}
			
						break;
				case 17:
			colorch.GetComponent<SpriteRenderer>().color=new Color(0,255,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
						effecttime = 10f;
						basschange = true;
						bpm.tempobpm = 0.4f;
						if (passtime >= effecttime) {
								basschange = false;
								getback=true;
				cardeffect.ischiru = false;
								bpm.tempobpm = 0.8f;
								Destroy(this.gameObject);
						}
			
						break;
				case 18:
			colorch.GetComponent<SpriteRenderer>().color=new Color(0,255,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
						effecttime = 13f;
						basschange = true;
						bpm.tempobpm = 0.4f;
						if (passtime >= effecttime) {
								basschange = false;
								getback=true;
				cardeffect.ischiru = false;
								bpm.tempobpm = 0.8f;
								Destroy(this.gameObject);
						}
			
						break;
				case 19:
			colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
						effecttime = 7f;
						smallchange = true;
						bpm.tempobpm = 0.4f;
						if (passtime >= effecttime) {
								smallchange = false;
								getback=true;
				cardeffect.ischiru = false;
								bpm.tempobpm = 0.8f;
								Destroy(this.gameObject);
						}
			
						break;
				case 20:
			colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
						effecttime = 10f;
						smallchange = true;
						bpm.tempobpm = 0.4f;
						if (passtime >= effecttime) {
								smallchange = false;
								getback=true;
				cardeffect.ischiru = false;
								bpm.tempobpm = 0.8f;
								Destroy(this.gameObject);		
						}
			
						break;
				case 21:
			colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,0);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
						effecttime = 13f;
						smallchange = true;
						bpm.tempobpm = 0.4f;
						if (passtime >= effecttime) {
								smallchange = false;
								getback=true;
				cardeffect.ischiru = false;
								bpm.tempobpm = 0.8f;
								Destroy(this.gameObject);		
						}
			
						break;
				case 22:
			colorch.GetComponent<SpriteRenderer>().color=new Color(0,0,255);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
						effecttime = 7f;
						painochange = true;
						bpm.tempobpm = 0.4f;
						if (passtime >= effecttime) {
								painochange = false;
								getback=true;
				cardeffect.ischiru = false;
								bpm.tempobpm = 0.8f;
								Destroy(this.gameObject);	
						}
			
						break;
				case 23:
			colorch.GetComponent<SpriteRenderer>().color=new Color(0,0,255);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
						effecttime = 10f;
						painochange = true;
						bpm.tempobpm = 0.4f;
						if (passtime >= effecttime) {
								painochange = false;
								getback=true;
				cardeffect.ischiru = false;
									bpm.tempobpm = 0.8f;
								Destroy(this.gameObject);			
						}
			
						break;
				case 24:
			colorch.GetComponent<SpriteRenderer>().color=new Color(0,0,255);
			if(passtime>0.175f)
			{colorch.GetComponent<SpriteRenderer>().color=new Color(255,255,255);}
						effecttime = 13f;
						painochange = true;
						bpm.tempobpm = 0.4f;
						if (passtime >= effecttime) {
								painochange = false;
								getback=true;
				cardeffect.ischiru = false;
								bpm.tempobpm = 0.8f;
								Destroy(this.gameObject);		
						}
			
						break;

				}





	}
}

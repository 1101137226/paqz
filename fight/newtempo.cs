using UnityEngine;
using System.Collections;

public class newtempo : MonoBehaviour {
	float nowy;
	public float timer;
	public static int speed;
	public Transform father;
	public Transform todoketran;
	public bool gogo;
	public Texture2D pure;
	public Texture2D gu;
	public Texture2D piano;
	public Texture2D small;
	public Texture2D bass;
	public Texture2D posi;
	public Texture2D ori;
	public  bool todoke;
	public float nowPosition;
	bool todokeflag=true;
	float todokedelay;
	short todokenow;
	public byte howmanyhit;
	public static float eaccel=1.0f;
	public bool isdu;
	public static bool isvis;

	// Use this for initialization
	void Start () {
		gogo = false;
		howmanyhit=0;
		speed = 8000;
		father = GameObject.Find ("me").transform;
		todoketran=GameObject.Find("en").transform;
	//	pe= GameObject.Find("tpfr").transform;
		this.transform.parent=father;
	//	this.transform.localPosition = new Vector3 (-6756,3800, -100);

		this.transform.localPosition = new Vector3 (17000,0, -100);

		isdu = false;

		this.GetComponent<UITexture> ().mainTexture = pure;
		scriptchange.guchange = false;
		scriptchange.painochange = false;
		scriptchange.posichange = false;
		scriptchange.basschange = false;
		scriptchange.smallchange = false;
	
	}


	// Update is called once per frame

        void Update () {


		nowPosition = 17000 - timer * speed*eaccel;


		if (todoke) {
			

			if(todokeflag)
			{

				todokenow=(short)nowPosition;
				todokeflag=false;
			}

			todokedelay+=Time.deltaTime;
			this.transform.localPosition=new Vector3(todokenow,0+todokedelay*5000,-100);
			if(todokedelay>0.3f)
			{todoke=false; this.transform.parent=todoketran;Destroy(GameObject.Find("flyboommany(Clone)").gameObject);}
			
			
		}else if (gogo) {

			this.name="POI";
			nowy+=Time.deltaTime;
			this.transform.localPosition = new Vector3 (nowPosition,nowy*-9000, -100);
			if(nowy>3f)
			{Destroy(this.gameObject);}
			
			
		}





		else if (this.transform.parent.gameObject ==GameObject.Find("me").gameObject){
			this.transform.localPosition = new Vector3 (nowPosition,0, -100);
					timer += Time.deltaTime;

						if (origin.sonic) {

							this.GetComponent<UITexture> ().mainTexture = ori;
				
				
			}else if(isdu){

				this.GetComponent<UITexture> ().mainTexture =posi;

			} 		

							else if (scriptchange.painochange) {
			
								this.GetComponent<UITexture> ().mainTexture = piano;
			
						} else if (scriptchange.posichange) {
			
								this.GetComponent<UITexture> ().mainTexture = posi;
			
						} else if (scriptchange.basschange) {
			
								this.GetComponent<UITexture> ().mainTexture = bass;
			
						} else if (scriptchange.smallchange) {
								
								this.GetComponent<UITexture> ().mainTexture = small;
			
			}else if(scriptchange.guchange){
				this.GetComponent<UITexture> ().mainTexture = gu;


			}  else {
				
				this.GetComponent<UITexture> ().mainTexture = pure;
				
			}


			if (this.transform.position.x <= -35f) {


								aaaaa.combo = 0;
								aaaaa.drawcombo = 0;
								damage.combodamage=1.0f;
								Destroy (this.gameObject);
						}

			if(isvis)
			{
				this.GetComponent<UITexture> ().color = new Color (255, 255, 255, 0.1f);


			}else{

				this.GetComponent<UITexture> ().color = new Color (255, 255, 255,1f);

			}

		} else if (this.transform.parent==GameObject.Find("en").transform) {
				
			timer += Time.deltaTime;
			this.transform.localPosition = new Vector3 (nowPosition,0, -100);

		





			if (this.transform.position.x <= -40f) {
				
				emenyhit.encombo=0;
				emenyhit.encombodamage=1.0f;

				
				Destroy (this.gameObject);
			}
		
		
		
		
		}

	}




	
}



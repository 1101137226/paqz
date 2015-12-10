using UnityEngine;
using System.Collections;

public class newtempoeneny : MonoBehaviour {
	float now;
	public float timer;
	public Transform father;
	public Transform gave;
	public Texture2D pure;
	public Texture2D gu;
	public Texture2D piano;
	public Texture2D small;
	public Texture2D bass;
	public Texture2D posi;
	public static bool isegu;
	public static bool iseba;
	public static bool isepi; 		
	public static bool isesm;
	public static bool ispure;
	public static int enemyspeed;
	public static bool isvison;
	public bool give;
	public bool gogo=false;
	bool giveflag=true;
	short givepos;
	public float givedelay;
	float nowy;
	public static float meslowdown=1.0f;
	public	bool isdu;
	public static bool isvis;

	// Use this for initialization
	void Start () {

		enemyspeed = 8000;
		father = GameObject.Find ("en").transform;
		gave =GameObject.Find("me").transform;
		//	pe= GameObject.Find("tpfr").transform;
		this.transform.parent=father;
		//	this.transform.localPosition = new Vector3 (-6756,3800, -100);
		
		this.transform.localPosition = new Vector3 (17000,0, -100);
		


		
		
	}
	
	
	// Update is called once per frame
	
	void Update () {
		

		now = 17000 - timer * enemyspeed*meslowdown;

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

		
					
				} else if (gogo) {

			this.name="POI";
			nowy+=Time.deltaTime;
			this.transform.localPosition = new Vector3 (now,nowy*9000, -100);
			if(nowy>3f)
			{Destroy(this.gameObject);}
		
		
		}
		else if (this.transform.parent.gameObject == GameObject.Find ("en").gameObject) {

			timer += Time.deltaTime;
			this.transform.localPosition = new Vector3 (now,0, -100);
						
							if(isdu)
			{

				this.GetComponent<UITexture> ().mainTexture = posi;

			}


						else if (ispure) {
				
							this.GetComponent<UITexture> ().mainTexture = pure;
				
							}
						
						else if (isegu) {
				
								this.GetComponent<UITexture> ().mainTexture = gu;
		
						}
						else if (iseba) {
			
								this.GetComponent<UITexture> ().mainTexture = bass;
			
						}
						else if (isepi) {
			
								this.GetComponent<UITexture> ().mainTexture = piano;
			
						}
						else if (isesm) {
			
								this.GetComponent<UITexture> ().mainTexture = small;
			
						}
						
	
						if (isvison) {

								this.GetComponent<UITexture> ().color = new Color (255, 255, 255, 0.1f);
		
						}

						if(this.name=="wind")
			{

				this.GetComponent<UITexture> ().mainTexture = small;

			}


						if (this.transform.position.x < -35f) {
								emenyhit.encombo=0;
								emenyhit.encombodamage=1.0f;

								Destroy (this.gameObject);
						}


		}else if(this.transform.parent.gameObject ==GameObject.Find("me").gameObject){
			timer += Time.deltaTime;
			this.transform.localPosition = new Vector3 (now,0, -100);

			GameObject.Find("backgr").GetComponent<Animator>().SetBool("cibeat",false);
			if (scriptchange.guchange) {
				
				this.GetComponent<UITexture> ().mainTexture = gu;
				
				
			} else if (scriptchange.painochange) {
				
				this.GetComponent<UITexture> ().mainTexture = piano;
				
			} else if (scriptchange.posichange) {
				
				this.GetComponent<UITexture> ().mainTexture = posi;
				
			} else if (scriptchange.basschange) {
				
				this.GetComponent<UITexture> ().mainTexture = bass;
				
			} else if (scriptchange.smallchange) {
				
				this.GetComponent<UITexture> ().mainTexture = small;
				
			}  else {
				this.GetComponent<UITexture> ().mainTexture = pure;
				
			}

			if (this.transform.position.x< -35f) {
				
				
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
			
		}
	}

	
	
	
	
}


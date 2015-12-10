using UnityEngine;
using System.Collections;
//
public class bpm : MonoBehaviour {


	public static float time;
	public static float enetime;
	public static float tempobpm;
	public static float  enemybpm;
	public GameObject tempo;
	public GameObject enemytempo;
	public static bool test;
	public Texture2D two;
	public Texture2D one;
	public GameObject num;
	bool inin;
	bool countdown;
	// Use this for initialization
	void Start () {
		if (!test) {
						inin = false;
				} else if (test) {
			inin=true;
		
		}

		tempobpm =0.8f;
		pause.stop = true;

	}

	// Update is called once per frame


	public void DUCreat()
	{

	GameObject duu=	(GameObject)Instantiate (enemytempo);
		duu.GetComponent<newtempoeneny> ().isdu = true;

	}
	void Update () {

		time += Time.deltaTime;
		enetime += Time.deltaTime;

		if (!inin) {
				
		if(time>2)
			{
				GameObject.Find("countdown").GetComponent<UITexture>().mainTexture=one;


			}else if(time>=1)
			{

				GameObject.Find("countdown").GetComponent<UITexture>().mainTexture=two;

			}
		
		if(time>3)
			{
				inin=true;
				time=0;
				enetime=0;
				pause.stop=false; 
				GameObject.Find("Camera").GetComponent<AudioSource>().Play();
				Destroy(GameObject.Find("countdown").gameObject);


			}
		
		
		
		}








		if (inin) {	
						if (time >= tempobpm) {
			
								Instantiate (tempo);
								time = 0;
			
						}
						if (enetime >= enemybpm) {
				
								Instantiate (enemytempo);

								enetime = 0;
						}



				}


	}
}

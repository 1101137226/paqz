using UnityEngine;
using System.Collections;

public class pause : MonoBehaviour {
	public static bool stop;
	public AudioClip asd;
	float aaa;
	public bool now;
	public Texture2D mainL;
	public Texture2D main;
	public Texture2D resL;
	public Texture2D res;
	bool inin;
	public bool flag;

	// Use this for initialization
	void Start () {

		now = true;
		flag = false;
	}
	
	// Update is called once per frame
	void Update () {
	

		if (Input.GetKeyUp(KeyCode.Escape) & !inin) {
				
			flag=false;
			Time.timeScale=0;
			aaa=GameObject.Find("Camera").GetComponent<AudioSource>().time;
			GameObject.Find("Camera").GetComponent<AudioSource>().Pause();
			Debug.Log(aaa);
			stop=true;

			Instantiate(Resources.Load("stopback"));
			GameObject.Find("stopback(Clone)").transform.parent=GameObject.Find("UIRoot").transform;
			GameObject.Find("stopback(Clone)").transform.localPosition=new Vector3(-3413,86,0);

			inin=true;


		}
		if (inin) {
						if (now) {
				
								if (Input.GetKeyUp (KeyCode.DownArrow)) {

										GameObject.Find ("mainmemu").GetComponent<UITexture> ().mainTexture = mainL;
										GameObject.Find ("resume").GetComponent<UITexture> ().mainTexture = res;
										now = false;


								} else if (Input.GetKeyUp (KeyCode.Space) || flag) {
										Destroy (GameObject.Find ("stopback(Clone)").gameObject);	
										stop = false;
										GameObject.Find ("Camera").GetComponent<AudioSource> ().time = aaa;
				
										GameObject.Find ("Camera").GetComponent<AudioSource> ().Play ();
										Time.timeScale = 1;
										inin=false;
				
								}
		
						} else if (!now) {
			
								if (Input.GetKeyUp (KeyCode.UpArrow)) {
				
										GameObject.Find ("mainmemu").GetComponent<UITexture> ().mainTexture = main;
										GameObject.Find ("resume").GetComponent<UITexture> ().mainTexture = resL;
										now = true;
				
				
				} else if (Input.GetKeyUp (KeyCode.Space) ||flag) {
										Time.timeScale = 1;
										Application.LoadLevel ("mainmemu");
				
								}
			
						}

				}



	}
}

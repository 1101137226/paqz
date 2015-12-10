using UnityEngine;
using System.Collections;

public class dark : MonoBehaviour {
	byte nowcard;
	float effecttime;
	public float passtime;
	bool startfly=true;
	public Transform father;
	public static bool isaru=false;
	// Use this for initialization
	void Start () {

		isaru = false;
		nowcard = cardeffect.nowcard;
		cardeffect.nowcard = 0;
		this.GetComponent<UITexture> ().depth = 10;
		bool jk=GameObject.Find("UIRoot").GetComponent<bactrl>().jk;
		if (jk == false) {
				
						father = GameObject.Find ("UIRoot/elow").transform;
		
				} else if (jk == true) {
				
			father = GameObject.Find ("UIRoot/ehigh").transform;
		
		}

		this.transform.parent = father;
		this.transform.localPosition = new Vector3 (10,0, 0);
		if (nowcard == 51)
		{effecttime = 10f;} 
		else if (nowcard == 52) 
		{effecttime = 13f;}
		else if (nowcard == 53) 
		{effecttime = 15f;}

	}
	
	// Update is called once per frame
	void Update () {
		isaru = true;

		passtime += Time.deltaTime;

		if (startfly) 
		{

			this.transform.localPosition = new Vector3 (10-passtime*20f,0, 0);

			if(passtime*20f>10)
			{
				startfly=false;

			}
		
		}





		if (passtime > effecttime) {
			isaru=false;
			Destroy(this.gameObject);
		
		}
		
		
		
		
		
		
		}




	}


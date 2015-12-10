using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class NETJKctrl : NetworkBehaviour {

	[SyncVar]public byte team;
	[SyncVar]public string master;
	[SyncVar]public bool jk;
	[SyncVar(hook="flag")]public bool boomflag=false;
	GameObject target;
	bool inin;
	bool inin2;
	bool inin3;
	public float passtime;
	 

	// Use this for initialization
	void Start () {
	string  a=GameObject.Find("UIRoot").GetComponent<NETSAVE>().thisname;
		inin = false;
		inin2 = true;
		inin3 = true;
		if (a != master) {

			target=GameObject.Find(a).gameObject;

			inin=true;
			bool targetjk=target.GetComponent<NETBS>().jk;

			if(targetjk!=jk)
			{
				GameObject.Find(a).GetComponent<NETBS>().CmdJKctrlboom(this.gameObject);
				boomflag=true;
				CmdBoom();
			}

			target.GetComponent<NETBS>().JkCtrled(jk);
			target.GetComponent<NETBS>().isjk=true;


				}

		this.transform.parent = GameObject.Find ("other").transform;

	}
	[Command]
	void CmdBoom()
	{

		boomflag = true;
	}
	void flag(bool b)
	{

		boomflag = b;
	
	}

	void CreatBoom()
	{
	
		if (!jk) {
				
					GameObject	broken1 = (GameObject)Instantiate (Resources.Load ("Nethighpoint"));
						broken1.transform.parent = GameObject.Find ("UIRoot").transform;
						broken1.transform.localScale = new Vector3 (800, 800, 800);
						if (team == 1) {
								broken1.transform.localPosition = new Vector3 (-7684, 913, 0);

						} else if (team == 2) {
								broken1.transform.localPosition = new Vector3 (-7684, -718, 0);
						}
					broken1.GetComponent<Animator>().SetBool("boom",true);
			broken1.name="boom";
				} else if (jk) {
				
		GameObject	broken = (GameObject)Instantiate (Resources.Load ("Netlowpoint"));
			broken.transform.parent = GameObject.Find ("UIRoot").transform;
			broken.transform.localScale = new Vector3 (800, 800, 800);
			if (team == 1) {
				broken.transform.localPosition = new Vector3 (-10184, 913, 0);
				
			} else if (team == 2) {
				broken.transform.localPosition = new Vector3 (-10184, -718, 0);
			}
			broken.GetComponent<Animator>().SetBool("boom",true);
			broken.name="boom";
		}
		GameObject.Find("broken").GetComponent<AudioSource>().Play();

	}
	// Update is called once per frame
	void Update () {
		passtime += Time.deltaTime;
		this.name="JK";
	if (inin3 && passtime > 0.67f && boomflag) {
				
			Destroy(GameObject.Find("boom").gameObject);
			inin3=false;
		
		}

		if (passtime>=10f) {
				if(inin)
			{target.GetComponent<NETBS>().isjk=false;}


			Destroy(this.gameObject);
		
		
		}

		if (boomflag && inin2) {
				
			inin2=false;
			CreatBoom();
		}



	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class NETDC : NetworkBehaviour {
	[SyncVar]public byte num;
	[SyncVar]public byte team;
	[SyncVar]public string master;
	[SyncVar]public bool jk;
	public  float passtime;

	// Use this for initialization
	void Start () {

		this.transform.parent = GameObject.Find ("UIRoot").transform;
		this.transform.localScale = new Vector3 (1, 1, 1);
		float xx=0;
		float yy=0;

		if (team != 0) {
						if (team == 1) {
				

								yy = 913;
							
						} else if (team == 2) {
				

								yy = -718;
						}
						if (!jk) {
								xx = -10148;

			
						} else if (jk) {
			
								xx = -5148;
						}
				

						this.transform.localPosition = new Vector3 (xx, yy, 0);
				}
	}
	
	// Update is called once per frame
	void Update () {
	
		passtime += Time.deltaTime;

		switch (num)
		{
		case 0:
			Destroy(this.gameObject);
			break;
		
		case 51:
			if(passtime>10f)
				num=0;
			break;
		case 52:
			if(passtime>13f)
				num=0;
			break;
		case 53:
			if(passtime>15f)
				num=0;
			break;
			
		
		
		}


	}
}

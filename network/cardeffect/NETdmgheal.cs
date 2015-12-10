using UnityEngine;
using System.Collections;
public class NETdmgheal :MonoBehaviour {
	public byte num;
	public byte team;
	public string master;
	public  float passtime;
	GameObject target;
 	public	float nowhp;
	public	float targethp;
	bool inin=false;

	float hp;
	float dmg;
	
	// Use this for initialization
	void Start () {

	

		GameObject[] p=GameObject.FindGameObjectsWithTag("Who");
		if (p [0].name == master) {
				
		
						target = p [1].gameObject;
		
				} else if (p [1].name == master) {
				
			target = p [0].gameObject;
		
					}

		this.transform.parent = GameObject.Find ("other").transform;

	}

	// Update is called once per frame
	void Update () {
		passtime += Time.deltaTime;
		this.name="dmgheal";

				
			hp=target.GetComponent<NETstaus>().nowhp;
			dmg=nowhp-hp;

		switch (num) {
				
		case 0:
			Destroy(this.gameObject);
			break;

		case 67:

			if(dmg>=targethp)
			{
				GameObject.Find(master).GetComponent<NETBS>().heald(dmg);

			//	CmdGO(dmg);


			}
			nowhp=hp;
			if(passtime>10f)
			{
				num=0;
			}
			break;
		case 68:

			if(dmg>=targethp)
			{
				GameObject.Find(master).GetComponent<NETBS>().heald(dmg*0.5f);
				dmg=0;

			}
			nowhp=hp;
			if(passtime>15f)
			{
				num=0;
			}
			break;
		case 69:

			if(dmg>=targethp)
			{
				GameObject.Find(master).GetComponent<NETBS>().heald(dmg*0.25f);

			}
			nowhp=hp;
			if(passtime>20f)
			{
				num=0;
			}
			break;
		
		
		
		
		}



	
	}
}

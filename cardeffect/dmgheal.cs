using UnityEngine;
using System.Collections;

public class dmgheal : MonoBehaviour {
	public byte num;
	public byte team;
	public  float passtime;
	GameObject target;
	public	float nowhp;
	public	float targethp;
	bool inin=false;
	
	float hp;
	public static float dmg;

	// Use this for initialization
	void Start () {
		dmg = 0;
	}
	
	// Update is called once per frame
	void Update () {

		passtime += Time.deltaTime;
		this.name="dmgheal";
		
		

		
		switch (num) {
			
		case 0:
			Destroy(this.gameObject);
			break;
			
		case 67:
			if(dmg>charstuas.maxhp*0.1f)
			{

				charstuas.nowhp+=dmg;
				dmg=0;
			}
			if(passtime>10f)
			{
				num=0;
			}
			break;
		case 68:
			if(dmg>charstuas.maxhp*0.1f)
			{
				
				charstuas.nowhp+=dmg;
				dmg=0;
			}

			if(passtime>15f)
			{
				num=0;
			}
			break;
		case 69:
			if(dmg>charstuas.maxhp*0.1f)
			{
				
				charstuas.nowhp+=dmg;
				dmg=0;
			}

			if(passtime>20f)
			{
				num=0;
			}
			break;
			
			
			
			
		}
	
	}
}

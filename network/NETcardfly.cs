using UnityEngine;
using System.Collections;

public class NETcardfly : MonoBehaviour {
	public  bool fly=false;
	public bool flydown=false;
	public byte who;
	int thisx;
	float timee=0f;

	void Start () {

	}

	void Update () {


		thisx = -6600 + who * 1800;
		
		if (fly) {
			timee += Time.deltaTime;
			if (timee * 3500 < 1000) {
				
				this.transform.localPosition = new Vector3 (thisx,-4000+timee*3500, 0);
				
			}
			else
			{
				
				this.transform.localPosition = new Vector3 (thisx,-2800, 0);
				fly=false;
			}
			
		}
		
		if (flydown) {
			
			
			timee += Time.deltaTime;
			if (timee * 3500 < 1000) {
				
				this.transform.localPosition = new Vector3 (thisx,4400-timee*3500, 0);
				
			}
			else
			{
				
				this.transform.localPosition = new Vector3 (thisx,3200, 0);
				flydown=false;
			}
											
		}

	
	}
}

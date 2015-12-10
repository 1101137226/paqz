using UnityEngine;
using System.Collections;

public class NETGOUPDOWN : MonoBehaviour {

	GameObject up;
	GameObject down;
	// Use this for initialization
	void Start () {
		up = GameObject.Find ("maindeck").gameObject;
		down = GameObject.Find ("subdeck").gameObject;

	}
	
	public void OnPress(bool ispress){
		

		if (ispress) {
			
			if(this.transform.parent.name=="maindeck")
			{


				this.transform.parent=down.transform;
				down.GetComponent<UIGrid>().repositionNow=true;

			}else if(this.transform.parent.name=="subdeck")
			{
				
				
				this.transform.parent=up.transform;
				up.GetComponent<UIGrid>().repositionNow=true;
				
			}
			
		}
		
		
	}
}

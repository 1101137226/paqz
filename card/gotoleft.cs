using UnityEngine;
using System.Collections;

public class gotoleft : MonoBehaviour {

	public void OnPress(bool ispress){

		UIGrid aaa;
		aaa = this.transform.parent.GetComponent<UIGrid>();
		if (ispress) {
			


			string nowname=GameObject.Find(this.transform.name).GetComponent<UI2DSprite>().sprite2D.name;
	


			GameObject.Destroy(this.gameObject);
			GameObject.Destroy(GameObject.Find("big"+nowname));
			aaa.repositionNow=true;
			
		}
		
		
	}
}

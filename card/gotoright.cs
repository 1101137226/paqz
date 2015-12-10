using UnityEngine;
using System.Collections;

public class gotoright : MonoBehaviour {

	public GameObject M;
	public GameObject S;
	UIGrid aaa;
	UI2DSprite SSS;


	public void OnPress(bool ispress){
		if (ispress) {
						int aa = 0;
						M = GameObject.Find ("carddec").gameObject;
						S = GameObject.Find ("subdec").gameObject;
						int a = M.transform.childCount;
						int b = S.transform.childCount;

					

						
		for (int i=a-1; i>=0; i--) {
				Debug.Log(i);
			string abc =M.transform.GetChild (i).GetComponent<UI2DSprite> ().sprite2D.name;
			if(abc==this.GetComponent<UI2DSprite>().sprite2D.name)
			{aa++;}
					
		}

		for (int i=b-1; i>=0; i--) {
			
			string abc =S.transform.GetChild (i).GetComponent<UI2DSprite> ().sprite2D.name;
			if(abc==this.GetComponent<UI2DSprite>().sprite2D.name)
			{aa++;}
			
		}

						if (aa < 3) {
								bool flag = true;
								if (!MainSubSwich.who) {
										aaa = GameObject.Find ("carddec").GetComponent<UIGrid> ();
										if (a >= 30) {
												flag = false;
										}
								} else if (MainSubSwich.who) {
										aaa = GameObject.Find ("subdec").GetComponent<UIGrid> ();
										if (b >= 20) {
												flag = false;
										}
								}
								if (flag) {
							
										DECKDISPLAY.poi++;
										string nownum;
										nownum = this.transform.name.Remove (0, 4);

										Instantiate (Resources.Load ("PIC/PIC_0" + nownum));


		
										GameObject.Find ("PIC_0" + nownum + "(Clone)").name = System.Convert.ToString (DECKDISPLAY.poi + "poi");
										GameObject.Find (System.Convert.ToString (DECKDISPLAY.poi + "poi")).transform.localScale = new Vector3 (0, 0, 0);
										GameObject.Find (System.Convert.ToString (DECKDISPLAY.poi + "poi")).transform.parent = aaa.transform;
										GameObject.Find (System.Convert.ToString (DECKDISPLAY.poi + "poi")).transform.localPosition = new Vector3 (0, 0, 0);
										GameObject.Find (System.Convert.ToString (DECKDISPLAY.poi + "poi")).transform.localScale = new Vector3 (1, 1, 1);
			
										aaa.repositionNow = true;
										//  Get sprite name from 
										//	Debug.Log(GameObject.Find("5").GetComponent<UI2DSprite>().sprite2D.name);
			



								}
						}
				}
}
}
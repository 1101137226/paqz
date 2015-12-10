using UnityEngine;
using System.Collections;

public class savedeck : MonoBehaviour {

	//PlayerPrefs.SetInt ("1_Get", 1);
	//"00" + j + "_amount"
	public GameObject aaa;
	public GameObject bbb;
	byte flag;
	public void Srart(){
		
		
		flag = 0;
		
		
	}

	public void OnPress(bool ispress){
		if (flag == 0) {
		
		for (int i=1; i<=80; i++) 
		{
				
			PlayerPrefs.SetInt(System.Convert.ToString(i)+"_amount",0);
				PlayerPrefs.SetInt(System.Convert.ToString(i)+"_SubAmount",0);
		}

		int a=aaa.transform.childCount;
		int b=bbb.transform.childCount;



						for (int i=a-1; i>=0; i--) {

				//	PlayerPrefs.SetInt ("001_amount", 3);
								//Debug.Log (aaa.transform.GetChild (i).GetComponent<UI2DSprite> ().sprite2D.name);
								string abc =aaa.transform.GetChild (i).GetComponent<UI2DSprite> ().sprite2D.name;
								int amountt=PlayerPrefs.GetInt(abc+"_amount")+1;
							
							PlayerPrefs.SetInt(abc+"_amount",amountt);

			
						}
			for (int i=b-1; i>=0; i--) {

				//	PlayerPrefs.SetInt ("001_amount", 3);
				//Debug.Log (aaa.transform.GetChild (i).GetComponent<UI2DSprite> ().sprite2D.name);
				string abc =bbb.transform.GetChild (i).GetComponent<UI2DSprite> ().sprite2D.name;
				int amountt=PlayerPrefs.GetInt(abc+"_SubAmount")+1;
				
				PlayerPrefs.SetInt(abc+"_SubAmount",amountt);

				
			}


				}

			
		}
		
		

}

using UnityEngine;
using System.Collections;

public class clearcard : MonoBehaviour {

	public GameObject aaa;

	public void OnPress(bool ispress){
		

		
		if (ispress) {
			
			
			int a=aaa.transform.childCount;

			for(int i=a-1;i>=0;i--)
			{

				Destroy(aaa.transform.GetChild(i).gameObject);

			}
			
			
			
			
		}
		
		
	}
}

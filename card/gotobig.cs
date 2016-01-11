using UnityEngine;
using System.Collections;

public class gotobig : MonoBehaviour {

	bool flag=true;


	public static string cardidd;
	void OnHover( bool isOver )
	{
		if (isOver) {
			
			if(flag)
			{
				string nowname=GameObject.Find(this.transform.name).GetComponent<UI2DSprite>().sprite2D.name;
				cardidd=nowname;
				Vector3 pppp =new Vector3(100000,1000000,-2);
				Instantiate(Resources.Load("BIG/bigSEA_"+nowname),pppp,Quaternion.identity);flag=false;
				GameObject.Find("bigSEA_"+nowname+"(Clone)").transform.parent=GameObject.Find("downbig").transform;
				GameObject.Find ("bigSEA_"+nowname+"(Clone)").transform.name="big"+nowname;
				

				GameObject.Find("big"+nowname).transform.localPosition= new Vector3(0,0,0);
				GameObject.Find("big"+nowname).transform.localScale=new Vector3(1,1,1);







			}
			
		} 
		else
		{				
			
			string nowname=GameObject.Find(this.transform.name).GetComponent<UI2DSprite>().sprite2D.name;
			GameObject.Destroy(GameObject.Find("big"+nowname));
			flag=true;
			
		}
		
		
		
		
		
	}







}

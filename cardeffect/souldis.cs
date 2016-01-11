using UnityEngine;
using System.Collections;

public class souldis :MonoBehaviour {
	public GameObject aaaa;
	public bool poipoi=false;


	void Start () {
	
	}
	
	void Update () {

		if(poipoi) {
			soul.num++;
						Instantiate (Resources.Load("LS"));
			GameObject.Find("LS(Clone)").name=System.Convert.ToInt16(soul.num)+"poi";
			GameObject.Find(System.Convert.ToInt16(soul.num)+"poi").transform.parent=this.transform;		
			GameObject.Find(System.Convert.ToInt16(soul.num)+"poi").transform.localPosition=new Vector3(18,0,0);
		}

	 
	}
}

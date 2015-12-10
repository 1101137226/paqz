using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class NETtodoke : NetworkBehaviour {
	[SyncVar]public byte team;
	[SyncVar]public bool jk;
	bool inin;
	string target;
	float time;
	// Use this for initialization
	void Start () {

		if (team == 1) {

			target = "P2";
				} else if (team == 2) {
			target="P1";
				}
	
		GameObject.Find("todoke").GetComponent<AudioSource>().Play();
		if(!jk){
			GameObject.Find("backgr").GetComponent<Animator>().SetBool("cibeat",true);
			GameObject.Find("backgr").GetComponent<Animator>().SetBool("cibeatback",true);
			foreach(GameObject fooObj in GameObject.FindGameObjectsWithTag(target))
			{


				if(team==1)
				{
				if(fooObj.name=="NETnoeff(Clone)")
				{
					fooObj.GetComponent<NETnewtempo>().give=true;
				}
					if(fooObj.name=="NETnoeffP2(Clone)")
				{
					fooObj.GetComponent<NETnewtempoP2>().give=true;
				}
				}else if(team==2)
				{
					if(fooObj.name=="NETnoeff(Clone)")
				{
					fooObj.GetComponent<NETnewtempo>().todoke=true;
				}
					else if(fooObj.name=="NETnoeffP2(Clone)")
				{
					fooObj.GetComponent<NETnewtempoP2>().todoke=true;
				}
				}




			}
			
		}else if(jk)
		{
			if(team==1)
			{Instantiate(Resources.Load("flyboommany"),new Vector3(0,-0.8f,0),Quaternion.identity);}
			else if(team==2)
			{Instantiate(Resources.Load("flyboommany"),new Vector3(0,0.8f,0),Quaternion.identity);}
			GameObject.Find("give").GetComponent<AudioSource>().Play();
			foreach(GameObject fooObj in GameObject.FindGameObjectsWithTag("P"+team.ToString()))
			{
				if(team==1)
				{
					if(fooObj.name=="NETnoeff(Clone)")
					{
						fooObj.GetComponent<NETnewtempo>().todoke=true;
					}
					if(fooObj.name=="NETnoeffP2(Clone)")
					{
						fooObj.GetComponent<NETnewtempoP2>().todoke=true;
					}
				}else if(team==2)
				{
					if(fooObj.name=="NETnoeff(Clone)")
					{
						fooObj.GetComponent<NETnewtempo>().give=true;
					}
					else if(fooObj.name=="NETnoeffP2(Clone)")
					{
						fooObj.GetComponent<NETnewtempoP2>().give=true;
					}
				}
			}
			
			
		}


		inin = true;
	}
	
	// Update is called once per frame
	void Update () {
	
		time += Time.deltaTime;
		if(time>0.5f && inin)
		{
		if (!jk) {
				
			GameObject.Find("backgr").GetComponent<Animator>().SetBool("cibeat",false);
		
		}else if (jk) {
				
		
				Destroy(GameObject.Find("flyboommany(Clone)").gameObject);
		
		}

			inin=false;
		}


		if (time > 1f) {
			Destroy(this.gameObject);
		
		
		}

	}
}

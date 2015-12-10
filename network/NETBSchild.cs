using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class NETBSchild : NetworkBehaviour{

	float time;
	bool down;
	byte team;
	// Use this for initialization
	void Start () {
		team = this.transform.parent.GetComponent<NETBS> ().team;

	
	}
	void OnTriggerStay2D(Collider2D bbb)
	{



			
		if (bbb.transform.parent.tag == "P" + System.Convert.ToString (team)) {
				
						if (bbb.gameObject.tag == "duo") {
			
								if (Input.GetKey (KeyCode.J) && down) {
										down = false;
										if (!this.transform.parent.GetComponent<NETBS> ().jk) {
												//Instantiate(skull);
												string a22 = bbb.GetComponent<UITexture> ().mainTexture.name;
												//	damage33(a22);
												CmdDie (bbb.gameObject);
										} else if (this.transform.parent.GetComponent<NETBS> ().jk) {
					
					
												//	Instantiate(mm);
					
												CmdDie (bbb.gameObject);
					
										}
				
				
										down = true;
				
				
				
								}
						} else if (bbb.gameObject.tag == "P1" || bbb.gameObject.tag == "P2") {
			
			
								if (Input.GetKey (KeyCode.J) && down) {
				
										down = false;
										if (!this.transform.parent.GetComponent<NETBS> ().jk) {
					
					
												string a22 = bbb.GetComponent<UITexture> ().mainTexture.name;
					
					
												if (this.name == "front") {
						
														//		damage.hitpois=0.7f;
														this.transform.parent.GetComponent<NETBS> ().combo++;
														this.transform.parent.GetComponent<NETBS> ().drawcombo++;
							Debug.Log(this.transform.parent.GetComponent<NETBS> ().combo);
														if (this.transform.parent.GetComponent<NETBS> ().combo >= 3) {
																//		damage.combodamage+=0.02f;
							
														}
						
												} else if (this.name == "real") {
														//		damage.hitpois=0.8f;
														this.transform.parent.GetComponent<NETBS> ().combo++;
														this.transform.parent.GetComponent<NETBS> ().drawcombo++;
														if (this.transform.parent.GetComponent<NETBS> ().combo >= 3) {
																//		damage.combodamage+=0.02f;
							
														}
						
												}
												//	damage33(a22);
												//	Instantiate(mm);
												//			CmdCreatmm();
					

												CmdDie (bbb.gameObject);
												//	bbb.GetComponent<NETnewtempo>().die=true;
										} else if (this.transform.parent.GetComponent<NETBS> ().jk) {
												//	Instantiate(mm);
					
												string a22 = bbb.GetComponent<UITexture> ().mainTexture.name;
					
												if (this.name == "front") {
						
														//				damage.hitpois=0.7f;
														this.transform.parent.GetComponent<NETBS> ().combo++;
														this.transform.parent.GetComponent<NETBS> ().drawcombo++;
														if (this.transform.parent.GetComponent<NETBS> ().combo >= 3) {
																//		damage.combodamage+=0.02f;
							
														}
												} else if (this.name == "real") {
														//			damage.hitpois=0.8f;
														this.transform.parent.GetComponent<NETBS> ().combo++;
														this.transform.parent.GetComponent<NETBS> ().drawcombo++;
														if (this.transform.parent.GetComponent<NETBS> ().combo >= 3) {
																//		damage.combodamage+=0.02f;
							
														}
												}
					
												//			damage22(a22);
					
												//		CmdCreatmm();
												//		Instantiate(mm);

												CmdDie (bbb.gameObject);
												//	bbb.GetComponent<NETnewtempo>().die=true;
										}
				
				
				
				
								}
			
			
			
			
						}
		
				}
		
		
		
		
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.J)) {
			
			time+=Time.deltaTime;
			
			if(time>0.1f)
			{
				
				down=false;
				
			}
			
		}
		if(Input.GetKeyUp(KeyCode.J))
		{
			time=0f;
			down=true;
		}
	}
	[Command]
	void CmdDie(GameObject bbb)
	{
		
		
		Destroy (bbb.gameObject);
		NetworkServer.Destroy (bbb.gameObject);
		
	}

}

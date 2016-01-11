using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class NETBSchild : NetworkBehaviour
{

	float time;
	bool down;
	byte team;

	void Start ()
	{
		team = this.transform.parent.GetComponent<NETBS> ().team;

	
	}

	void OnTriggerStay2D (Collider2D bbb)
	{



			
		if (bbb.transform.parent.tag == "P" + System.Convert.ToString (team)) {
				
			if (bbb.gameObject.tag == "duo") {
			
				if (Input.GetKey (KeyCode.J) && down) {
					down = false;
					if (!this.transform.parent.GetComponent<NETBS> ().jk) {
												
						string a22 = bbb.GetComponent<UITexture> ().mainTexture.name;
												
						CmdDie (bbb.gameObject);
					} else if (this.transform.parent.GetComponent<NETBS> ().jk) {																				
					
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
							this.transform.parent.GetComponent<NETBS> ().combo++;
							this.transform.parent.GetComponent<NETBS> ().drawcombo++;
							if (this.transform.parent.GetComponent<NETBS> ().combo >= 3) {																
							
							}
						
						} else if (this.name == "real") {														
							this.transform.parent.GetComponent<NETBS> ().combo++;
							this.transform.parent.GetComponent<NETBS> ().drawcombo++;
							if (this.transform.parent.GetComponent<NETBS> ().combo >= 3) {																
							
							}
						
						}												
					
						CmdDie (bbb.gameObject);												
					} else if (this.transform.parent.GetComponent<NETBS> ().jk) {												
					
						string a22 = bbb.GetComponent<UITexture> ().mainTexture.name;
					
						if (this.name == "front") {																			
							this.transform.parent.GetComponent<NETBS> ().combo++;
							this.transform.parent.GetComponent<NETBS> ().drawcombo++;
							if (this.transform.parent.GetComponent<NETBS> ().combo >= 3) {																
							
							}
						} else if (this.name == "real") {														
							this.transform.parent.GetComponent<NETBS> ().combo++;
							this.transform.parent.GetComponent<NETBS> ().drawcombo++;
							if (this.transform.parent.GetComponent<NETBS> ().combo >= 3) {																
							
							}
						}																
						CmdDie (bbb.gameObject);												
					}													
				}								
			}		
		}
		
		
		
		
	}

	void Update ()
	{
		if (Input.GetKey (KeyCode.J)) {
			
			time += Time.deltaTime;
			
			if (time > 0.1f) {
				
				down = false;
				
			}
			
		}
		if (Input.GetKeyUp (KeyCode.J)) {
			time = 0f;
			down = true;
		}
	}

	[Command]
	void CmdDie (GameObject bbb)
	{
		
		
		Destroy (bbb.gameObject);
		NetworkServer.Destroy (bbb.gameObject);
		
	}

}

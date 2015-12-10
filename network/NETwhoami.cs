using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class NETwhoami : NetworkBehaviour{
	public static byte ourID;
	// Use this for initialization
	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {
		if (!isLocalPlayer)
						return;







	}
}

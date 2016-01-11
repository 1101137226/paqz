using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class NETwhoami : NetworkBehaviour
{
	public static byte ourID;

	void Start ()
	{
	


	}

	void Update ()
	{
		if (!isLocalPlayer)
			return;
	}
}

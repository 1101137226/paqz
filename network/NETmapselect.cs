using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class NETmapselect : NetworkBehaviour{
	[SyncVar(hook="MAP")]public byte mapnum;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this.gameObject);
		Random.seed = System.Guid.NewGuid().GetHashCode();
		int o=Random.Range(0,10);
		mapnum=System.Convert.ToByte (o);
	}
	void MAP(byte num)
	{

		if (num == 0) {
			Random.seed = System.Guid.NewGuid().GetHashCode();
			int o=Random.Range(0,10);
		
		
			num= System.Convert.ToByte (o);
		}

		mapnum = num;
	
	}
	// Update is called once per frame
	void Update () {
	
	}
}

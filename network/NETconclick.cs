using UnityEngine;
using System.Collections;

public class NETconclick : MonoBehaviour
{
	public string master;
	public bool e;
	UILabel o;

	void Start ()
	{
		master = GameObject.Find ("UIRoot").GetComponent<NETSAVE> ().thisname;
		o = this.transform.GetChild (0).GetComponent<UILabel> ();
		o.depth = 55;
	}

	public void OnPress (bool ispress)
	{
		
		if (ispress) {
			GameObject.Find (master).GetComponent<NETstaus> ().CmdSet ();

			if (!e) {

				o.text = "Ready";
				e = true;
			} else if (e) {

				e = false;
				o.text = "Click to Ready";
		
			}
		
		}	

	}
}

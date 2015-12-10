using UnityEngine;
using System.Collections;

public class attackeffctrl : MonoBehaviour {
	public Sprite father;
	float time;
	// Use this for initialization
	void Start () {

		if (this.tag == "Player") {
						this.transform.parent = GameObject.Find ("enba").gameObject.transform;
				} else if (this.tag == "eny") {
				
			this.transform.parent = GameObject.Find ("barrier").gameObject.transform;
		
		}
		Random.seed = System.Guid.NewGuid().GetHashCode();
		 float o= Random.Range(-1.0f, 3.0f);
		float p= Random.Range(-1.0f, 3.0f);

		this.transform.localPosition = new Vector3 (0 + o, 0 + p, 0);

	
	}
	
	// Update is called once per frame
	void Update () {

		time += Time.deltaTime;
		if (time > 0.2f) {
				
			Destroy(this.gameObject);
		}

	
	}
}

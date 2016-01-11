using UnityEngine;
using System.Collections;

public class bossfirstattack : MonoBehaviour
{
	public float first;
	public GameObject bossskill;
	public Texture2D yesmusic;
	public GameObject speedgogo;
	bool inin;

	void Start ()
	{
		inin = true;
	}

	void Update ()
	{

		if (!pause.stop) {
			first += Time.deltaTime;
			if (inin) {
				inin = false;
				Instantiate (bossskill);

				GameObject.Find ("bossskill(Clone)").GetComponent<UITexture> ().mainTexture = yesmusic;
				GameObject.Find ("accelSE").GetComponent<AudioSource> ().Play ();
			}
			newtempo.eaccel = 2.0f;

			if (first >= 20.0f) {

				newtempo.eaccel = 1.0f;
				Destroy (this.gameObject);
			}
		}
	}
}

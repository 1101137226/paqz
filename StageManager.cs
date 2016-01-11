using UnityEngine;
using System.Collections;

public class StageManager : MonoBehaviour
{
	public Texture2D[] stage = new Texture2D[0];
	public Sprite play;
	public Sprite play_L;
	public Sprite next;
	public Sprite next_L;
	public Sprite back;
	public Sprite back_L;
	public Sprite previous;
	public Sprite previous_L;
	public byte where;
		

	void Start ()
	{
		GameObject selected = GameObject.Find ("Selected Stage");
		GameObject next = GameObject.Find ("Next Stage");
		GameObject previous = GameObject.Find ("Previous Stage");
		selected.GetComponent<UITexture> ().mainTexture = stage [0];
		next.GetComponent<UITexture> ().mainTexture = stage [1];
		previous.GetComponent<UITexture> ().mainTexture = stage [stage.Length - 1];
		where = 0;
	}
	

	void Update ()
	{
		switch (where) {
		case 0:
			if (Input.GetKeyUp (KeyCode.UpArrow)) {
				GameObject.Find ("Play").GetComponent<UI2DSprite> ().sprite2D = play_L;
				GameObject.Find ("Next").GetComponent<UI2DSprite> ().sprite2D = next;
				GameObject.Find ("Back").GetComponent<UI2DSprite> ().sprite2D = back;
				GameObject.Find ("Previous").GetComponent<UI2DSprite> ().sprite2D = previous;
				where = 1;
			}
			if (Input.GetKeyUp (KeyCode.RightArrow)) {
				GameObject.Find ("Play").GetComponent<UI2DSprite> ().sprite2D = play;
				GameObject.Find ("Next").GetComponent<UI2DSprite> ().sprite2D = next_L;
				GameObject.Find ("Back").GetComponent<UI2DSprite> ().sprite2D = back;
				GameObject.Find ("Previous").GetComponent<UI2DSprite> ().sprite2D = previous;
				where = 2;
			}
			if (Input.GetKeyUp (KeyCode.DownArrow)) {
				GameObject.Find ("Play").GetComponent<UI2DSprite> ().sprite2D = play;
				GameObject.Find ("Next").GetComponent<UI2DSprite> ().sprite2D = next;
				GameObject.Find ("Back").GetComponent<UI2DSprite> ().sprite2D = back_L;
				GameObject.Find ("Previous").GetComponent<UI2DSprite> ().sprite2D = previous;
				where = 3;
			}
			if (Input.GetKeyUp (KeyCode.LeftArrow)) {
				GameObject.Find ("Play").GetComponent<UI2DSprite> ().sprite2D = play;
				GameObject.Find ("Next").GetComponent<UI2DSprite> ().sprite2D = next;
				GameObject.Find ("Back").GetComponent<UI2DSprite> ().sprite2D = back;
				GameObject.Find ("Previous").GetComponent<UI2DSprite> ().sprite2D = previous_L;
				where = 4;
			}
			break;
		case 1:
			if (Input.GetKeyUp (KeyCode.RightArrow)) {
				GameObject.Find ("Play").GetComponent<UI2DSprite> ().sprite2D = play;
				GameObject.Find ("Next").GetComponent<UI2DSprite> ().sprite2D = next_L;
				GameObject.Find ("Back").GetComponent<UI2DSprite> ().sprite2D = back;
				GameObject.Find ("Previous").GetComponent<UI2DSprite> ().sprite2D = previous;
				where = 2;
			}
			if (Input.GetKeyUp (KeyCode.DownArrow)) {
				GameObject.Find ("Play").GetComponent<UI2DSprite> ().sprite2D = play;
				GameObject.Find ("Next").GetComponent<UI2DSprite> ().sprite2D = next;
				GameObject.Find ("Back").GetComponent<UI2DSprite> ().sprite2D = back_L;
				GameObject.Find ("Previous").GetComponent<UI2DSprite> ().sprite2D = previous;
				where = 3;
			}
			if (Input.GetKeyUp (KeyCode.LeftArrow)) {
				GameObject.Find ("Play").GetComponent<UI2DSprite> ().sprite2D = play;
				GameObject.Find ("Next").GetComponent<UI2DSprite> ().sprite2D = next;
				GameObject.Find ("Back").GetComponent<UI2DSprite> ().sprite2D = back;
				GameObject.Find ("Previous").GetComponent<UI2DSprite> ().sprite2D = previous_L;
				where = 4;
			}
			break;
		case 2:
			if (Input.GetKeyUp (KeyCode.UpArrow)) {
				GameObject.Find ("Play").GetComponent<UI2DSprite> ().sprite2D = play_L;
				GameObject.Find ("Next").GetComponent<UI2DSprite> ().sprite2D = next;
				GameObject.Find ("Back").GetComponent<UI2DSprite> ().sprite2D = back;
				GameObject.Find ("Previous").GetComponent<UI2DSprite> ().sprite2D = previous;
				where = 1;
			}
			if (Input.GetKeyUp (KeyCode.DownArrow)) {
				GameObject.Find ("Play").GetComponent<UI2DSprite> ().sprite2D = play;
				GameObject.Find ("Next").GetComponent<UI2DSprite> ().sprite2D = next;
				GameObject.Find ("Back").GetComponent<UI2DSprite> ().sprite2D = back_L;
				GameObject.Find ("Previous").GetComponent<UI2DSprite> ().sprite2D = previous;
				where = 3;
			}
			if (Input.GetKeyUp (KeyCode.LeftArrow)) {
				GameObject.Find ("Play").GetComponent<UI2DSprite> ().sprite2D = play;
				GameObject.Find ("Next").GetComponent<UI2DSprite> ().sprite2D = next;
				GameObject.Find ("Back").GetComponent<UI2DSprite> ().sprite2D = back;
				GameObject.Find ("Previous").GetComponent<UI2DSprite> ().sprite2D = previous_L;
				where = 4;
			}
			break;
		case 3:
			if (Input.GetKeyUp (KeyCode.UpArrow)) {
				GameObject.Find ("Play").GetComponent<UI2DSprite> ().sprite2D = play_L;
				GameObject.Find ("Next").GetComponent<UI2DSprite> ().sprite2D = next;
				GameObject.Find ("Back").GetComponent<UI2DSprite> ().sprite2D = back;
				GameObject.Find ("Previous").GetComponent<UI2DSprite> ().sprite2D = previous;
				where = 1;
			}
			if (Input.GetKeyUp (KeyCode.RightArrow)) {
				GameObject.Find ("Play").GetComponent<UI2DSprite> ().sprite2D = play;
				GameObject.Find ("Next").GetComponent<UI2DSprite> ().sprite2D = next_L;
				GameObject.Find ("Back").GetComponent<UI2DSprite> ().sprite2D = back;
				GameObject.Find ("Previous").GetComponent<UI2DSprite> ().sprite2D = previous;
				where = 2;
			}
			if (Input.GetKeyUp (KeyCode.LeftArrow)) {
				GameObject.Find ("Play").GetComponent<UI2DSprite> ().sprite2D = play;
				GameObject.Find ("Next").GetComponent<UI2DSprite> ().sprite2D = next;
				GameObject.Find ("Back").GetComponent<UI2DSprite> ().sprite2D = back;
				GameObject.Find ("Previous").GetComponent<UI2DSprite> ().sprite2D = previous_L;
				where = 4;
			}
			break;
		case 4:
			if (Input.GetKeyUp (KeyCode.UpArrow)) {
				GameObject.Find ("Play").GetComponent<UI2DSprite> ().sprite2D = play_L;
				GameObject.Find ("Next").GetComponent<UI2DSprite> ().sprite2D = next;
				GameObject.Find ("Back").GetComponent<UI2DSprite> ().sprite2D = back;
				GameObject.Find ("Previous").GetComponent<UI2DSprite> ().sprite2D = previous;
				where = 1;
			}
			if (Input.GetKeyUp (KeyCode.RightArrow)) {
				GameObject.Find ("Play").GetComponent<UI2DSprite> ().sprite2D = play;
				GameObject.Find ("Next").GetComponent<UI2DSprite> ().sprite2D = next_L;
				GameObject.Find ("Back").GetComponent<UI2DSprite> ().sprite2D = back;
				GameObject.Find ("Previous").GetComponent<UI2DSprite> ().sprite2D = previous;
				where = 2;
				
			}
			if (Input.GetKeyUp (KeyCode.DownArrow)) {
				GameObject.Find ("Play").GetComponent<UI2DSprite> ().sprite2D = play;
				GameObject.Find ("Next").GetComponent<UI2DSprite> ().sprite2D = next;
				GameObject.Find ("Back").GetComponent<UI2DSprite> ().sprite2D = back_L;
				GameObject.Find ("Previous").GetComponent<UI2DSprite> ().sprite2D = previous;
				where = 3;
			}
			break;
		}
	}
}


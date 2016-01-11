using UnityEngine;
using System.Collections;

public class StageHover : MonoBehaviour
{
	public byte here;
		

	void Start ()
	{
			
	}

	void OnHover (bool isOver)
	{
		Sprite play = GameObject.Find ("Stage").GetComponent<StageManager> ().play;
		Sprite play_L = GameObject.Find ("Stage").GetComponent<StageManager> ().play_L;
		Sprite next = GameObject.Find ("Stage").GetComponent<StageManager> ().next;
		Sprite next_L = GameObject.Find ("Stage").GetComponent<StageManager> ().next_L;
		Sprite back = GameObject.Find ("Stage").GetComponent<StageManager> ().back;
		Sprite back_L = GameObject.Find ("Stage").GetComponent<StageManager> ().back_L;
		Sprite previous = GameObject.Find ("Stage").GetComponent<StageManager> ().previous;
		Sprite previous_L = GameObject.Find ("Stage").GetComponent<StageManager> ().previous_L;
				
		if (isOver) {
			switch (here) {
			case 1:
				GameObject.Find ("Play").GetComponent<UI2DSprite> ().sprite2D = play_L;
				GameObject.Find ("Next").GetComponent<UI2DSprite> ().sprite2D = next;
				GameObject.Find ("Back").GetComponent<UI2DSprite> ().sprite2D = back;
				GameObject.Find ("Previous").GetComponent<UI2DSprite> ().sprite2D = previous;
				break;
			case 2:
				GameObject.Find ("Play").GetComponent<UI2DSprite> ().sprite2D = play;
				GameObject.Find ("Next").GetComponent<UI2DSprite> ().sprite2D = next_L;
				GameObject.Find ("Back").GetComponent<UI2DSprite> ().sprite2D = back;
				GameObject.Find ("Previous").GetComponent<UI2DSprite> ().sprite2D = previous;
				break;
			case 3:
				GameObject.Find ("Play").GetComponent<UI2DSprite> ().sprite2D = play;
				GameObject.Find ("Next").GetComponent<UI2DSprite> ().sprite2D = next;
				GameObject.Find ("Back").GetComponent<UI2DSprite> ().sprite2D = back_L;
				GameObject.Find ("Previous").GetComponent<UI2DSprite> ().sprite2D = previous;
				break;
			case 4:
				GameObject.Find ("Play").GetComponent<UI2DSprite> ().sprite2D = play;
				GameObject.Find ("Next").GetComponent<UI2DSprite> ().sprite2D = next;
				GameObject.Find ("Back").GetComponent<UI2DSprite> ().sprite2D = back;
				GameObject.Find ("Previous").GetComponent<UI2DSprite> ().sprite2D = previous_L;
				break;
			}

		}
	}


	void Update ()
	{
			
	}
}


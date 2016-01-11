using UnityEngine;
using System.Collections;

public class VSStageHover : MonoBehaviour
{
	public byte here;
		
	void Start ()
	{
			
	}

	void OnHover (bool isOver)
	{

		Sprite next = GameObject.Find ("Stage").GetComponent<VSStageManager> ().next;
		Sprite next_L = GameObject.Find ("Stage").GetComponent<VSStageManager> ().next_L;

		Sprite previous = GameObject.Find ("Stage").GetComponent<VSStageManager> ().previous;
		Sprite previous_L = GameObject.Find ("Stage").GetComponent<VSStageManager> ().previous_L;
				
		if (isOver) {
			switch (here) {
			case 1:
								
				GameObject.Find ("Next").GetComponent<UI2DSprite> ().sprite2D = next_L;
								
				GameObject.Find ("Previous").GetComponent<UI2DSprite> ().sprite2D = previous;
				break;
			case 2:
								
				GameObject.Find ("Next").GetComponent<UI2DSprite> ().sprite2D = next;
								
				GameObject.Find ("Previous").GetComponent<UI2DSprite> ().sprite2D = previous_L;
				break;

			}
						
		}
	}

	void Update ()
	{
			
	}
}

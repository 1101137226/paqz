using UnityEngine;
using System.Collections;

public class VSStageManager : MonoBehaviour
{
		public Texture2D[] stage = new Texture2D[0];
		public Sprite next;
		public Sprite next_L;
		public Sprite previous;
		public Sprite previous_L;
		public byte battle_Stage;
		
		
		void Start ()
		{
				GameObject.Find ("Stage").GetComponent<UIPanel> ().alpha = 0;
				
				GameObject selected = GameObject.Find ("Selected Stage");
				GameObject next = GameObject.Find ("Next Stage");
				GameObject previous = GameObject.Find ("Previous Stage");
				selected.GetComponent<UITexture> ().mainTexture = stage [0];
				next.GetComponent<UITexture> ().mainTexture = stage [1];
				previous.GetComponent<UITexture> ().mainTexture = stage [stage.Length - 1];
				battle_Stage = 0;
		}
	
		
		void Update ()
		{
			
		}
}

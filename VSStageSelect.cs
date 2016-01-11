using UnityEngine;
using System.Collections;

public class VSStageSelect : MonoBehaviour
{

	public bool ismove=false;
		
		void Start ()
		{

		}
		
		public void OnPress (bool isPress)
		{
				GameObject selected = GameObject.Find ("Selected Stage");
				GameObject next = GameObject.Find ("Next Stage");
				GameObject previous = GameObject.Find ("Previous Stage");
				GameObject stage_Manager = GameObject.Find ("Stage");
				Texture2D[] stage = stage_Manager.GetComponent<VSStageManager> ().stage;
				Texture2D temp = null;

				if (isPress) {
						if (this.name == "Next") {
								for (int i = 0; i <= stage.Length-1; i++) {
										if (selected.GetComponent<UITexture> ().mainTexture == stage [i]) {
												{
														if (i == stage.Length - 1) {
																stage_Manager.GetComponent<VSStageManager> ().battle_Stage = 0;
														} else {

																stage_Manager.GetComponent<VSStageManager> ().battle_Stage = System.Convert.ToByte(i + 1);
														}
												}

												if (i + 1 == stage.Length - 1) {
														selected.GetComponent<UITexture> ().mainTexture = stage [i + 1];
														next.GetComponent<UITexture> ().mainTexture = stage [0];
														previous.GetComponent<UITexture> ().mainTexture = stage [i];
														break;
												}
												if (i == stage.Length - 1) {
														selected.GetComponent<UITexture> ().mainTexture = stage [0];
														next.GetComponent<UITexture> ().mainTexture = stage [1];
														previous.GetComponent<UITexture> ().mainTexture = stage [i];
														break;
												} else {
														selected.GetComponent<UITexture> ().mainTexture = stage [i + 1];
														next.GetComponent<UITexture> ().mainTexture = stage [i + 2];
														previous.GetComponent<UITexture> ().mainTexture = stage [i];
														break;
												}
										}
								}
						}
						if (this.name == "Previous") {
								for (int i = 0; i <= stage.Length-1; i++) {
										if (selected.GetComponent<UITexture> ().mainTexture == stage [i]) {
												{
														if (i == 0) {
																stage_Manager.GetComponent<VSStageManager> ().battle_Stage = System.Convert.ToByte(stage.Length - 1);
														} else {
																stage_Manager.GetComponent<VSStageManager> ().battle_Stage = System.Convert.ToByte(i - 1);
														}
												}

												if (i - 1 == 0) {
														selected.GetComponent<UITexture> ().mainTexture = stage [0];
														next.GetComponent<UITexture> ().mainTexture = stage [i];
														previous.GetComponent<UITexture> ().mainTexture = stage [stage.Length - 1];
														break;
												}
												if (i == 0) {
														selected.GetComponent<UITexture> ().mainTexture = stage [stage.Length - 1];
														next.GetComponent<UITexture> ().mainTexture = stage [i];
														previous.GetComponent<UITexture> ().mainTexture = stage [stage.Length - 2];
														break;
												} else {
														selected.GetComponent<UITexture> ().mainTexture = stage [i - 1];
														next.GetComponent<UITexture> ().mainTexture = stage [i];
														previous.GetComponent<UITexture> ().mainTexture = stage [i - 2];
														break;
												}
										}
								}
						}
					
						
			ismove=true;

				}
		}
	
		
		void Update ()
		{
		
		}
}

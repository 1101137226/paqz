using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Camera))]
public class screen : MonoBehaviour {
	#region Variables

	public float m_width;

	private Camera m_camera;
	#endregion
	
	#region Behaviour
	private void Awake() {
		m_camera = GetComponent<Camera>();
	}
	
	private void Start() {
		if( m_camera == null )
			return ;
		

		float size = (float)m_width * Screen.height / Screen.width / 2;

		m_camera.orthographicSize = size;

	}
	#endregion
}

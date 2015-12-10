using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Camera))]
public class screen : MonoBehaviour {
	#region Variables
	// 想要固定的螢幕寬度
	public float m_width;
	// 被指定的 Camera
	private Camera m_camera;
	#endregion
	
	#region Behaviour
	private void Awake() {
		m_camera = GetComponent<Camera>();
	}
	
	private void Start() {
		if( m_camera == null )
			return ;
		
		// 倒著算回去
		float size = (float)m_width * Screen.height / Screen.width / 2;
		// 重新指定新的螢幕高度
		m_camera.orthographicSize = size;

	}
	#endregion
}

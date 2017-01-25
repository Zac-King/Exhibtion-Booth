using UnityEngine;
using System.Collections;

public class LookAt : MonoBehaviour
{
   [SerializeField] GameObject m_cam;
	
    void FixedUpdate()
    {
        transform.LookAt(m_cam.transform);
    }
}

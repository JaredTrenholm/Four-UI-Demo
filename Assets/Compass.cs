using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass : MonoBehaviour
{
    public GameObject target;
    public GameObject pivot;
    public GameObject cameraRoot;

    private void Update()
    {
        //pivot.transform.LookAt(target.transform.position + Vector3.forward, Vector3.zero);
        pivot.transform.LookAt(target.transform.position, Vector3.up);
        pivot.transform.rotation = new Quaternion(0f, pivot.transform.rotation.y, 0f, pivot.transform.rotation.w);
        
    }
}

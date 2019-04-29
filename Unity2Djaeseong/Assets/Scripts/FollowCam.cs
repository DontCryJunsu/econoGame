using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Transform targetTr;
    public float dist = 1.31f;
    public float height = 1.629f;
    public float dampTrace = 20.0f;
    private Transform tr;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        
    }

    // Update is called once per frame

    void LateUpdate()
    {
        tr.position = Vector3.Lerp(tr.position, targetTr.position + (Vector3.down * dist) + (Vector3.back * height), Time.deltaTime * dampTrace);
                                 
        tr.LookAt(targetTr.position);
    }
}

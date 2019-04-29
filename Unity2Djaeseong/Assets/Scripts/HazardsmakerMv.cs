using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardsmakerMv : MonoBehaviour
{
    public Transform targetTr;
    private Transform tr;
    public float dist;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        tr.position = Vector3.Lerp(tr.position,targetTr.position +(Vector3.up *dist),Time.deltaTime) ;

        tr.LookAt(targetTr.position);
    }
}

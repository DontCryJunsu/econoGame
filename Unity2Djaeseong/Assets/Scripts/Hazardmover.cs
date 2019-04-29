using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazardmover : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float existTime;
    private void Start()
    {
        Destroy(gameObject, existTime);

    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,speed,0);
          
    }
}

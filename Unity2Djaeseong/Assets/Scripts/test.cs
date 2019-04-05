using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public int RLmove;
    public float ac;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
        transform.Translate(0, ac, 0);
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(RLmove,0,0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-RLmove, 0, 0);
        }

        
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
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
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(RLmove*Time.deltaTime,0,0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-RLmove*Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<PlayerScript>().ac = 1;
            StartCoroutine(Wait());
        }
    
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3f);
        GetComponent<PlayerScript>().ac = 0.2f;
    }

}

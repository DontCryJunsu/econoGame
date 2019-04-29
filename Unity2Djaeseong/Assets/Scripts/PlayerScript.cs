using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float RLmove;
    public float fowardSpeed;
    public float itemDelay;
    public float moveDistance;
    
   
    void Update()
    {  
        transform.Translate(0, fowardSpeed, 0);   
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "buildingMover")
        {
            other.transform.parent.Translate(0, moveDistance, 0);
            
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        
       
        if(other.gameObject.tag == "first" && Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(RLmove, 0, 0);
        }
        if(other.gameObject.tag == "second" && Input.GetKeyDown(KeyCode.D))
        {
          
            transform.Translate(RLmove, 0, 0);
        }
        if (other.gameObject.tag == "second" && Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-RLmove, 0, 0);
        }
        if(other.gameObject.tag == "third" && Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-RLmove, 0, 0);
        }
    }
    
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(itemDelay);
        GetComponent<PlayerScript>().fowardSpeed = 0.2f;
    }

}

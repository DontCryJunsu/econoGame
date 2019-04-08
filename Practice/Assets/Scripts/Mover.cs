using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float Movedistance;
    public float RLmove;
    public float ac;
    public float FBmove;
    public GameObject Building;
    public GameObject BA;
    public Transform BMposition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, ac, 0);
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(RLmove*Time.deltaTime,0,0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(-RLmove*Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, FBmove * Time.deltaTime, 0);
        }
     
        
          
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MapMaker")
        {
            Instantiate(Building, BMposition.position, BMposition.rotation);
        }
        if (other.gameObject.tag == "Destroyer")
        {
            Destroy(other.transform.parent.gameObject);
        }
        if (other.gameObject.tag == "Bmover")
        {
            other.transform.parent.Translate(0, Movedistance, 0);
        }
        if (other.gameObject.tag == "Hazards")
        {
            GetComponent<Mover>().ac = -0.2f;
            transform.Rotate(Random.Range(-90, 90), Random.Range(-90, 90), Random.Range(-90, 90));
            transform.Translate(0, 0, 2);
        }

    }
}

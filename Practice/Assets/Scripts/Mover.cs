using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public GameObject[] Items;
    public float Movedistance;
    public float RLmove;
    public float ac;
    public float FBmove;
    public GameObject Building;
    public GameObject BrokenBuilding;
    public Transform BMposition;
    public Transform Window;
    public float t;
    public int number;
   
    // Start is called before the first frame update
  

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
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -FBmove * Time.deltaTime, 0);
        }
        if (number > 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                number = number - 1;
                GameObject Item = Items[Random.Range(0, Items.Length)];
                Vector3 tr = Window.position + new Vector3(0, 1, -0.1f);
                Quaternion spawnRotation = Quaternion.Euler(new Vector3(0, 180, 0));
                Instantiate(Item, Window);
                Instantiate(BrokenBuilding, tr, spawnRotation);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag == "Hammer")
        {
            number = number + 1;
            Destroy(other.gameObject);
        }
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
            
            
            StartCoroutine(Delay());
        }
        if (other.gameObject.tag == "power")
        {
            Destroy(other.gameObject);

            StartCoroutine(Power());

        }
    }
  IEnumerator Delay()
    {
        yield return new WaitForSeconds(t);
    }
    IEnumerator Power()
    {
     GetComponent<Mover>().ac = 0.3f;
    
     yield return new WaitForSeconds(t);
     GetComponent<Mover>().ac = 0.05f;
    
     }


}

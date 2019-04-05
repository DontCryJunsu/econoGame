using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapControll : MonoBehaviour
{
    public GameObject Map;
    public Transform Player;
    private void Update()
    {
    
    }

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
      
        



        if (other.gameObject.tag == "MapController")
        {
            Instantiate(Map, Player.position , Player.rotation);
        }
    }

}

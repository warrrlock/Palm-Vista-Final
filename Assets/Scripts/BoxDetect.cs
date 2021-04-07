using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDetect : MonoBehaviour
{
    public GameObject box;
    public throwAway throwScript;
    public GameObject PickupParticles;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "pickup"){
            if (throwScript.inHand == false) {
                Instantiate(PickupParticles, transform.position, Quaternion.identity);
                Destroy(box);
              
            }
            
        }
            
    }
}

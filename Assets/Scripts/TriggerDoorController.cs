using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorController : MonoBehaviour
{
    public GameObject myDoor = null;
    public bool open = false;
    //public bool opened = false;
    public float openAngle = 0;
    public Material green;
    private MeshRenderer mr;
    void Start()
    {
        //anim = myDoor.GetComponent<Animator>();
        mr = GetComponent<MeshRenderer>();
    }
    void FixedUpdate()
    {
        if (open)
        {
            mr.material = green;
            if (openAngle < 90)
            {
                myDoor.transform.Rotate(new Vector3(0,-2,0));
                openAngle += 2;
            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("pickup")){
            open = true; 
        }
    }
}
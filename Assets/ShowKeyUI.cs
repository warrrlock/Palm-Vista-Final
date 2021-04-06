using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowKeyUI : MonoBehaviour
{

    public GameObject UIObject, tealKeyUI, greenKeyUI, blueKeyUI, skyBKeyUI, pinkKeyUI, purpKeyUI, redKeyUI;

    public GameObject tealKey, greenKey, blueKey, skyBKey, pinkKey, purpKey, redKey;

    // Start is called before the first frame update
    void Start()
    {
        UIObject.SetActive(false);
        tealKeyUI.SetActive(false);
        greenKeyUI.SetActive(false);
        blueKeyUI.SetActive(false);
        skyBKeyUI.SetActive(false);
        pinkKeyUI.SetActive(false);
        purpKeyUI.SetActive(false);
        redKeyUI.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter (Collider other)
    {
        

        if (other.gameObject == tealKey)
        {
            UIObject.SetActive(true);
            tealKeyUI.SetActive(true);
        }

        if (other.gameObject == greenKey)
        {
            greenKeyUI.SetActive(true);
        }

        if (other.gameObject == blueKey)
        {
            blueKeyUI.SetActive(true);
        }

        if (other.gameObject == skyBKey)
        {
            skyBKeyUI.SetActive(true);
        }

        if (other.gameObject == pinkKey)
        {
            pinkKeyUI.SetActive(true);
        }

        if (other.gameObject == purpKey)
        {
            purpKeyUI.SetActive(true);
        }

        if (other.gameObject == redKey)
        {
            redKeyUI.SetActive(true);
        }
    }
}

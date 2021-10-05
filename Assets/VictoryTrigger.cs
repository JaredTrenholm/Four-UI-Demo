using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictoryTrigger : MonoBehaviour
{
    public Text victoryText;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            victoryText.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            victoryText.enabled = false;
        }
    }
}

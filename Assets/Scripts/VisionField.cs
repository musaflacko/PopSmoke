using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionField : MonoBehaviour
{
    [SerializeField]
    private VisionPatrol connectedAI;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            connectedAI.SeePlayer(other.transform);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            connectedAI.LostPlayer();
        }
    }
}

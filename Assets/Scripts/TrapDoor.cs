using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDoor : MonoBehaviour
{
    public Animator Door;

    private bool step = false;

    [SerializeField]
    private AudioSource DoorOpen;

    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
 
    private void OnCollisionEnter(Collision collision)
    {
        step = true;
        Door.SetBool("StepOn", step);
        DoorOpen.Play();
    }
}

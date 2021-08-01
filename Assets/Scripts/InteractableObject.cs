using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{

    public Animator myAnimator;

    private bool PlayerAtDoor = false;
    // Start is called before the first frame update

    private void Awake()
    {
        PlayerAtDoor = gameObject.GetComponent<Animator>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact()
    {
        PlayerAtDoor = true;
        myAnimator.SetBool("PlayerAtDoor", PlayerAtDoor);
    }
}

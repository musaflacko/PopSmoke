using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chaser : MonoBehaviour
{
    NavMeshAgent agentComponent;

    [SerializeField]
    Transform thingsToChase;
    private void Awake()
    {
        agentComponent = GetComponent<NavMeshAgent>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(thingsToChase != null)
        {
            agentComponent.SetDestination(thingsToChase.position);
        }
    }
}

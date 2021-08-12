using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class VisionPatrol : MonoBehaviour
{
    public string currentState;

    public string nextState;

    [SerializeField]
    private float idleTime;

    private NavMeshAgent agentComponent;

    [SerializeField]
    private Transform[] checkpoints;

    private int currentCheckpoint;

    private Transform playerToChase;

    private void Awake()
    {
        agentComponent = GetComponent<NavMeshAgent>();
    }

    // Start is called before the first frame update
    void Start()
    {
        nextState = "Idle";
    }

    // Update is called once per frame
    void Update()
    {
        if (currentState != nextState)
        {
            currentState = nextState;
            StartCoroutine(currentState);
        }
    }

    public void SeePlayer(Transform seenPlayer)
    {
        playerToChase = seenPlayer;
        nextState = "ChasingPlayer";
    }

    public void LostPlayer()
    {
        playerToChase = null;
    }

    IEnumerator Idle()
    {
        while (currentState == "Idle")
        {
            yield return new WaitForSeconds(idleTime);
            Debug.Log("I am Idling");

            nextState = "Patrolling";
        }
    }

    IEnumerator Patrolling()
    {
        agentComponent.SetDestination(checkpoints[currentCheckpoint].position);
        bool hasReached = false;
        while (currentState == "Patrolling")
        {
            yield return null;
            if (!hasReached)
            {
                if (agentComponent.remainingDistance <= agentComponent.stoppingDistance)
                {
                    hasReached = true;
                    nextState = "Idle";
                    ++currentCheckpoint;
                    if (currentCheckpoint >= checkpoints.Length)
                    {
                        currentCheckpoint = 0;
                    }
                }
            }
        }
    }

    IEnumerator ChasingPlayer()
    {
        while (currentState == "ChasingPlayer")
        {
            yield return null;
            if (playerToChase != null)
            {
                agentComponent.SetDestination(playerToChase.position);
            }
            else
            {
                nextState = "Idle";
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("GameOver");
    }
}

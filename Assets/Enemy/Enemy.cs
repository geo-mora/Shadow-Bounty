using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private StateMachine StateMachine;
    private NavMeshAgent agent;
    public NavMeshAgent Agent { get => agent; }

    [SerializeField]
    private string currentState;
    public Path path;
    // Start is called before the first frame update
    void Start()
    {
        StateMachine = GetComponent<StateMachine>();
        agent = GetComponent<NavMeshAgent>();
        StateMachine.Initialise();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

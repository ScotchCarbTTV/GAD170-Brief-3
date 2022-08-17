using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using FiniteStateMachine;

public class Demon : MonoBehaviour
{
    [SerializeField] private Vector2 patrolTarget; 

    private GameObject player;

    private NavMeshAgent agent;

    [SerializeField] private NavmarkerManager navManager;

    StateMachine StateMachine;

    private void Awake()
    {
        StateMachine = new StateMachine();
        agent = GetComponent<NavMeshAgent>();
        GameObject.FindGameObjectWithTag("NavMarker").TryGetComponent<NavmarkerManager>(out navManager);
    }

    void Start()
    {
        //set the state to the idle state
        StateMachine.SetState(new DemonPatrol(this));

        
        player = GameObject.FindGameObjectWithTag("Player");

    }


    void Update()
    {
        StateMachine.OnUpdate();
    }

    public abstract class DemonState : IState
    {
        public Demon instance;

        public DemonState(Demon _instance)
        {
            instance = _instance;
        }

        public virtual void OnEnter()
        {
           
        }

        public virtual void OnExit()
        {
            
        }

        public virtual void OnUpdate()
        {
           
        }
    }

    //dead/idle state

    //patrol state
    public class DemonPatrol : DemonState
    {
        public DemonPatrol(Demon _instance) : base(_instance)
        {

        }

        public override void OnEnter()
        {
            instance.agent.isStopped = false;
            instance.patrolTarget = instance.navManager.GetRandomNavMarker().position;
            instance.agent.SetDestination(instance.patrolTarget);
        }

        public override void OnUpdate()
        {
            if(Vector3.Distance(instance.transform.position, new Vector3(instance.patrolTarget.x, instance.agent.transform.position.y, instance.patrolTarget.y)) <= 3f)
            {
                instance.patrolTarget = instance.navManager.GetRandomNavMarker().position;
                instance.agent.SetDestination(instance.patrolTarget);
            }
        }


    }

    //hunting state

    //chasing state
    public class DemonChase : DemonState
    {
        public DemonChase(Demon _instance) : base(_instance) { }

        public override void OnEnter()
        {
            instance.agent.isStopped = false;
        }

        public override void OnUpdate()
        {
            instance.agent.SetDestination(instance.player.transform.position);
        }

        public override void OnExit()
        {

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using FiniteStateMachine;

public class Demon : MonoBehaviour
{
    [SerializeField] private Vector3 patrolTarget; 

    private GameObject player;

    private NavMeshAgent agent;

    [SerializeField] private NavmarkerManager navManager;

    StateMachine StateMachine;

    //reference to the DemonAttack script
    [SerializeField] DemonAttack dAttack;

    private void Awake()
    {
        StateMachine = new StateMachine();
        agent = GetComponent<NavMeshAgent>();
        GameObject.FindGameObjectWithTag("NavMarker").TryGetComponent<NavmarkerManager>(out navManager);
    }

    void Start()
    {
        //set the state to the idle state
        SetPatrol();
        
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        StateMachine.OnUpdate();
    }

    public void DespawnDemon()
    {
        //return the demon to the DemonRoster as an inactie game object upon death
        DemonRoster.ReturnDemonEvent(gameObject);
    }

    #region DemonState setters
    
    //method for switching patrol
    public void SetPatrol()
    {
        StateMachine.SetState(new DemonPatrol(this));
    }

    //method for switching to hunt
    public void SetHunt(Vector3 huntPos)
    {
        patrolTarget = huntPos;
        StateMachine.SetState(new DemonHunt(this));
    }

    //method for switching to chase
    public void SetChase()
    {
        StateMachine.SetState(new DemonChase(this));
    }
    #endregion

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
            if(Vector3.Distance(instance.transform.position, instance.patrolTarget) <= 5f)
            {
                instance.patrolTarget = instance.navManager.GetRandomNavMarker().position;
                instance.agent.SetDestination(instance.patrolTarget);
            }
        }


    }

    //hunting state
    public class DemonHunt : DemonState
    {
        public DemonHunt(Demon _instance) : base(_instance) { }

        //move towards the last known position of the player

    }

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

            if(Vector3.Distance(instance.transform.position, instance.player.transform.position) < 3)
            {
                //do the attack anim on the attack obj
                instance.dAttack.Attack();
            }
        }

        public override void OnExit()
        {

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            SetChase();
        }
    }

}

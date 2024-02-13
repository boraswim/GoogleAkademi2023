using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCAI : MonoBehaviour
{
    /*
    [SerializeField] private GameObject destinationPoint;
    private NavMeshAgent _agent;
    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        _agent.SetDestination(destinationPoint.transform.position);
    }
    */

    public NavMeshAgent _agent;
    [SerializeField] public Transform _player;

    public LayerMask ground, player;
    public Vector3 destinationPoint;
    bool destinationPointSet;
    public float walkPointRange;

    public float timeBetweenAttacks;
    private bool alreadyAttacked;
    public GameObject sphere;
    public List<GameObject> bullets = new List<GameObject>();

    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;

    void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, player);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, player);

        // Patrol / Chase / Attack

        if(!playerInSightRange && !playerInAttackRange) Patroling();
        if(playerInSightRange && !playerInAttackRange) ChasePlayer();
        if(playerInSightRange && playerInAttackRange) AttackPlayer();
    }
    
    void Patroling()
    {
        if(!destinationPointSet)
            SearchWalkPoint();
        if(destinationPointSet)
            _agent.SetDestination(destinationPoint);
        Vector3 distanceToDestinationPoint = transform.position - destinationPoint;
        if(distanceToDestinationPoint.magnitude < 1.0f)
            destinationPointSet = false;
    }
    
    void SearchWalkPoint()
    {
        float randomX = Random.Range(-walkPointRange, walkPointRange);
        float randomZ = Random.Range(-walkPointRange, walkPointRange);

        destinationPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        if(Physics.Raycast(destinationPoint, -transform.up, 2.0f, ground))
        {
            destinationPointSet = true;
        }
    }

    void ChasePlayer()
    {
        _agent.SetDestination(_player.position);
    }

    void AttackPlayer()
    {
        
        _agent.SetDestination(transform.position);
        transform.LookAt(_player);
        if(!alreadyAttacked)
        {
            
            Rigidbody rb = Instantiate(sphere, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
            bullets.Add(rb.gameObject);
            rb.AddForce(transform.forward * 25f, ForceMode.Impulse); // Forward
            rb.AddForce(transform.up * 7f, ForceMode.Impulse); // Up
            if(bullets.Count > 5)
            {
                Destroy(bullets[0]);
                bullets.RemoveAt(0);
            }
            StartCoroutine(ChangeTag(rb.gameObject));
            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }
    }

    IEnumerator ChangeTag(GameObject gameObject)
    {
        yield return new WaitForSeconds(2.0f);
        gameObject.tag = "Respawn";
    }
    void ResetAttack()
    {
        alreadyAttacked = false;
    }
}

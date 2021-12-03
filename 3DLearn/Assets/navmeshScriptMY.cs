using UnityEngine.AI;
using UnityEngine;

public class navmeshScriptMY : MonoBehaviour
{
	NavMeshAgent agent;
	public GameObject player;
	private void Awake()
	{
		agent = GetComponent<NavMeshAgent>();
	}

	private void Start()
	{
		
	}

	private void Update()
	{
		if ( Vector3.Distance (transform.position , player.transform.position) > 10f)
		{
			agent.destination = player.transform.position;
		}
		
	}
}

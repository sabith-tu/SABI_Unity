 
using UnityEngine;

public class AIAnimation : MonoBehaviour
{
	CharacterController characterC;
	Animator animator;
	private void Awake()
	{
		characterC = GetComponent<CharacterController>();
		animator = GetComponent<Animator>();
	}
	private void Update()
	{

		if (characterC.velocity.magnitude < 10f)
		{

		}
	}

	private void FixedUpdate()
	{
		if (characterC != null)
		{
			float speed = characterC.velocity.magnitude;
			Debug.Log(speed);
			Debug.Log(characterC.velocity);
			
		}
		
	}
}

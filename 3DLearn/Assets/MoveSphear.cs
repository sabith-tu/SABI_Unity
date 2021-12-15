using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveSphear : MonoBehaviour
{
	MStarterAssets inp;
	Rigidbody rb;

	private void Awake()
	{
		rb = GetComponent<Rigidbody>();
	}

	private void Start()
	{
		inp = new MStarterAssets();
		inp.Player.Enable();

		inp.Player.Jump.performed += _ => jump();
		inp.Player.Move.performed += _ => move();
	}

	void jump()
	{
		rb.AddForce(Vector3.up * 10f, ForceMode.Impulse);
	}
	void move()
	{
		Vector2 val = inp.Player.Move.ReadValue<Vector2>();
		rb.AddForce(new Vector3(val.x , 0f , val.y) * 10f, ForceMode.Impulse);
	}
}

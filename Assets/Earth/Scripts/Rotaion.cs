using UnityEngine;
using System;

public class Rotaion : MonoBehaviour
{
	public float zRotation = 0;

	private void Start()
	{
	}
	void Update()
	{
		//zRotation = .2f;
		transform.Rotate (0, 0, zRotation);
	}
}
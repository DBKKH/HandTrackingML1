using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.MagicLeap;


public class ChangeColorA : MonoBehaviour
{
	public Material NotFoucusedMaterial, FoucusedMaterial;

	private MeshRenderer _meshRenderer;

	// Use this for initialization
	void Start()
	{
		_meshRenderer = gameObject.GetComponent<MeshRenderer>();

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.A))
		{
			Debug.Log("A down");
			_meshRenderer.material = NotFoucusedMaterial;
		}

//		if (Input.GetKeyDown(KeyCode.A)) Debug.Log("A down");

		if (Input.GetKey(KeyCode.B))
		{
			Debug.Log("B");
			_meshRenderer.material = FoucusedMaterial;
		}
	}
}

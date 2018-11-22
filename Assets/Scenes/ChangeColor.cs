using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeColor : MonoBehaviour
{

	//Rayが当たってるかのフラグ
	public bool select_flg;

	[SerializeField] private Material FoucusedMaterial, NonFoucusedMaterial;
	private MeshRenderer _meshRenderer;

	void Start()
	{
		select_flg = false;
		_meshRenderer = gameObject.GetComponent<MeshRenderer>();
	}

	void Update()
	{
		_meshRenderer.material = NonFoucusedMaterial;

		if (select_flg)
		{
			//オブジェクトの色を変更する
			_meshRenderer.material = FoucusedMaterial;
			//RayがObjectから外れたとき用
			select_flg = false;
		}
	}
}
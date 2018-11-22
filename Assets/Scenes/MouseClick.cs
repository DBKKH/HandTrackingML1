using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		// 左ボタンクリック
		if (Input.GetMouseButtonUp(0))
		{
			Vector3 mousePosition = Input.mousePosition;
			Debug.Log("LeftClick:" + mousePosition);
		}
		// 右ボタンクリック
		if (Input.GetMouseButtonUp(1))
		{
			Vector3 mousePosition = Input.mousePosition;
			Debug.Log("RightClick:" + mousePosition);
		}
		// 中ボタンクリック
		if (Input.GetMouseButtonUp(2))
		{
			Vector3 mousePosition = Input.mousePosition;
			Debug.Log("MiddleClick:" + mousePosition);
		}
	}
}

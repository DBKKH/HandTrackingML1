using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastMouse : MonoBehaviour
{
	void Start()
	{

	}
	// Update is called once per frame
	void Update()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		//RaycastHit rayHit;
		RaycastHit hit = new RaycastHit();

		if (Physics.Raycast(ray, out hit))
		{
			if (hit.collider.gameObject.GetComponent<ChangeColor>())
			{
				hit.collider.gameObject.GetComponent<ChangeColor>().select_flg = true;
			}

		}
	}
}

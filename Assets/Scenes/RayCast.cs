//カメラ上にあるオブジェクトの位置に飛ばすレイを作成する

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{

	void Start()
	{

	}

	void Update()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//		Ray ray = new Ray (transform.position, new Vector3 (0, -1, 0));

		RaycastHit hit = new RaycastHit();

		//作成したレイを投げる。コライダーに当たった場合はtrueが返る
		if (Physics.Raycast(ray, out hit))
		{
			if (hit.collider.gameObject.GetComponent<ChangeColor>())
			{
				hit.collider.gameObject.GetComponent<ChangeColor>().select_flg = true;
			}
		}
	}
}
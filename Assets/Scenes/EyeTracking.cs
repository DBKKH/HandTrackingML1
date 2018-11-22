using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.MagicLeap;

public class EyeTracking : MonoBehaviour
{

	[SerializeField] private GameObject Camera;

	private Vector3 headpos;


	void Start()
	{
		MLEyes.Start();
	}
	private void OnDisable()
	{
		MLEyes.Stop();
	}

	// Update is called once per frame
	void Update()
	{
		if (MLEyes.IsStarted)	//MLEyesはEyeTracking用のクラス
		{
			RaycastHit hit = new RaycastHit();
			headpos = MLEyes.FixationPoint - Camera.transform.position;	//頭の位置を計算

			if (Physics.Raycast(Camera.transform.position, headpos, out hit))
			{
				//ObjectにRayが当たった時にselect_flgをtrueにする
				if (hit.collider.gameObject.GetComponent<ChangeColor>())
				{
					hit.collider.gameObject.GetComponent<ChangeColor>().select_flg = true;
				}
			}
		}
	}
}

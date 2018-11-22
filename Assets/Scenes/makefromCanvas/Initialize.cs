using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Initialize : MonoBehaviour
{
	public Canvas canvas;

	// Use this for initialization
	void Start()
	{
		Text target;
		foreach (Transform child in canvas.transform)
		{
			if (child.name == "Main Title")
			{
				target = child.gameObject.GetComponent<Text>();
				target.text = "AAAAAAA";
			}
			else if (child.name == "Sub Title")
			{
				target = child.gameObject.GetComponent<Text>();
				target.text = "BBBBBBB";
			}
		}
	}



	// Update is called once per frame
	void Update()
	{

	}
}
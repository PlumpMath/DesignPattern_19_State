using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
	public SafeFrame frame;
	// Use this for initialization
	void Start()
	{
		Debug.Log("Start Clock");
		StartCoroutine(Interval());
	}

	// Update is called once per frame
	void Update()
	{
		
	}

	IEnumerator Interval()
	{
		while (true)
		{
			for (int i = 0; i < 24; i++)
			{
				frame.SetClock(i);
				yield return new WaitForSeconds(1);
			}
		}
	}
}

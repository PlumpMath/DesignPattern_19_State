using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SafeFrame : MonoBehaviour, Context
{
	public Text textClock;
	public Text textArea;

	private State state = DayState.GetInstance();

	void Start()
	{

	}

	void Update()
	{

	}

	public void SetClock(int hour)
	{
		string clockString = "現在時刻は";
		if (hour < 10)
		{
			clockString += "0" + hour + ":00";
		}
		else
		{
			clockString += hour + ":00";
		}
		Debug.Log(clockString);
		textClock.text = clockString;
		state.DoClock(this, hour);
	}

	public void PushUse()
	{
		state.DoUse(this);
	}

	public void PushAlarm()
	{
		state.DoAlarm(this);
	}

	public void PushPhone()
	{
		state.DoPhone(this);
	}

	public void PushExit()
	{
		if (Application.isEditor)
		{
			UnityEditor.EditorApplication.isPlaying = false;
		}
		Application.Quit();

	}

	public void CallSecurityCenter(string msg)
	{
		string text = "call! " + msg + "\n" + textArea.text;
		textArea.text = text;

	}

	public void ChangeState(State state)
	{
		Debug.Log(this.state + " から " + state + " へ状態が変化しました");
		this.state = state;
	}

	public void RecordLog(string msg)
	{
		string text = "record... " + msg + "\n" + textArea.text;
		textArea.text = text;
	}
}

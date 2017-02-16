using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NightState : State
{
	// Singleton Pattern.
	private static NightState singleton = new NightState();

	private NightState()
	{

	}

	public static State GetInstance()
	{
		return singleton;
	}

	public void DoAlarm(Context context)
	{
		context.CallSecurityCenter("非常ベル(夜間)");
	}

	public void DoClock(Context context, int hour)
	{
		if (9 <= hour && hour < 17)
		{
			context.ChangeState(DayState.GetInstance());
		}
	}


	public void DoPhone(Context context)
	{
		context.CallSecurityCenter("通話録音(夜間)");
	}

	public void DoUse(Context context)
	{
		context.RecordLog("非常！：金庫使用(夜間)");
	}

	public override string ToString()
	{
		return "[夜間]";
	}
}

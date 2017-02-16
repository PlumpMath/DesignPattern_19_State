using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DayState : State
{
	// Singleton Pattern.
	private static DayState singleton = new DayState();

	private DayState()
	{

	}

	public static State GetInstance()
	{
		return singleton;
	}

	public void DoAlarm(Context context)
	{
		context.CallSecurityCenter("非常ベル(昼間)");
	}

	public void DoClock(Context context, int hour)
	{
		if (hour < 9 || 17 <= hour)
		{
			context.ChangeState(NightState.GetInstance());
		}
	}


	public void DoPhone(Context context)
	{
		context.CallSecurityCenter("通常の通話(昼間)");
	}

	public void DoUse(Context context)
	{
		context.RecordLog("金庫使用(昼間)");
	}

	public override string ToString()
	{
		return "[昼間]";
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface State
{
	// Context は、状態の管理を行っているインタフェースです
	// 実際には、UIそのものがContextになります(Context interfaceを実現します)
	void DoClock(Context context, int hour);
	void DoUse(Context context);
	void DoAlarm(Context context);
	void DoPhone(Context context);
}

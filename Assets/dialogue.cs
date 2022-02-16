using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogue : MonoBehaviour
{

	//当碰撞开始时
	void OnCollisionEnter(Collision other)
	{
		print("OnCollisionEnter");
	}

	//当碰撞的时候，一直持续到停止动作的时候
	void OnCollisionStay(Collision other)
	{
		if (string.Equals(other.gameObject.name, "cub"))
		{
			print("OnCollisionStay");
		}
	}

	//当碰撞结束后
	void OnCollisionExit(Collision other)
	{
		print("OnCollisionExit");

	}
}

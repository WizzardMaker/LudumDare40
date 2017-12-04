using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseObject : ScriptableObject {
	public PlayerInfo info;

	[Tooltip("In Kilograms")]
	public float weight=1;

	public abstract void WhileInPossesion();
	public abstract void StartPossesion(GameObject caller);
	public abstract void EndPossesion();
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Objects/Coin")]
public class CoinObject : BaseObject {

	public override void EndPossesion() {
		info.gold--;
	}

	public override void StartPossesion() {
		info.gold++;
	}

	public override void WhileInPossesion() {
		
	}
}

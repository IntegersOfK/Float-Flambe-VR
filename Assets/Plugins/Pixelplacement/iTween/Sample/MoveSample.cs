using UnityEngine;
using System.Collections;

public class MoveSample : MonoBehaviour
{	
	void Start(){
		iTween.MoveBy(gameObject, iTween.Hash("x", 2, "easeType", "easeInOutExpo", "loopType", "pingPong", "delay", .1));
        iTween.ScaleFrom(gameObject, iTween.Hash("x", 2, "y", 2, "z", 2, "easeType", "easeInOutExpo", "loopType", "pingPong", "delay", 1));
	}
}


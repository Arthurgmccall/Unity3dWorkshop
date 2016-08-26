using UnityEngine;
using System.Collections;

public class yourComponent : MonoBehaviour { 
	void Start() {
		Debug.Log ("start");
	}

	void Update(){
		Debug.LogFormat ("Time={0}", Time.time);
	}
}

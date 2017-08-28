using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ZombieScript : MonoBehaviour, IVirtualButtonEventHandler {

	private GameObject vbButtonObject;
	private GameObject zombie;

	// Use this for initialization
	void Start () {
		vbButtonObject = GameObject.Find ("attackButton");
		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
		zombie = GameObject.Find ("zombie");
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) {
		Debug.Log ("Attack button down");
		zombie.GetComponent<Animation> ().Play ("attack");
	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) {
		zombie.GetComponent<Animation> ().Stop ("attack");
	}
}

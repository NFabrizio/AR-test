using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class NewBehaviourScript1 : MonoBehaviour, IVirtualButtonEventHandler {

//	private Object logoAnimation;
	private GameObject vbButtonObject;
	private GameObject pearsonLogo;
	private GameObject infoFounding;

	// Use this for initialization
	void Start () {
		vbButtonObject = GameObject.Find ("actionButton");
		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
		pearsonLogo = GameObject.Find ("pearsonLogo");
//		logoAnimation = pearsonLogo.GetComponent<Animator> ();
		infoFounding = GameObject.Find ("infoFounding");
		infoFounding.GetComponent<MeshRenderer> ().enabled = false;
//		GameObject.Find ("infoFounding").transform.localScale = new Vector3(0, 0, 0);
//		pearsonLogo.GetComponent<Animator> ().enabled = false;
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) {
		Debug.Log ("Logo button down");
//		Debug.Log(infoFounding);
//		Debug.Log ("Logo animation initially");
//		Debug.Log (logoAnimation);
//		GameObject.Find ("infoFounding").transform.localScale = new Vector3(1, 1, 1);
		// -1.085, 0.043, 0.304
		pearsonLogo.GetComponent<Animator> ().enabled = !pearsonLogo.GetComponent<Animator> ().enabled;
//		logoAnimation.enabled = !logoAnimation.enabled;
//		Debug.Log ("Logo animation finally");
//		Debug.Log (logoAnimation);
//		infoFounding.GetComponent<MeshRenderer> ().enabled = !infoFounding.GetComponent<MeshRenderer> ().enabled;
		if (infoFounding.GetComponent<TextMesh> ().text == "") {
			infoFounding.GetComponent<TextMesh> ().text = "Pearson was \n founded in 1844";
		} else {
			infoFounding.GetComponent<TextMesh> ().text = "";
		}
	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) {
		
	}

	public void Update() {
		
	}
}

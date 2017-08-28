using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class DilbertScript : MonoBehaviour, IVirtualButtonEventHandler {

	//	private Object logoAnimation;
	private GameObject vbButtonObject;
	private GameObject pearsonLogo_dilbert;
	private GameObject infoFounder;

	// Use this for initialization
	void Start () {
		vbButtonObject = GameObject.Find ("actionButton_dilbert");
		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
		pearsonLogo_dilbert = GameObject.Find ("pearsonLogo_dilbert");
		//		logoAnimation = pearsonLogo.GetComponent<Animator> ();
		infoFounder = GameObject.Find ("infoFounder");
		infoFounder.GetComponent<MeshRenderer> ().enabled = false;
		//		GameObject.Find ("infoFounding").transform.localScale = new Vector3(0, 0, 0);
		//		pearsonLogo.GetComponent<Animator> ().enabled = false;
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) {
		Debug.Log ("Dilbert button down");
		//		Debug.Log(infoFounding);
		//		Debug.Log ("Logo animation initially");
		//		Debug.Log (logoAnimation);
		//		GameObject.Find ("infoFounding").transform.localScale = new Vector3(1, 1, 1);
		// -1.085, 0.043, 0.304
		pearsonLogo_dilbert.GetComponent<Animator> ().enabled = !pearsonLogo_dilbert.GetComponent<Animator> ().enabled;
		//		logoAnimation.enabled = !logoAnimation.enabled;
		//		Debug.Log ("Logo animation finally");
		//		Debug.Log (logoAnimation);
		//		infoFounding.GetComponent<MeshRenderer> ().enabled = !infoFounding.GetComponent<MeshRenderer> ().enabled;
		if (infoFounder.GetComponent<TextMesh> ().text == "") {
			infoFounder.GetComponent<TextMesh> ().text = "Pearson was founded \n by Samuel Pearson";
		} else {
			infoFounder.GetComponent<TextMesh> ().text = "";
		}
	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) {

	}
}


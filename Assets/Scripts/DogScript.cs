using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class DogScript : MonoBehaviour, IVirtualButtonEventHandler {

	//	private Object logoAnimation;
	private GameObject vbButtonObject;
	private GameObject pearsonLogo_dog;
	private GameObject infoStart;

	// Use this for initialization
	void Start () {
		vbButtonObject = GameObject.Find ("actionButton_dog");
		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
		pearsonLogo_dog = GameObject.Find ("pearsonLogo_dog");
		//		logoAnimation = pearsonLogo.GetComponent<Animator> ();
		infoStart = GameObject.Find ("infoStart");
		infoStart.GetComponent<MeshRenderer> ().enabled = false;
		//		GameObject.Find ("infoFounding").transform.localScale = new Vector3(0, 0, 0);
		//		pearsonLogo.GetComponent<Animator> ().enabled = false;
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) {
		Debug.Log ("Dog button down");
		//		Debug.Log(infoFounding);
		//		Debug.Log ("Logo animation initially");
		//		Debug.Log (logoAnimation);
		//		GameObject.Find ("infoFounding").transform.localScale = new Vector3(1, 1, 1);
		// -1.085, 0.043, 0.304
		pearsonLogo_dog.GetComponent<Animator> ().enabled = !pearsonLogo_dog.GetComponent<Animator> ().enabled;
		//		logoAnimation.enabled = !logoAnimation.enabled;
		//		Debug.Log ("Logo animation finally");
		//		Debug.Log (logoAnimation);
		//		infoFounding.GetComponent<MeshRenderer> ().enabled = !infoFounding.GetComponent<MeshRenderer> ().enabled;
		if (infoStart.GetComponent<TextMesh> ().text == "") {
			infoStart.GetComponent<TextMesh> ().text = "Pearson was \n started as a \n building & engineering \n company";
		} else {
			infoStart.GetComponent<TextMesh> ().text = "";
		}
	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) {

	}
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class StarryScript : MonoBehaviour, IVirtualButtonEventHandler {

	//	private Object logoAnimation;
	private GameObject vbButtonObject;
	private GameObject pearsonLogo_starry;
	private GameObject infoPublishing;

	// Use this for initialization
	void Start () {
		vbButtonObject = GameObject.Find ("actionButton_starry");
		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
		pearsonLogo_starry = GameObject.Find ("pearsonLogo_starry");
		//		logoAnimation = pearsonLogo.GetComponent<Animator> ();
		infoPublishing = GameObject.Find ("infoPublishing");
		infoPublishing.GetComponent<MeshRenderer> ().enabled = false;
		//		GameObject.Find ("infoFounding").transform.localScale = new Vector3(0, 0, 0);
		//		pearsonLogo.GetComponent<Animator> ().enabled = false;
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) {
		Debug.Log ("Starry button down");
		//		Debug.Log(infoFounding);
		//		Debug.Log ("Logo animation initially");
		//		Debug.Log (logoAnimation);
		//		GameObject.Find ("infoFounding").transform.localScale = new Vector3(1, 1, 1);
		// -1.085, 0.043, 0.304
		pearsonLogo_starry.GetComponent<Animator> ().enabled = !pearsonLogo_starry.GetComponent<Animator> ().enabled;
		//		logoAnimation.enabled = !logoAnimation.enabled;
		//		Debug.Log ("Logo animation finally");
		//		Debug.Log (logoAnimation);
		//		infoFounding.GetComponent<MeshRenderer> ().enabled = !infoFounding.GetComponent<MeshRenderer> ().enabled;
		if (infoPublishing.GetComponent<TextMesh> ().text == "") {
			infoPublishing.GetComponent<TextMesh> ().text = "In 1921, \nPearson moved \ninto publishing";
		} else {
			infoPublishing.GetComponent<TextMesh> ().text = "";
		}
	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) {

	}
}


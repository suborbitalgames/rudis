using UnityEngine;
using System.Collections;

public class GladiatorSkill : MonoBehaviour {

	public GameObject progressBar;

	private float ratio = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setRatio(float newRatio){
		ratio = newRatio;
		updateProgressBar();
	}

	private void updateProgressBar(){
		Vector3 newScale = new Vector3(ratio, 1f, 1f);
		progressBar.transform.localScale = newScale;
	}
}

using UnityEngine;
using System.Collections;

public class GladiatorInfoManager : MonoBehaviour {

	public GameObject selectedComponent;

	// Use this for initialization
	void Start () {
		selectedComponent.SendMessage("setSelected");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void changeSelectedObject(GameObject selected){
		selectedComponent.SendMessage("setDeselected");
		selectedComponent = selected;
		selectedComponent.SendMessage("setSelected");
	}
}

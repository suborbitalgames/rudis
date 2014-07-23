using UnityEngine;
using System.Collections;

public class GladiatorInfoDisplay : MonoBehaviour {

	public GameObject bioDisplay;
	public GameObject skillDisplay;
	public GameObject selectedComponent;


	public GladiatorInfo info;

	// Use this for initialization
	void Start () {
		selectedComponent.SendMessage("setSelected");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setGladiatorInfo(GladiatorInfo newInfo){
		info = newInfo;
		selectedComponent.SendMessage("setSelected");
		//bioDisplay.SendMessage("updateContent");
	}

	private void changeSelectedObject(GameObject selected){
		selectedComponent.SendMessage("setDeselected");
		selectedComponent = selected;
		selectedComponent.SendMessage("setSelected");
	}

	private void displaySelectedComponent(){

	}
}

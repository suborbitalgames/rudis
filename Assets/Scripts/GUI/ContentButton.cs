using UnityEngine;
using System.Collections;

public class ContentButton : BaseMenuButton {

	public GameObject contentToDisplay;
	public bool isClose = false;


	// Use this for initialization
	public override void Start () {
		base.Start();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUp(){
		if(!isClose){
			if(contentToDisplay.activeSelf){
				contentToDisplay.SetActive(false);
			}
			else{
				contentToDisplay.SetActive(true);
				contentToDisplay.SendMessage("initialize");
			}
		}
		else{
			contentToDisplay.SetActive(false);
		}

	}
}

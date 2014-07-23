using UnityEngine;
using System.Collections;

public class MenuControl : MonoBehaviour {

	//Handles specific sub-menus and their buttons behaviour

	private ArrayList buttonArray;

	private Animator menuAnimator;

	void Awake(){
		buttonArray = new ArrayList();
	}

	// Use this for initialization
	void Start () {
		menuAnimator = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void registerButton(GameObject button){
		buttonArray.Add(button);
	}

	public void deactivateMenu(){
	
		foreach(GameObject go in buttonArray){
			//go.SendMessage("setInactive");
		}
		//menuAnimator.SetTrigger("deactivateMenu");
	}

	public void activateMenu(){
		foreach(GameObject go in buttonArray){
			//go.SendMessage("setActive");
		}
		//menuAnimator.SetTrigger("activateMenu");
	}
}

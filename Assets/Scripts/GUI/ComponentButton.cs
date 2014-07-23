using UnityEngine;
using System.Collections;

public class ComponentButton : BaseMenuButton {

	public GameObject menuRoot;
	private Animator menuAnimator;
	private MenuControl menuControl;

	public GameObject menuManager;
	public string menuToActivate;
	private MenuManager menuScript;

	private BoxCollider2D buttonCollider;
	private bool isActive = true;


	private bool mouseOver = false;

	// Use this for initialization
	public override void Start () {
		base.Start();
		menuAnimator = menuRoot.GetComponent<Animator>();
		buttonCollider = gameObject.GetComponent<BoxCollider2D>();
		menuControl = menuRoot.GetComponent<MenuControl>();
		menuControl.registerButton(gameObject);
		menuScript = menuManager.GetComponent<MenuManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void OnMouseUp(){
		menuScript.changeMenu(menuToActivate);
		transform.position = initialPosition;
	}

	void setInactive(){
		isActive = false;
		transform.position = initialPosition;
	}

	void setActive(){
		isActive = true;
	}
}

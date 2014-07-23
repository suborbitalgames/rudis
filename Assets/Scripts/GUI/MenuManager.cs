using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {

	public GameObject currentActiveMenu;

	public GameObject rootMenu;
	public GameObject gladiatorMenu;


	// Use this for initialization
	void Start () {
		rootMenu.SetActive(false);
		gladiatorMenu.SetActive(false);
		currentActiveMenu.SetActive(true);
	}

	void Update(){
		
	}
	
	public void changeMenu(string newMenuName){
		if(newMenuName.Equals("Gladiator")){
			//currentActiveMenu.SendMessage("deactivateMenu");
			currentActiveMenu.SetActive(false);
			currentActiveMenu = gladiatorMenu;
			currentActiveMenu.SetActive(true);
		}
		else if(newMenuName.Equals("Root")){
			//currentActiveMenu.SendMessage("deactivateMenu");
			currentActiveMenu.SetActive(false);
			currentActiveMenu = rootMenu;
			currentActiveMenu.SetActive(true);
		}
	}
}

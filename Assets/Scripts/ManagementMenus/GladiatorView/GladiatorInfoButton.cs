using UnityEngine;
using System.Collections;

public class GladiatorInfoButton : MonoBehaviour {

	public Sprite defaultSprite;
	public Sprite hoverSprite;
	public Sprite selectedSprite;
	public GameObject menuManager;
	public GameObject contentToDisplay;


	private SpriteRenderer buttonSprite;

	public bool isSelected = false;





	// Use this for initialization
	void Start () {
		buttonSprite = gameObject.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseEnter(){
		if(!isSelected){
			buttonSprite.sprite = hoverSprite;
		}
	}
	
	void OnMouseExit(){
		if(!isSelected){
			buttonSprite.sprite = defaultSprite;
		}
	}

	void OnMouseUp(){
		menuManager.SendMessage("changeSelectedObject", gameObject);
	}

	private void checkDefaultValues(){
		if(buttonSprite == null){
			buttonSprite = gameObject.GetComponent<SpriteRenderer>();
		}
	}

	public void setSelected(){
		checkDefaultValues();
		isSelected = true;
		buttonSprite.sprite = selectedSprite;

		contentToDisplay.SetActive(true);
		contentToDisplay.SendMessage("updateContent");
	}
	
	public void setDeselected(){
		checkDefaultValues();
		isSelected = false;
		buttonSprite.sprite = defaultSprite;
		contentToDisplay.SetActive(false);
	}
}

using UnityEngine;
using System.Collections;

public class GladiatorListEntry : MonoBehaviour {

	public GameObject nameObject;
	private TextMesh nameText;

	public GameObject classObject;
	private TextMesh classText;

	public GameObject ageObject;
	private TextMesh ageText;

	public GladiatorInfo info;

	public Sprite defaultSprite;
	public Sprite hoverSprite;
	public Sprite selectedSprite;
	
	private SpriteRenderer buttonSprite;
	private GameObject gladiatorList;

	private bool isSelected = false;


	// Use this for initialization
	void Start () {
		nameText = nameObject.GetComponent<TextMesh>();
		classText = classObject.GetComponent<TextMesh>();
		ageText = ageObject.GetComponent<TextMesh>();

		buttonSprite = gameObject.GetComponent<SpriteRenderer>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setInfo(GladiatorInfo gladInfo){
		info = gladInfo;
	}

	public void setText(){
		nameText = nameObject.GetComponent<TextMesh>();
		classText = classObject.GetComponent<TextMesh>();
		ageText = ageObject.GetComponent<TextMesh>();

		nameText.text = info.name.ToUpper();
		classText.text = "Class: " + info.gladiatorClass;
		ageText.text = "Age: " + info.age;
	}

	public void setGladiatorList(GameObject newGladiatorList){
		gladiatorList = newGladiatorList;
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
		gladiatorList.SendMessage("changeSelectedObject", gameObject);
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
	}

	public void setDeselected(){
		checkDefaultValues();
		isSelected = false;
		buttonSprite.sprite = defaultSprite;
	}
}

using UnityEngine;
using System.Collections;

public class GladiatorBioDisplay : GladiatorDisplayElement {

	public GameObject infoDisplay;
	private GladiatorInfoDisplay infoScript;

	public GameObject ageObject;
	private TextMesh ageText;

	public GameObject raceObject;
	private TextMesh raceText;

	public GameObject occupationObject;
	private TextMesh occupationText;

	public GameObject classObject;
	private TextMesh classText;

	// Use this for initialization
	void Start () {
		updateContent();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void updateContent(){

		setReferences();
		GladiatorInfo info = infoScript.info;
		ageText.text = info.age;
		raceText.text = info.race;
		occupationText.text = info.occupation;
		classText.text = info.gladiatorClass;
	}

	private void setReferences(){
		ageText = ageObject.GetComponent<TextMesh>();
		raceText = raceObject.GetComponent<TextMesh>();
		occupationText = occupationObject.GetComponent<TextMesh>();
		classText = classObject.GetComponent<TextMesh>();
		if(infoScript == null){
			infoScript = infoDisplay.GetComponent<GladiatorInfoDisplay>();
		}

	}

}

using UnityEngine;
using System.Collections;

public class GladiatorSkillsManager : MonoBehaviour {

	public GameObject strengthDisplay;
	public GameObject speedDisplay;
	public GameObject fortitudeDisplay;
	public GameObject staminaDisplay;
	public GameObject skillDisplay;

	public GameObject expDisplay;
	public GameObject happinessDisplay;
	public GameObject fameDisplay;

	private GladiatorInfo currentInfo;

	public GameObject infoDisplay;
	private GladiatorInfoDisplay infoScript;

	// Use this for initialization
	void Start () {
		setReferences();
		updateContent();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void updateContent(){
		setReferences();
		currentInfo = infoScript.info;
		updateSkills();
	}

	private void updateSkills(){
		strengthDisplay.SendMessage("setRatio", currentInfo.strength / 1000f);
		speedDisplay.SendMessage("setRatio", currentInfo.speed / 1000f);
		fortitudeDisplay.SendMessage("setRatio", currentInfo.fortitude / 1000f);
		staminaDisplay.SendMessage("setRatio", currentInfo.stamina / 1000f);
		skillDisplay.SendMessage("setRatio", currentInfo.skill / 1000f);
		expDisplay.SendMessage("setRatio", currentInfo.experience / 1000f);
		happinessDisplay.SendMessage("setRatio", currentInfo.happiness / 1000f);
		fameDisplay.SendMessage("setRatio", currentInfo.fame / 1000f);
	}

	private void setReferences(){
		if(infoScript == null){
			infoScript = infoDisplay.GetComponent<GladiatorInfoDisplay>();
		}
	}
}

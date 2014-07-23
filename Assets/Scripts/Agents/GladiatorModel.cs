using UnityEngine;
using System.Collections;

public class GladiatorModel : MonoBehaviour {
	public string gladiatorName;
	public string age;
	public string race;
	public string occupation;
	public string gladiatorClass = "";

	public int strength = 100;
	public int speed = 100;
	public int fortitude = 100;
	public int stamina = 100;
	public int skill = 100;
	
	public int experience = 50;
	public int happiness = 100;
	public int fame = 100;



	public GladiatorInfo info = null;


	//Temp, until proper instantiation is ready
	public bool addToData = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(addToData){
			if(info == null){
				info = new GladiatorInfo();
			}
			updateInfo();
			GameData.data.gladiators.Add(gladiatorName, this.GetComponent<GladiatorModel>());
			addToData = false;
		}
	}

	void addInfo(GladiatorInfo existingInfo){
		info = existingInfo;
	}

	void updateInfo(){
		info.name = gladiatorName;
		info.age = age;
		info.race = race;
		info.occupation = occupation;
		info.strength = strength;
		info.speed = speed;
		info.fortitude = fortitude;
		info.stamina = stamina;
		info.skill = skill;
		info.experience = experience;
		info.happiness = happiness;
		info.fame = fame;
		info.gladiatorClass = gladiatorClass;
	}
	
}

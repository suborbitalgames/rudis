using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

[Serializable]
public class GladiatorInfo {
	public string name;
	public string age;
	public string race;
	public string occupation;
	public string gladiatorClass = "";

	public int strength = 10;
	public int speed = 100;
	public int fortitude = 100;
	public int stamina = 100;
	public int skill = 100;

	public int experience = 25;
	public int happiness = 60;
	public int fame = 100;



	public GladiatorInfo(){

	}
}

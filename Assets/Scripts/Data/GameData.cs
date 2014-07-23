using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameData : MonoBehaviour {

	public static GameData data;

	public int year = 1;
	public int week = 1;

	public Dictionary<string, GladiatorModel> gladiators = new Dictionary<string, GladiatorModel>();
	public Dictionary<string, GladiatorInfo> tempGladiatorAddList = new Dictionary<string, GladiatorInfo>(); //Temp Solution for adding gladiators straight to file
	//Actually, there really isn't any reason to have the GladiatorModel class in here at all. Should probably change that.

	public List<GladiatorInfo> gladiatorInfoList = new List<GladiatorInfo>();

	private string dataFileName = "/gameData.dat";

	// Use this for initialization
	void Awake () {
		if(data == null){
			DontDestroyOnLoad(gameObject);
			data = this;
		}
		else if(data != this){
			Destroy(gameObject);
		}
		Debug.Log(Application.persistentDataPath + dataFileName);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Save(){


		Data currentData = new Data();
		currentData.year = year;
		currentData.week = week;
		currentData = saveGladiators(currentData);

		BinaryFormatter formatter = new BinaryFormatter();
		FileStream saveFile = File.Create(Application.persistentDataPath + dataFileName);
		formatter.Serialize(saveFile, currentData);
		saveFile.Close();
	}

	public void Load(){
		if(File.Exists(Application.persistentDataPath + dataFileName)){
			BinaryFormatter formatter = new BinaryFormatter();
			FileStream loadFile = File.Open(Application.persistentDataPath + dataFileName, FileMode.Open);
			Data loadedData = (Data) formatter.Deserialize(loadFile);
			loadGladiators(loadedData);
			loadFile.Close();
			year = loadedData.year;
			week = loadedData.week;
		}
	}

	private Data saveGladiators(Data currentData){
		//Temp, until proper path is in place
		BinaryFormatter formatter = new BinaryFormatter();
		if(File.Exists(Application.persistentDataPath + dataFileName)){
			FileStream loadFile = File.Open(Application.persistentDataPath + dataFileName, FileMode.Open);
			Data loadedData = (Data) formatter.Deserialize(loadFile);
			currentData.gladiators = loadedData.gladiators;
			loadFile.Close();
		}
		foreach(GladiatorModel gladiator in gladiators.Values){
			currentData.gladiators.Add(gladiator.info);
		}

		foreach(GladiatorInfo gladiator in tempGladiatorAddList.Values){
			currentData.gladiators.Add(gladiator);
		}

		return currentData;
	}

	private void loadGladiators(Data loadedData){
		gladiators = new Dictionary<string, GladiatorModel>();
		gladiatorInfoList = new List<GladiatorInfo>();
		gladiatorInfoList = loadedData.gladiators;
		Debug.Log("NUMBER OF GLADIATORS: " + gladiatorInfoList.Count);

		foreach(GladiatorInfo info in loadedData.gladiators){
			Debug.Log(info.name + " | " + info.gladiatorClass);

		}

	}


	[Serializable]
	class Data{
		public int year;
		public int week;

		public List<GladiatorInfo> gladiators = new List<GladiatorInfo>();
	}

}

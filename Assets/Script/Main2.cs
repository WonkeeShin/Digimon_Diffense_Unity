using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Bolt;

public class Main2 : MonoBehaviour
{
	private GameObject Digimon;
	public int Digi_NO;
	public string Digi_Name;
	public int Digi_HP;
	public int Digi_ATK;
	public int Digi_DF;
	public int Digi_Cost;
	public int Digi_Colli_NO;
	public float Digi_ATK_Speed;
	public int Digi_Retime;
	public float Digi_Speed;

	void Awake()
	{

		List<Dictionary<string, object>> data = CSVReader.Read("Digimon_Data");
		Digi_NO = (int)data[16]["Number"];
		Digi_Name = (string)data[16]["Name"];
		Digi_HP = (int)data[16]["HP"];
		Digi_ATK = (int)data[16]["ATK"];
		Digi_DF = (int)data[16]["DF"];
		Digi_Cost = (int)data[16]["Cost"];
		Digi_Colli_NO = (int)data[16]["Colli_No"];
		Digi_ATK_Speed = (int)data[16]["ATK_Speed"];
		Digi_Retime = (int)data[16]["ReTime"];
		Digi_Speed = (int)data[16]["Speed"];
		Digimon = GameObject.Find("Data_Loader");
		Variables.Object(Digimon).Set("Palmon", data[16]);

		Digi_NO = (int)data[12]["Number"];
		Digi_Name = (string)data[12]["Name"];
		Digi_HP = (int)data[12]["HP"];
		Digi_ATK = (int)data[12]["ATK"];
		Digi_DF = (int)data[12]["DF"];
		Digi_Cost = (int)data[12]["Cost"];
		Digi_Colli_NO = (int)data[12]["Colli_No"];
		Digi_ATK_Speed = (int)data[12]["ATK_Speed"];
		Digi_Retime = (int)data[12]["ReTime"];
		Digi_Speed = (int)data[12]["Speed"];
		Digimon = GameObject.Find("Data_Loader");
		Variables.Object(Digimon).Set("Tokomon", data[12]);


	}

	// Use this for initialization
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{

	}
}
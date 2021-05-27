using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Bolt;

public class Main : MonoBehaviour
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
		Digi_NO = (int)data[0]["Number"];
		Digi_Name = (string)data[0]["Name"];
		Digi_HP = (int)data[0]["HP"];
		Digi_ATK = (int)data[0]["ATK"];
		Digi_DF = (int)data[0]["DF"];
		Digi_Cost = (int)data[0]["Cost"];
		Digi_Colli_NO = (int)data[0]["Colli_No"];
		Digi_ATK_Speed = (int)data[0]["ATK_Speed"];
		Digi_Retime = (int)data[0]["ReTime"];
		Digi_Speed = (int)data[0]["Speed"];
		Digimon = GameObject.Find("Botamon");
		Variables.Object(Digimon).Set("basic_data", data[0]);


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
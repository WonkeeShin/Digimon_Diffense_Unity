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
	private List<string> list = new List<string>();

	void Awake()
	{

		List<Dictionary<string, object>> data = CSVReader.Read("Digimon_Data");

		list.Add("Botamon");
		list.Add("Bubbmon");
		list.Add("Nyokimon");
		list.Add("Yuramon");
		list.Add("Punimon");
		list.Add("Pichimon");
		list.Add("Yukibotamon");
		list.Add("Koromon");
		list.Add("Mochimon");
		list.Add("Tunomon");
		list.Add("Tanemon");
		list.Add("Nyaromon");
		list.Add("Pyocomon");
		list.Add("Tokomon");
		list.Add("Agumon");
		list.Add("Gabumon");
		list.Add("Patamon");
		list.Add("Palmon");
		
		for(int i = 0; i < 18; i++)
        {
			Digi_NO = (int)data[i]["Number"];
			Digi_Name = (string)data[i]["Name"];
			Digi_HP = (int)data[i]["HP"];
			Digi_ATK = (int)data[i]["ATK"];
			Digi_DF = (int)data[i]["DF"];
			Digi_Cost = (int)data[i]["Cost"];
			Digi_Colli_NO = (int)data[i]["Colli_No"];
			Digi_ATK_Speed = (int)data[i]["ATK_Speed"];
			Digi_Retime = (int)data[i]["ReTime"];
			Digi_Speed = (int)data[i]["Speed"];
			Digimon = GameObject.Find("Data_Loader");
			Variables.Object(Digimon).Set(list[i] , data[i]);
		}


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
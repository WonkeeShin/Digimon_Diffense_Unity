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
	public int Digi_Skill;
	public string Digi_Tag;
	public int Digi_Technique;
	public int Digi_Target;
	private List<string> list = new List<string>();

	void Awake()
	{
		Digimon = GameObject.FindWithTag("Data_Loader");

		List<Dictionary<string, object>> data = CSVReader.Read("Digimon_Data");

		list.Add("Botamon");
		list.Add("Punimon");
		list.Add("Nyokimon");
		list.Add("Bubbmon");
		list.Add("Yuramon");
		list.Add("Pichimon");
		list.Add("Poyomon");
		list.Add("Yukibotamon");
		list.Add("Kuramon");
		list.Add("Koromon");
		list.Add("Tunomon");
		list.Add("Pyocomon");
		list.Add("Mochimon");
		list.Add("Tanemon");
		list.Add("Pukamon");
		list.Add("Tokomon");
		list.Add("Nyaromon");
		list.Add("Agumon");
		list.Add("Gabumon");
		list.Add("Piyomon");
		list.Add("Tentomon");
		list.Add("Palmon");
		list.Add("Gomamon");
		list.Add("Patamon");
		list.Add("Plotmon");



		for (int i = 0; i < 25; i++)
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
			Digi_Skill = (int)data[i]["Skill"];
			Digi_Tag = (string)data[i]["Tag"];
			Digi_Technique = (int)data[i]["Technique"];
			Digi_Target = (int)data[i]["Target"];

			Variables.Object(Digimon).Set(list[i], data[i]);
		}


	}
}
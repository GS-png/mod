using UnityEngine;
using UnityEngine.UI;

public class UiPanelInfo : MonoBehaviour
{
	public GameObject population;

	public GameObject beasts;

	public GameObject deaths;

	public GameObject infected;

	public GameObject buildings;

	public GameObject vegetations;

	private float interval = 0.2f;

	private float timer;

	private Text population_name;

	private Text population_value;

	private Text beasts_name;

	private Text beasts_value;

	private Text deaths_name;

	private Text deaths_value;

	private Text infected_name;

	private Text infected_value;

	private Text buildings_name;

	private Text buildings_value;

	private Text vegetation_name;

	private Text vegetation_value;

	private bool lastRTL;

	private void OnEnable()
	{
		population_name = population.transform.Find("Name").GetComponent<Text>();
		population_value = population.transform.Find("Value").GetComponent<Text>();
		beasts_name = beasts.transform.Find("Name").GetComponent<Text>();
		beasts_value = beasts.transform.Find("Value").GetComponent<Text>();
		infected_name = infected.transform.Find("Name").GetComponent<Text>();
		infected_value = infected.transform.Find("Value").GetComponent<Text>();
		deaths_name = deaths.transform.Find("Name").GetComponent<Text>();
		deaths_value = deaths.transform.Find("Value").GetComponent<Text>();
		buildings_name = buildings.transform.Find("Name").GetComponent<Text>();
		buildings_value = buildings.transform.Find("Value").GetComponent<Text>();
		vegetation_name = vegetations.transform.Find("Name").GetComponent<Text>();
		vegetation_value = vegetations.transform.Find("Value").GetComponent<Text>();
	}

	private void Update()
	{
		if (!Config.game_loaded || World.world == null || World.world.map_stats == null || World.world.game_stats == null)
		{
			return;
		}
		if (timer > 0f)
		{
			timer -= Time.deltaTime;
			return;
		}
		timer = interval;
		if (LocalizedTextManager.current_language.isRTL() != lastRTL)
		{
			lastRTL = LocalizedTextManager.current_language.isRTL();
			if (lastRTL)
			{
				population_value.alignment = TextAnchor.MiddleLeft;
				beasts_value.alignment = TextAnchor.MiddleLeft;
				infected_value.alignment = TextAnchor.MiddleLeft;
				deaths_value.alignment = TextAnchor.MiddleLeft;
				buildings_value.alignment = TextAnchor.MiddleLeft;
				vegetation_value.alignment = TextAnchor.MiddleLeft;
				population_name.alignment = TextAnchor.MiddleRight;
				beasts_name.alignment = TextAnchor.MiddleRight;
				infected_name.alignment = TextAnchor.MiddleRight;
				deaths_name.alignment = TextAnchor.MiddleRight;
				buildings_name.alignment = TextAnchor.MiddleRight;
				vegetation_name.alignment = TextAnchor.MiddleRight;
			}
			else
			{
				population_value.alignment = TextAnchor.MiddleRight;
				beasts_value.alignment = TextAnchor.MiddleRight;
				infected_value.alignment = TextAnchor.MiddleRight;
				deaths_value.alignment = TextAnchor.MiddleRight;
				buildings_value.alignment = TextAnchor.MiddleRight;
				vegetation_value.alignment = TextAnchor.MiddleRight;
				population_name.alignment = TextAnchor.MiddleLeft;
				beasts_name.alignment = TextAnchor.MiddleLeft;
				infected_name.alignment = TextAnchor.MiddleLeft;
				deaths_name.alignment = TextAnchor.MiddleLeft;
				buildings_name.alignment = TextAnchor.MiddleLeft;
				vegetation_name.alignment = TextAnchor.MiddleLeft;
			}
		}
		population_value.text = World.world.getCivWorldPopulation().ToString() ?? "";
		beasts_value.text = World.world.map_stats.current_mobs.ToString() ?? "";
		infected_value.text = World.world.map_stats.current_infected.ToString() ?? "";
		deaths_value.text = World.world.map_stats.deaths.ToString() ?? "";
		buildings_value.text = World.world.map_stats.current_houses.ToString() ?? "";
		vegetation_value.text = World.world.map_stats.current_vegetation.ToString() ?? "";
		population_value.GetComponent<LocalizedText>().checkSpecialLanguages();
		beasts_value.GetComponent<LocalizedText>().checkSpecialLanguages();
		infected_value.GetComponent<LocalizedText>().checkSpecialLanguages();
		deaths_value.GetComponent<LocalizedText>().checkSpecialLanguages();
		buildings_value.GetComponent<LocalizedText>().checkSpecialLanguages();
		vegetation_value.GetComponent<LocalizedText>().checkSpecialLanguages();
	}
}

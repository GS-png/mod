using System;
using System.Collections.Generic;
using System.Reflection;
using db.tables;

namespace db;

public class HistoryMetaDataLibrary : AssetLibrary<HistoryMetaDataAsset>
{
	public static readonly Dictionary<MetaType, HistoryMetaDataAsset[]> _meta_data = new Dictionary<MetaType, HistoryMetaDataAsset[]>();

	public static readonly Dictionary<string, HistoryMetaDataAsset[]> _meta_dict = new Dictionary<string, HistoryMetaDataAsset[]>();

	public override void init()
	{
		base.init();
		add(new HistoryMetaDataAsset
		{
			id = "world",
			meta_type = MetaType.World,
			table_type = typeof(WorldTable),
			table_types = new Dictionary<HistoryInterval, Type>
			{
				{
					HistoryInterval.Yearly1,
					typeof(WorldYearly1)
				},
				{
					HistoryInterval.Yearly5,
					typeof(WorldYearly5)
				},
				{
					HistoryInterval.Yearly10,
					typeof(WorldYearly10)
				},
				{
					HistoryInterval.Yearly50,
					typeof(WorldYearly50)
				},
				{
					HistoryInterval.Yearly100,
					typeof(WorldYearly100)
				},
				{
					HistoryInterval.Yearly500,
					typeof(WorldYearly500)
				},
				{
					HistoryInterval.Yearly1000,
					typeof(WorldYearly1000)
				},
				{
					HistoryInterval.Yearly5000,
					typeof(WorldYearly5000)
				},
				{
					HistoryInterval.Yearly10000,
					typeof(WorldYearly10000)
				}
			}
		});
		t.collector = (NanoObject _) => new WorldYearly1
		{
			id = 1L,
			alliances = StatsHelper.getStat("alliances"),
			alliances_dissolved = StatsHelper.getStat("world_statistics_alliances_dissolved"),
			alliances_made = StatsHelper.getStat("world_statistics_alliances_made"),
			books = StatsHelper.getStat("books"),
			books_burnt = StatsHelper.getStat("world_statistics_books_burnt"),
			books_read = StatsHelper.getStat("world_statistics_books_read"),
			books_written = StatsHelper.getStat("world_statistics_books_written"),
			cities = StatsHelper.getStat("villages"),
			cities_rebelled = StatsHelper.getStat("world_statistics_cities_rebelled"),
			cities_conquered = StatsHelper.getStat("world_statistics_cities_conquered"),
			cities_created = StatsHelper.getStat("world_statistics_cities_created"),
			cities_destroyed = StatsHelper.getStat("world_statistics_cities_destroyed"),
			clans = StatsHelper.getStat("clans"),
			clans_created = StatsHelper.getStat("world_statistics_clans_created"),
			clans_destroyed = StatsHelper.getStat("world_statistics_clans_destroyed"),
			creatures_born = StatsHelper.getStat("world_statistics_creatures_born"),
			creatures_created = StatsHelper.getStat("world_statistics_creatures_created"),
			cultures = StatsHelper.getStat("cultures"),
			cultures_created = StatsHelper.getStat("world_statistics_cultures_created"),
			cultures_forgotten = StatsHelper.getStat("world_statistics_cultures_forgotten"),
			deaths_eaten = StatsHelper.getStat("world_statistics_deaths_eaten"),
			deaths_hunger = StatsHelper.getStat("world_statistics_deaths_hunger"),
			deaths_natural = StatsHelper.getStat("world_statistics_deaths_natural"),
			deaths_poison = StatsHelper.getStat("world_statistics_deaths_poison"),
			deaths_infection = StatsHelper.getStat("world_statistics_deaths_infection"),
			deaths_tumor = StatsHelper.getStat("world_statistics_deaths_tumor"),
			deaths_acid = StatsHelper.getStat("world_statistics_deaths_acid"),
			deaths_fire = StatsHelper.getStat("world_statistics_deaths_fire"),
			deaths_divine = StatsHelper.getStat("world_statistics_deaths_divine"),
			deaths_weapon = StatsHelper.getStat("world_statistics_deaths_weapon"),
			deaths_gravity = StatsHelper.getStat("world_statistics_deaths_gravity"),
			deaths_drowning = StatsHelper.getStat("world_statistics_deaths_drowning"),
			deaths_water = StatsHelper.getStat("world_statistics_deaths_water"),
			deaths_explosion = StatsHelper.getStat("world_statistics_deaths_explosion"),
			metamorphosis = StatsHelper.getStat("world_statistics_metamorphosis"),
			evolutions = StatsHelper.getStat("world_statistics_evolutions"),
			deaths_other = StatsHelper.getStat("world_statistics_deaths_other"),
			deaths_plague = StatsHelper.getStat("world_statistics_deaths_plague"),
			deaths_total = StatsHelper.getStat("world_statistics_deaths_total"),
			families = StatsHelper.getStat("families"),
			families_created = StatsHelper.getStat("world_statistics_families_created"),
			families_destroyed = StatsHelper.getStat("world_statistics_families_destroyed"),
			houses = StatsHelper.getStat("world_statistics_houses"),
			houses_built = StatsHelper.getStat("world_statistics_houses_built"),
			houses_destroyed = StatsHelper.getStat("world_statistics_houses_destroyed"),
			infected = StatsHelper.getStat("world_statistics_infected"),
			islands = StatsHelper.getStat("world_statistics_islands"),
			kingdoms = StatsHelper.getStat("kingdoms"),
			kingdoms_created = StatsHelper.getStat("world_statistics_kingdoms_created"),
			kingdoms_destroyed = StatsHelper.getStat("world_statistics_kingdoms_destroyed"),
			languages = StatsHelper.getStat("languages"),
			languages_created = StatsHelper.getStat("world_statistics_languages_created"),
			languages_forgotten = StatsHelper.getStat("world_statistics_languages_forgotten"),
			peaces_made = StatsHelper.getStat("world_statistics_peaces_made"),
			plots = StatsHelper.getStat("plots"),
			plots_forgotten = StatsHelper.getStat("world_statistics_plots_forgotten"),
			plots_started = StatsHelper.getStat("world_statistics_plots_started"),
			plots_succeeded = StatsHelper.getStat("world_statistics_plots_succeeded"),
			population_beasts = StatsHelper.getStat("world_statistics_beasts"),
			population_civ = StatsHelper.getStat("world_statistics_population"),
			religions = StatsHelper.getStat("religions"),
			religions_created = StatsHelper.getStat("world_statistics_religions_created"),
			religions_forgotten = StatsHelper.getStat("world_statistics_religions_forgotten"),
			subspecies = StatsHelper.getStat("subspecies"),
			subspecies_created = StatsHelper.getStat("world_statistics_subspecies_created"),
			subspecies_extinct = StatsHelper.getStat("world_statistics_subspecies_extinct"),
			trees = StatsHelper.getStat("world_statistics_trees"),
			vegetation = StatsHelper.getStat("world_statistics_vegetation"),
			wars = StatsHelper.getStat("wars"),
			wars_started = StatsHelper.getStat("world_statistics_wars_started"),
			grass = StatsHelper.getStat("world_statistics_grass"),
			savanna = StatsHelper.getStat("world_statistics_savanna"),
			jungle = StatsHelper.getStat("world_statistics_jungle"),
			desert = StatsHelper.getStat("world_statistics_desert"),
			lemon = StatsHelper.getStat("world_statistics_lemon"),
			permafrost = StatsHelper.getStat("world_statistics_permafrost"),
			swamp = StatsHelper.getStat("world_statistics_swamp"),
			crystal = StatsHelper.getStat("world_statistics_crystal"),
			enchanted = StatsHelper.getStat("world_statistics_enchanted"),
			corruption = StatsHelper.getStat("world_statistics_corruption"),
			infernal = StatsHelper.getStat("world_statistics_infernal"),
			candy = StatsHelper.getStat("world_statistics_candy"),
			mushroom = StatsHelper.getStat("world_statistics_mushroom"),
			wasteland = StatsHelper.getStat("world_statistics_wasteland"),
			birch = StatsHelper.getStat("world_statistics_birch"),
			maple = StatsHelper.getStat("world_statistics_maple"),
			rocklands = StatsHelper.getStat("world_statistics_rocklands"),
			garlic = StatsHelper.getStat("world_statistics_garlic"),
			flower = StatsHelper.getStat("world_statistics_flower"),
			celestial = StatsHelper.getStat("world_statistics_celestial"),
			clover = StatsHelper.getStat("world_statistics_clover"),
			singularity = StatsHelper.getStat("world_statistics_singularity"),
			paradox = StatsHelper.getStat("world_statistics_paradox"),
			sand = StatsHelper.getStat("world_statistics_sand"),
			biomass = StatsHelper.getStat("world_statistics_biomass"),
			cybertile = StatsHelper.getStat("world_statistics_cybertile"),
			pumpkin = StatsHelper.getStat("world_statistics_pumpkin"),
			tumor = StatsHelper.getStat("world_statistics_tumor"),
			water = StatsHelper.getStat("world_statistics_water"),
			soil = StatsHelper.getStat("world_statistics_soil"),
			summit = StatsHelper.getStat("world_statistics_summit"),
			mountains = StatsHelper.getStat("world_statistics_mountains"),
			hills = StatsHelper.getStat("world_statistics_hills"),
			lava = StatsHelper.getStat("world_statistics_lava"),
			pit = StatsHelper.getStat("world_statistics_pit"),
			field = StatsHelper.getStat("world_statistics_field"),
			fireworks = StatsHelper.getStat("world_statistics_fireworks"),
			frozen = StatsHelper.getStat("world_statistics_frozen"),
			fuse = StatsHelper.getStat("world_statistics_fuse"),
			ice = StatsHelper.getStat("world_statistics_ice"),
			landmine = StatsHelper.getStat("world_statistics_landmine"),
			road = StatsHelper.getStat("world_statistics_road"),
			snow = StatsHelper.getStat("world_statistics_snow"),
			tnt = StatsHelper.getStat("world_statistics_tnt"),
			wall = StatsHelper.getStat("world_statistics_wall"),
			water_bomb = StatsHelper.getStat("world_statistics_water_bomb"),
			grey_goo = StatsHelper.getStat("world_statistics_grey_goo")
		};
		add(new HistoryMetaDataAsset
		{
			id = "alliance",
			meta_type = MetaType.Alliance,
			table_type = typeof(AllianceTable),
			table_types = new Dictionary<HistoryInterval, Type>
			{
				{
					HistoryInterval.Yearly1,
					typeof(AllianceYearly1)
				},
				{
					HistoryInterval.Yearly5,
					typeof(AllianceYearly5)
				},
				{
					HistoryInterval.Yearly10,
					typeof(AllianceYearly10)
				},
				{
					HistoryInterval.Yearly50,
					typeof(AllianceYearly50)
				},
				{
					HistoryInterval.Yearly100,
					typeof(AllianceYearly100)
				},
				{
					HistoryInterval.Yearly500,
					typeof(AllianceYearly500)
				},
				{
					HistoryInterval.Yearly1000,
					typeof(AllianceYearly1000)
				},
				{
					HistoryInterval.Yearly5000,
					typeof(AllianceYearly5000)
				},
				{
					HistoryInterval.Yearly10000,
					typeof(AllianceYearly10000)
				}
			}
		});
		t.collector = delegate(NanoObject pNanoObject)
		{
			Alliance alliance = (Alliance)pNanoObject;
			return new AllianceYearly1
			{
				id = alliance.getID(),
				population = alliance.countPopulation(),
				adults = alliance.countAdults(),
				children = alliance.countChildren(),
				army = alliance.countWarriors(),
				sick = alliance.countSick(),
				hungry = alliance.countHungry(),
				starving = alliance.countStarving(),
				happy = alliance.countHappyUnits(),
				deaths = alliance.getTotalDeaths(),
				kills = alliance.getTotalKills(),
				births = alliance.getTotalBirths(),
				territory = alliance.countZones(),
				buildings = alliance.countBuildings(),
				homeless = alliance.countHomeless(),
				housed = alliance.countHoused(),
				families = alliance.countFamilies(),
				males = alliance.countMales(),
				females = alliance.countFemales(),
				kingdoms = alliance.countKingdoms(),
				cities = alliance.countCities(),
				renown = alliance.getRenown(),
				money = alliance.countTotalMoney()
			};
		};
		add(new HistoryMetaDataAsset
		{
			id = "clan",
			meta_type = MetaType.Clan,
			table_type = typeof(ClanTable),
			table_types = new Dictionary<HistoryInterval, Type>
			{
				{
					HistoryInterval.Yearly1,
					typeof(ClanYearly1)
				},
				{
					HistoryInterval.Yearly5,
					typeof(ClanYearly5)
				},
				{
					HistoryInterval.Yearly10,
					typeof(ClanYearly10)
				},
				{
					HistoryInterval.Yearly50,
					typeof(ClanYearly50)
				},
				{
					HistoryInterval.Yearly100,
					typeof(ClanYearly100)
				},
				{
					HistoryInterval.Yearly500,
					typeof(ClanYearly500)
				},
				{
					HistoryInterval.Yearly1000,
					typeof(ClanYearly1000)
				},
				{
					HistoryInterval.Yearly5000,
					typeof(ClanYearly5000)
				},
				{
					HistoryInterval.Yearly10000,
					typeof(ClanYearly10000)
				}
			}
		});
		t.collector = delegate(NanoObject pNanoObject)
		{
			Clan clan = (Clan)pNanoObject;
			return new ClanYearly1
			{
				id = clan.getID(),
				population = clan.countUnits(),
				adults = clan.countAdults(),
				children = clan.countChildren(),
				births = clan.getTotalBirths(),
				deaths = clan.getTotalDeaths(),
				kills = clan.getTotalKills(),
				kings = clan.countKings(),
				leaders = clan.countLeaders(),
				renown = clan.getRenown(),
				money = clan.countTotalMoney(),
				deaths_eaten = clan.getDeaths(AttackType.Eaten),
				deaths_hunger = clan.getDeaths(AttackType.Starvation),
				deaths_natural = clan.getDeaths(AttackType.Age),
				deaths_plague = clan.getDeaths(AttackType.Plague),
				deaths_poison = clan.getDeaths(AttackType.Poison),
				deaths_infection = clan.getDeaths(AttackType.Infection),
				deaths_tumor = clan.getDeaths(AttackType.Tumor),
				deaths_acid = clan.getDeaths(AttackType.Acid),
				deaths_fire = clan.getDeaths(AttackType.Fire),
				deaths_divine = clan.getDeaths(AttackType.Divine),
				deaths_weapon = clan.getDeaths(AttackType.Weapon),
				deaths_gravity = clan.getDeaths(AttackType.Gravity),
				deaths_drowning = clan.getDeaths(AttackType.Drowning),
				deaths_water = clan.getDeaths(AttackType.Water),
				deaths_explosion = clan.getDeaths(AttackType.Explosion),
				deaths_other = clan.getDeaths(AttackType.Other),
				metamorphosis = clan.getDeaths(AttackType.Metamorphosis),
				evolutions = clan.getEvolutions()
			};
		};
		add(new HistoryMetaDataAsset
		{
			id = "city",
			meta_type = MetaType.City,
			table_type = typeof(CityTable),
			table_types = new Dictionary<HistoryInterval, Type>
			{
				{
					HistoryInterval.Yearly1,
					typeof(CityYearly1)
				},
				{
					HistoryInterval.Yearly5,
					typeof(CityYearly5)
				},
				{
					HistoryInterval.Yearly10,
					typeof(CityYearly10)
				},
				{
					HistoryInterval.Yearly50,
					typeof(CityYearly50)
				},
				{
					HistoryInterval.Yearly100,
					typeof(CityYearly100)
				},
				{
					HistoryInterval.Yearly500,
					typeof(CityYearly500)
				},
				{
					HistoryInterval.Yearly1000,
					typeof(CityYearly1000)
				},
				{
					HistoryInterval.Yearly5000,
					typeof(CityYearly5000)
				},
				{
					HistoryInterval.Yearly10000,
					typeof(CityYearly10000)
				}
			}
		});
		t.collector = delegate(NanoObject pNanoObject)
		{
			City city = (City)pNanoObject;
			return new CityYearly1
			{
				id = city.getID(),
				population = city.countUnits(),
				adults = city.countAdults(),
				children = city.countChildren(),
				boats = city.countBoats(),
				army = city.countWarriors(),
				families = city.countFamilies(),
				males = city.countMales(),
				females = city.countFemales(),
				sick = city.countSick(),
				loyalty = city.getCachedLoyalty(),
				hungry = city.countHungry(),
				starving = city.countStarving(),
				happy = city.countHappyUnits(),
				deaths = city.getTotalDeaths(),
				births = city.getTotalBirths(),
				joined = city.getTotalJoined(),
				left = city.getTotalLeft(),
				moved = city.getTotalMoved(),
				migrated = city.getTotalMigrated(),
				territory = city.countZones(),
				buildings = city.countBuildings(),
				homeless = city.countHomeless(),
				housed = city.countHoused(),
				renown = city.getRenown(),
				money = city.countTotalMoney(),
				food = city.getTotalFood(),
				gold = city.getResourcesAmount("gold"),
				wood = city.getResourcesAmount("wood"),
				stone = city.getResourcesAmount("stone"),
				common_metals = city.getResourcesAmount("common_metals"),
				items = city.data.equipment.countItems(),
				deaths_eaten = city.getDeaths(AttackType.Eaten),
				deaths_hunger = city.getDeaths(AttackType.Starvation),
				deaths_natural = city.getDeaths(AttackType.Age),
				deaths_plague = city.getDeaths(AttackType.Plague),
				deaths_poison = city.getDeaths(AttackType.Poison),
				deaths_infection = city.getDeaths(AttackType.Infection),
				deaths_tumor = city.getDeaths(AttackType.Tumor),
				deaths_acid = city.getDeaths(AttackType.Acid),
				deaths_fire = city.getDeaths(AttackType.Fire),
				deaths_divine = city.getDeaths(AttackType.Divine),
				deaths_weapon = city.getDeaths(AttackType.Weapon),
				deaths_gravity = city.getDeaths(AttackType.Gravity),
				deaths_drowning = city.getDeaths(AttackType.Drowning),
				deaths_water = city.getDeaths(AttackType.Water),
				deaths_explosion = city.getDeaths(AttackType.Explosion),
				deaths_other = city.getDeaths(AttackType.Other),
				metamorphosis = city.getDeaths(AttackType.Metamorphosis),
				evolutions = city.getEvolutions()
			};
		};
		add(new HistoryMetaDataAsset
		{
			id = "culture",
			meta_type = MetaType.Culture,
			table_type = typeof(CultureTable),
			table_types = new Dictionary<HistoryInterval, Type>
			{
				{
					HistoryInterval.Yearly1,
					typeof(CultureYearly1)
				},
				{
					HistoryInterval.Yearly5,
					typeof(CultureYearly5)
				},
				{
					HistoryInterval.Yearly10,
					typeof(CultureYearly10)
				},
				{
					HistoryInterval.Yearly50,
					typeof(CultureYearly50)
				},
				{
					HistoryInterval.Yearly100,
					typeof(CultureYearly100)
				},
				{
					HistoryInterval.Yearly500,
					typeof(CultureYearly500)
				},
				{
					HistoryInterval.Yearly1000,
					typeof(CultureYearly1000)
				},
				{
					HistoryInterval.Yearly5000,
					typeof(CultureYearly5000)
				},
				{
					HistoryInterval.Yearly10000,
					typeof(CultureYearly10000)
				}
			}
		});
		t.collector = delegate(NanoObject pNanoObject)
		{
			Culture culture = (Culture)pNanoObject;
			return new CultureYearly1
			{
				id = culture.getID(),
				population = culture.countUnits(),
				cities = culture.countCities(),
				kingdoms = culture.countKingdoms(),
				births = culture.getTotalBirths(),
				deaths = culture.getTotalDeaths(),
				kills = culture.getTotalKills(),
				adults = culture.countAdults(),
				children = culture.countChildren(),
				kings = culture.countKings(),
				leaders = culture.countLeaders(),
				renown = culture.getRenown(),
				money = culture.countTotalMoney()
			};
		};
		add(new HistoryMetaDataAsset
		{
			id = "family",
			meta_type = MetaType.Family,
			table_type = typeof(FamilyTable),
			table_types = new Dictionary<HistoryInterval, Type>
			{
				{
					HistoryInterval.Yearly1,
					typeof(FamilyYearly1)
				},
				{
					HistoryInterval.Yearly5,
					typeof(FamilyYearly5)
				},
				{
					HistoryInterval.Yearly10,
					typeof(FamilyYearly10)
				},
				{
					HistoryInterval.Yearly50,
					typeof(FamilyYearly50)
				},
				{
					HistoryInterval.Yearly100,
					typeof(FamilyYearly100)
				},
				{
					HistoryInterval.Yearly500,
					typeof(FamilyYearly500)
				},
				{
					HistoryInterval.Yearly1000,
					typeof(FamilyYearly1000)
				},
				{
					HistoryInterval.Yearly5000,
					typeof(FamilyYearly5000)
				},
				{
					HistoryInterval.Yearly10000,
					typeof(FamilyYearly10000)
				}
			}
		});
		t.collector = delegate(NanoObject pNanoObject)
		{
			Family family = (Family)pNanoObject;
			return new FamilyYearly1
			{
				id = family.getID(),
				population = family.countUnits(),
				adults = family.countAdults(),
				children = family.countChildren(),
				births = family.getTotalBirths(),
				deaths = family.getTotalDeaths(),
				kills = family.getTotalKills(),
				money = family.countTotalMoney()
			};
		};
		add(new HistoryMetaDataAsset
		{
			id = "army",
			meta_type = MetaType.Army,
			table_type = typeof(ArmyTable),
			table_types = new Dictionary<HistoryInterval, Type>
			{
				{
					HistoryInterval.Yearly1,
					typeof(ArmyYearly1)
				},
				{
					HistoryInterval.Yearly5,
					typeof(ArmyYearly5)
				},
				{
					HistoryInterval.Yearly10,
					typeof(ArmyYearly10)
				},
				{
					HistoryInterval.Yearly50,
					typeof(ArmyYearly50)
				},
				{
					HistoryInterval.Yearly100,
					typeof(ArmyYearly100)
				},
				{
					HistoryInterval.Yearly500,
					typeof(ArmyYearly500)
				},
				{
					HistoryInterval.Yearly1000,
					typeof(ArmyYearly1000)
				},
				{
					HistoryInterval.Yearly5000,
					typeof(ArmyYearly5000)
				},
				{
					HistoryInterval.Yearly10000,
					typeof(ArmyYearly10000)
				}
			}
		});
		t.collector = delegate(NanoObject pNanoObject)
		{
			Army army = (Army)pNanoObject;
			return new ArmyYearly1
			{
				id = army.getID(),
				population = army.countUnits(),
				deaths = army.getTotalDeaths(),
				kills = army.getTotalKills()
			};
		};
		add(new HistoryMetaDataAsset
		{
			id = "kingdom",
			meta_type = MetaType.Kingdom,
			table_type = typeof(KingdomTable),
			table_types = new Dictionary<HistoryInterval, Type>
			{
				{
					HistoryInterval.Yearly1,
					typeof(KingdomYearly1)
				},
				{
					HistoryInterval.Yearly5,
					typeof(KingdomYearly5)
				},
				{
					HistoryInterval.Yearly10,
					typeof(KingdomYearly10)
				},
				{
					HistoryInterval.Yearly50,
					typeof(KingdomYearly50)
				},
				{
					HistoryInterval.Yearly100,
					typeof(KingdomYearly100)
				},
				{
					HistoryInterval.Yearly500,
					typeof(KingdomYearly500)
				},
				{
					HistoryInterval.Yearly1000,
					typeof(KingdomYearly1000)
				},
				{
					HistoryInterval.Yearly5000,
					typeof(KingdomYearly5000)
				},
				{
					HistoryInterval.Yearly10000,
					typeof(KingdomYearly10000)
				}
			}
		});
		t.collector = delegate(NanoObject pNanoObject)
		{
			Kingdom kingdom = (Kingdom)pNanoObject;
			return new KingdomYearly1
			{
				id = kingdom.getID(),
				population = kingdom.countUnits(),
				adults = kingdom.countAdults(),
				children = kingdom.countChildren(),
				boats = kingdom.countBoats(),
				army = kingdom.countTotalWarriors(),
				sick = kingdom.countSick(),
				hungry = kingdom.countHungry(),
				starving = kingdom.countStarving(),
				happy = kingdom.countHappyUnits(),
				deaths = kingdom.getTotalDeaths(),
				births = kingdom.getTotalBirths(),
				kills = kingdom.getTotalKills(),
				joined = kingdom.getTotalJoined(),
				left = kingdom.getTotalLeft(),
				moved = kingdom.getTotalMoved(),
				migrated = kingdom.getTotalMigrated(),
				territory = kingdom.countZones(),
				buildings = kingdom.countBuildings(),
				homeless = kingdom.countHomeless(),
				housed = kingdom.countHoused(),
				food = kingdom.countTotalFood(),
				families = kingdom.countFamilies(),
				males = kingdom.countMales(),
				females = kingdom.countFemales(),
				cities = kingdom.countCities(),
				renown = kingdom.getRenown(),
				money = kingdom.countTotalMoney(),
				deaths_eaten = kingdom.getDeaths(AttackType.Eaten),
				deaths_hunger = kingdom.getDeaths(AttackType.Starvation),
				deaths_natural = kingdom.getDeaths(AttackType.Age),
				deaths_plague = kingdom.getDeaths(AttackType.Plague),
				deaths_poison = kingdom.getDeaths(AttackType.Poison),
				deaths_infection = kingdom.getDeaths(AttackType.Infection),
				deaths_tumor = kingdom.getDeaths(AttackType.Tumor),
				deaths_acid = kingdom.getDeaths(AttackType.Acid),
				deaths_fire = kingdom.getDeaths(AttackType.Fire),
				deaths_divine = kingdom.getDeaths(AttackType.Divine),
				deaths_weapon = kingdom.getDeaths(AttackType.Weapon),
				deaths_gravity = kingdom.getDeaths(AttackType.Gravity),
				deaths_drowning = kingdom.getDeaths(AttackType.Drowning),
				deaths_water = kingdom.getDeaths(AttackType.Water),
				deaths_explosion = kingdom.getDeaths(AttackType.Explosion),
				deaths_other = kingdom.getDeaths(AttackType.Other),
				metamorphosis = kingdom.getDeaths(AttackType.Metamorphosis),
				evolutions = kingdom.getEvolutions()
			};
		};
		add(new HistoryMetaDataAsset
		{
			id = "language",
			meta_type = MetaType.Language,
			table_type = typeof(LanguageTable),
			table_types = new Dictionary<HistoryInterval, Type>
			{
				{
					HistoryInterval.Yearly1,
					typeof(LanguageYearly1)
				},
				{
					HistoryInterval.Yearly5,
					typeof(LanguageYearly5)
				},
				{
					HistoryInterval.Yearly10,
					typeof(LanguageYearly10)
				},
				{
					HistoryInterval.Yearly50,
					typeof(LanguageYearly50)
				},
				{
					HistoryInterval.Yearly100,
					typeof(LanguageYearly100)
				},
				{
					HistoryInterval.Yearly500,
					typeof(LanguageYearly500)
				},
				{
					HistoryInterval.Yearly1000,
					typeof(LanguageYearly1000)
				},
				{
					HistoryInterval.Yearly5000,
					typeof(LanguageYearly5000)
				},
				{
					HistoryInterval.Yearly10000,
					typeof(LanguageYearly10000)
				}
			}
		});
		t.collector = delegate(NanoObject pNanoObject)
		{
			Language language = (Language)pNanoObject;
			return new LanguageYearly1
			{
				id = language.getID(),
				population = language.countUnits(),
				adults = language.countAdults(),
				children = language.countChildren(),
				kingdoms = language.countKingdoms(),
				cities = language.countCities(),
				books = language.books.count(),
				books_written = language.countWrittenBooks(),
				speakers_new = language.getSpeakersNew(),
				speakers_lost = language.getSpeakersLost(),
				speakers_converted = language.getSpeakersConverted(),
				deaths = language.getTotalDeaths(),
				kills = language.getTotalKills(),
				renown = language.getRenown(),
				money = language.countTotalMoney()
			};
		};
		add(new HistoryMetaDataAsset
		{
			id = "religion",
			meta_type = MetaType.Religion,
			table_type = typeof(ReligionTable),
			table_types = new Dictionary<HistoryInterval, Type>
			{
				{
					HistoryInterval.Yearly1,
					typeof(ReligionYearly1)
				},
				{
					HistoryInterval.Yearly5,
					typeof(ReligionYearly5)
				},
				{
					HistoryInterval.Yearly10,
					typeof(ReligionYearly10)
				},
				{
					HistoryInterval.Yearly50,
					typeof(ReligionYearly50)
				},
				{
					HistoryInterval.Yearly100,
					typeof(ReligionYearly100)
				},
				{
					HistoryInterval.Yearly500,
					typeof(ReligionYearly500)
				},
				{
					HistoryInterval.Yearly1000,
					typeof(ReligionYearly1000)
				},
				{
					HistoryInterval.Yearly5000,
					typeof(ReligionYearly5000)
				},
				{
					HistoryInterval.Yearly10000,
					typeof(ReligionYearly10000)
				}
			}
		});
		t.collector = delegate(NanoObject pNanoObject)
		{
			Religion religion = (Religion)pNanoObject;
			return new ReligionYearly1
			{
				id = religion.getID(),
				population = religion.countUnits(),
				kingdoms = religion.countKingdoms(),
				cities = religion.countCities(),
				sick = religion.countSick(),
				happy = religion.countHappyUnits(),
				hungry = religion.countHungry(),
				starving = religion.countStarving(),
				deaths = religion.getTotalDeaths(),
				births = religion.getTotalBirths(),
				kills = religion.getTotalKills(),
				adults = religion.countAdults(),
				children = religion.countChildren(),
				males = religion.countMales(),
				females = religion.countFemales(),
				homeless = religion.countHomeless(),
				housed = religion.countHoused(),
				kings = religion.countKings(),
				leaders = religion.countLeaders(),
				renown = religion.getRenown(),
				money = religion.countTotalMoney(),
				evolutions = religion.getEvolutions()
			};
		};
		add(new HistoryMetaDataAsset
		{
			id = "subspecies",
			meta_type = MetaType.Subspecies,
			table_type = typeof(SubspeciesTable),
			table_types = new Dictionary<HistoryInterval, Type>
			{
				{
					HistoryInterval.Yearly1,
					typeof(SubspeciesYearly1)
				},
				{
					HistoryInterval.Yearly5,
					typeof(SubspeciesYearly5)
				},
				{
					HistoryInterval.Yearly10,
					typeof(SubspeciesYearly10)
				},
				{
					HistoryInterval.Yearly50,
					typeof(SubspeciesYearly50)
				},
				{
					HistoryInterval.Yearly100,
					typeof(SubspeciesYearly100)
				},
				{
					HistoryInterval.Yearly500,
					typeof(SubspeciesYearly500)
				},
				{
					HistoryInterval.Yearly1000,
					typeof(SubspeciesYearly1000)
				},
				{
					HistoryInterval.Yearly5000,
					typeof(SubspeciesYearly5000)
				},
				{
					HistoryInterval.Yearly10000,
					typeof(SubspeciesYearly10000)
				}
			}
		});
		t.collector = delegate(NanoObject pNanoObject)
		{
			Subspecies subspecies = (Subspecies)pNanoObject;
			return new SubspeciesYearly1
			{
				id = subspecies.getID(),
				population = subspecies.countUnits(),
				adults = subspecies.countAdults(),
				children = subspecies.countChildren(),
				deaths = subspecies.getTotalDeaths(),
				births = subspecies.getTotalBirths(),
				kills = subspecies.getTotalKills(),
				renown = subspecies.getRenown(),
				money = subspecies.countTotalMoney(),
				deaths_eaten = subspecies.getDeaths(AttackType.Eaten),
				deaths_hunger = subspecies.getDeaths(AttackType.Starvation),
				deaths_natural = subspecies.getDeaths(AttackType.Age),
				deaths_plague = subspecies.getDeaths(AttackType.Plague),
				deaths_poison = subspecies.getDeaths(AttackType.Poison),
				deaths_infection = subspecies.getDeaths(AttackType.Infection),
				deaths_tumor = subspecies.getDeaths(AttackType.Tumor),
				deaths_acid = subspecies.getDeaths(AttackType.Acid),
				deaths_fire = subspecies.getDeaths(AttackType.Fire),
				deaths_divine = subspecies.getDeaths(AttackType.Divine),
				deaths_weapon = subspecies.getDeaths(AttackType.Weapon),
				deaths_gravity = subspecies.getDeaths(AttackType.Gravity),
				deaths_drowning = subspecies.getDeaths(AttackType.Drowning),
				deaths_water = subspecies.getDeaths(AttackType.Water),
				deaths_explosion = subspecies.getDeaths(AttackType.Explosion),
				deaths_other = subspecies.getDeaths(AttackType.Other),
				metamorphosis = subspecies.getDeaths(AttackType.Metamorphosis),
				evolutions = subspecies.getEvolutions()
			};
		};
		add(new HistoryMetaDataAsset
		{
			id = "war",
			meta_type = MetaType.War,
			table_type = typeof(WarTable),
			table_types = new Dictionary<HistoryInterval, Type>
			{
				{
					HistoryInterval.Yearly1,
					typeof(WarYearly1)
				},
				{
					HistoryInterval.Yearly5,
					typeof(WarYearly5)
				},
				{
					HistoryInterval.Yearly10,
					typeof(WarYearly10)
				},
				{
					HistoryInterval.Yearly50,
					typeof(WarYearly50)
				},
				{
					HistoryInterval.Yearly100,
					typeof(WarYearly100)
				},
				{
					HistoryInterval.Yearly500,
					typeof(WarYearly500)
				},
				{
					HistoryInterval.Yearly1000,
					typeof(WarYearly1000)
				},
				{
					HistoryInterval.Yearly5000,
					typeof(WarYearly5000)
				},
				{
					HistoryInterval.Yearly10000,
					typeof(WarYearly10000)
				}
			}
		});
		t.collector = delegate(NanoObject pNanoObject)
		{
			War war = (War)pNanoObject;
			return new WarYearly1
			{
				id = war.getID(),
				population = war.countTotalPopulation(),
				army = war.countTotalArmy(),
				renown = war.getRenown(),
				kingdoms = war.countKingdoms(),
				cities = war.countCities(),
				deaths = war.getTotalDeaths(),
				population_attackers = war.countAttackersPopulation(),
				population_defenders = war.countDefendersPopulation(),
				army_attackers = war.countAttackersWarriors(),
				army_defenders = war.countDefendersWarriors(),
				deaths_attackers = war.getDeadAttackers(),
				deaths_defenders = war.getDeadDefenders(),
				money_attackers = war.countAttackersMoney(),
				money_defenders = war.countDefendersMoney()
			};
		};
	}

	public override void editorDiagnostic()
	{
		base.editorDiagnostic();
		HashSet<Type> hashSet = new HashSet<Type>();
		foreach (HistoryMetaDataAsset item in list)
		{
			Dictionary<HistoryInterval, Type> table_types = item.table_types;
			foreach (HistoryInterval value in Enum.GetValues(typeof(HistoryInterval)))
			{
				if (value != HistoryInterval.None)
				{
					if (!table_types.ContainsKey(value))
					{
						BaseAssetLibrary.logAssetError($"<e>HistoryMetaDataLibrary</e>: Missing a table type for <b>{value}</b>", item.id);
					}
					else if (!hashSet.Add(table_types[value]))
					{
						BaseAssetLibrary.logAssetError($"<e>HistoryMetaDataLibrary</e>: Duplicate table type <b>{table_types[value]}</b> for <b>{value}</b>", item.id);
					}
				}
			}
		}
	}

	public HistoryMetaDataAsset[] getAssets(MetaType pMetaType)
	{
		return _meta_data[pMetaType];
	}

	public HistoryMetaDataAsset[] getAssets(string pMetaType)
	{
		return _meta_dict[pMetaType];
	}

	public override void linkAssets()
	{
		base.linkAssets();
		Dictionary<MetaType, ListPool<HistoryMetaDataAsset>> dictionary = new Dictionary<MetaType, ListPool<HistoryMetaDataAsset>>();
		foreach (HistoryMetaDataAsset item2 in base.list)
		{
			TypeInfo typeInfo = item2.table_type.GetTypeInfo();
			List<string> list = new List<string>();
			foreach (PropertyInfo declaredProperty in typeInfo.DeclaredProperties)
			{
				if (declaredProperty.CanRead && declaredProperty.CanWrite && declaredProperty.GetMethod != null && declaredProperty.SetMethod != null && declaredProperty.GetMethod.IsPublic && declaredProperty.SetMethod.IsPublic && !declaredProperty.GetMethod.IsStatic && !declaredProperty.SetMethod.IsStatic)
				{
					list.Add(declaredProperty.Name);
				}
			}
			foreach (string item3 in list)
			{
				HistoryDataAsset item = AssetManager.history_data_library.get(item3);
				item2.categories.Add(item);
			}
			if (!dictionary.ContainsKey(item2.meta_type))
			{
				dictionary.Add(item2.meta_type, new ListPool<HistoryMetaDataAsset>());
			}
			dictionary[item2.meta_type].Add(item2);
		}
		foreach (var (metaType2, listPool2) in dictionary)
		{
			_meta_data.Add(metaType2, listPool2.ToArray());
			_meta_dict.Add(metaType2.AsString(), _meta_data[metaType2]);
		}
	}
}

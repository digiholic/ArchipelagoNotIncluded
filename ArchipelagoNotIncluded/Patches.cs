using Database;
using HarmonyLib;
using STRINGS;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace ArchipelagoNotIncluded
{
    public class Patches
    {
        public static List<string> AllTechnologies = new List<string>()
        {
                "AlgaeHabitat",
    "PlanterBox",
    "RationBox",
    "Compost",
    "CookingStation",
    "EggCracker",
    "DiningTable",
    "FarmTile",
    "Juicer",
    "SpiceGrinder",
    "MilkPress",
    "GourmetCookingStation",
    "FoodDehydrator",
    "FoodRehydrator",
    "FarmStation",
    "FertilizerMaker",
    "Refrigerator",
    "HydroponicFarm",
    "ParkSign",
    "RadiationLight",
    "RanchStation",
    "CreatureDeliveryPoint",
    "ShearingStation",
    "CreatureFeeder",
    "FishDeliveryPoint",
    "FishFeeder",
    "CreatureAirTrap",
    "CreatureGroundTrap",
    "WaterTrap",
    "EggIncubator",
    LogicCritterCountSensorConfig.ID,
    "CritterCondo",
    "UnderwaterCritterCondo",
    "MilkFeeder",
    "MilkFatSeparator",
    "MilkingStation",
    "Electrolyzer",
    "RustDeoxidizer",
    "GasConduit",
    "GasConduitBridge",
    "GasPump",
    "GasVent",
    "InsulatedGasConduit",
    LogicPressureSensorGasConfig.ID,
    "GasLogicValve",
    "GasVentHighPressure",
    "CO2Engine",
    "ModularLaunchpadPortGas",
    "ModularLaunchpadPortGasUnloader",
    "GasCargoBaySmall",
    "LiquidValve",
    "GasValve",
    "GasPermeableMembrane",
    "ManualPressureDoor",
    "AirFilter",
    "CO2Scrubber",
    "PressureDoor",
    "OreScrubber",
    "Desalinator",
    "Apothecary",
    "DoctorStation",
    "HandSanitizer",
    GasConduitDiseaseSensorConfig.ID,
    LiquidConduitDiseaseSensorConfig.ID,
    LogicDiseaseSensorConfig.ID,
    "AdvancedDoctorStation",
    "AdvancedApothecary",
    "HotTub",
    "LiquidConduit",
    "LiquidConduitBridge",
    "LiquidPump",
    "LiquidVent",
    "InsulatedLiquidConduit",
    LogicPressureSensorLiquidConfig.ID,
    "LiquidLogicValve",
    "LiquidConduitPreferentialFlow",
    "LiquidConduitOverflow",
    "LiquidReservoir",
    "EspressoMachine",
    "LiquidFuelTankCluster",
    "FlushToilet",
    "WashSink",
    ShowerConfig.ID,
    "MeshTile",
    "MechanicalSurfboard",
    "ModularLaunchpadPortLiquid",
    "ModularLaunchpadPortLiquidUnloader",
    "LiquidCargoBaySmall",
    "RocketInteriorLiquidInput",
    "RocketInteriorLiquidOutput",
    "WallToilet",
    "DecontaminationShower",
    "GasFilter",
    "LiquidFilter",
    "SludgePress",
    "AlgaeDistillery",
    "EthanolDistillery",
    "WaterPurifier",
    "OxyliteRefinery",
    "Chlorinator",
    "SupermaterialRefinery",
    "SodaFountain",
    "GasCargoBayCluster",
    "NoseconeHarvest",
    "BatteryMedium",
    SwitchConfig.ID,
    "WireBridge",
    "HighWattageWire",
    "WireBridgeHighWattage",
    "HydrogenGenerator",
    LogicPowerRelayConfig.ID,
    "PowerTransformerSmall",
    LogicWattageSensorConfig.ID,
    "WireRefined",
    "WireRefinedBridge",
    "WireRefinedHighWattage",
    "WireRefinedBridgeHighWattage",
    "PowerTransformer",
    "SteamTurbine2",
    "SolarPanel",
    "Sauna",
    "SteamEngineCluster",
    "Generator",
    "WoodGasGenerator",
    "MethaneGenerator",
    "OilRefinery",
    "PetroleumGenerator",
    "FlowerVase",
    "FloorLamp",
    "CeilingLight",
    "FlowerVaseWall",
    "FlowerVaseHanging",
    "CornerMoulding",
    "CrownMoulding",
    "ItemPedestal",
    "SmallSculpture",
    "IceSculpture",
    "ClothingFabricator",
    "CarpetTile",
    "ExteriorWall",
    "BatterySmart",
    "Phonobox",
    "PowerControlStation",
    "BatteryModule",
    "SolarPanelModule",
    "RocketInteriorPowerPlug",
    "NuclearReactor",
    "UraniumCentrifuge",
    "HEPBridgeTile",
    "Canvas",
    "Sculpture",
    "BeachChair",
    "LuxuryBed",
    "LadderFast",
    "PlasticTile",
    "ClothingAlterationStation",
    "CanvasWide",
    "MetalSculpture",
    "GlassTile",
    "FlowerVaseHangingFancy",
    "SunLamp",
    PixelPackConfig.ID,
    "CanvasTall",
    "MarbleSculpture",
    "Polymerizer",
    "OilWellCap",
    "LiquidMiniPump",
    "GasMiniPump",
    "KeroseneEngineClusterSmall",
    "MissionControlCluster",
    "KeroseneEngineCluster",
    "HydrogenEngineCluster",
    "OxidizerTankLiquidCluster",
    "SuitsOverlay",
    "AtmoSuit",
    "SuitFabricator",
    "SuitMarker",
    "SuitLocker",
    "WaterCooler",
    "CraftingTable",
    "ResetSkillsStation",
    "ClusterTelescope",
    "ExobaseHeadquarters",
    "LaunchPad",
    "HabitatModuleSmall",
    "OrbitalCargoModule",
    RocketControlStationConfig.ID,
    "PioneerModule",
    "NoseconeBasic",
    "HabitatModuleMedium",
    "ArtifactAnalysisStation",
    "ArtifactCargoBay",
    "SpecialCargoBayCluster",
    "HighEnergyParticleSpawner",
    "HighEnergyParticleRedirector",
    "HEPBattery",
    "HEPEngine",
    LogicHammerConfig.ID,
    LogicAlarmConfig.ID,
    "Telephone",
    "SweepBotStation",
    "ScoutModule",
    "RockCrusher",
    "Kiln",
    "FirePole",
    "ThermalBlock",
    LadderBedConfig.ID,
    "ModularLaunchpadPortBridge",
    "MetalRefinery",
    "MetalTile",
    "GlassForge",
    "BunkerTile",
    "BunkerDoor",
    "GeoTuner",
    "DiamondPress",
    "LeadSuit",
    "LeadSuitMarker",
    "LeadSuitLocker",
    LogicHEPSensorConfig.ID,
    "LiquidCooledFan",
    "IceCooledFan",
    "IceMachine",
    "InsulationTile",
    "SpaceHeater",
    "AirConditioner",
    LogicTemperatureSensorConfig.ID,
    GasConduitTemperatureSensorConfig.ID,
    GasConduitElementSensorConfig.ID,
    "GasConduitRadiant",
    "GasReservoir",
    "GasLimitValve",
    "LiquidConduitRadiant",
    "LiquidConditioner",
    LiquidConduitTemperatureSensorConfig.ID,
    LiquidConduitElementSensorConfig.ID,
    "LiquidHeater",
    "LiquidLimitValve",
    "ContactConductivePipeBridge",
    "AutomationOverlay",
    LogicSwitchConfig.ID,
    "LogicWire",
    "LogicWireBridge",
    "LogicDuplicantSensor",
    "FloorSwitch",
    LogicElementSensorGasConfig.ID,
    LogicElementSensorLiquidConfig.ID,
    "LogicGateNOT",
    LogicTimeOfDaySensorConfig.ID,
    LogicTimerSensorConfig.ID,
    LogicLightSensorConfig.ID,
    LogicClusterLocationSensorConfig.ID,
    "LogicGateAND",
    "LogicGateOR",
    "LogicGateBUFFER",
    "LogicGateFILTER",
    "LogicRibbon",
    "LogicRibbonBridge",
    LogicRibbonWriterConfig.ID,
    LogicRibbonReaderConfig.ID,
    LogicCounterConfig.ID,
    LogicMemoryConfig.ID,
    "LogicGateXOR",
    "ArcadeMachine",
    "Checkpoint",
    "CosmicResearchCenter",
    "LogicGateMultiplexer",
    "LogicGateDemultiplexer",
    CometDetectorConfig.ID,
    "Telescope",
    "ClusterTelescopeEnclosed",
    "AstronautTrainingCenter",
    "TravelTubeEntrance",
    "TravelTube",
    "TravelTubeWallBridge",
    "VerticalWindTunnel",
    "ConveyorOverlay",
    "SolidTransferArm",
    "StorageLockerSmart",
    "ObjectDispenser",
    "SolidFilter",
    SolidConduitTemperatureSensorConfig.ID,
    SolidConduitElementSensorConfig.ID,
    SolidConduitDiseaseSensorConfig.ID,
    "StorageTile",
    "CargoBayCluster",
    "RailGun",
    "LandingBeacon",
    "CommandModule",
    "SteamEngine",
    "ResearchModule",
    "Gantry",
    "CargoBay",
    "LiquidCargoBay",
    "GasCargoBay",
    "TouristModule",
    "SpecialCargoBay",
    "SolidBooster",
    "MissionControl",
    "KeroseneEngine",
    "LiquidFuelTank",
    "OxidizerTank",
    "OxidizerTankLiquid",
    "OxidizerTankCluster",
    "HydrogenEngine",
    "JetSuit",
    "JetSuitMarker",
    "JetSuitLocker",
    "LiquidCargoBayCluster",
    "MissileFabricator",
    "MissileLauncher",
    "SolidConduitInbox",
    "SolidConduit",
    "SolidConduitBridge",
    "SolidVent",
    "MonumentBottom",
    "MonumentMiddle",
    "MonumentTop",
    "SolidLogicValve",
    "SolidConduitOutbox",
    "SolidLimitValve",
    "SolidCargoBaySmall",
    "RocketInteriorSolidInput",
    "RocketInteriorSolidOutput",
    "ModularLaunchpadPortSolid",
    "ModularLaunchpadPortSolidUnloader",
    "AutoMiner",
    "RailGunPayloadOpener",
    "GasBottler",
    "BottleEmptierGas",
    "OxygenMask",
    "OxygenMaskLocker",
    "OxygenMaskMarker",
    "GeneticAnalysisStation",
    "SugarEngine",
    "SmallOxidizerTank",
    "NoseconeHarvest",
    "RocketInteriorGasInput",
    "RocketInteriorGasOutput",
    "OxidizerTankCluster",
    "ScannerModule",
    "LogicInterasteroidSender",
    "LogicInterasteroidReceiver"
        };

        private static string DequeueAndLog(int i, Queue<string> queue)
        {
            string s = queue.Dequeue();
            Debug.Log($"{i} - {s}");
            return s;
        }

        [HarmonyPatch(typeof(Techs))]
        [HarmonyPatch("Init")]
        public class Techs_Init_Patch
        {
            public static bool Prefix(Techs __instance)
            {
                //Copy the list then shuffle it
                AllTechnologies.Shuffle();
                foreach(var tech in AllTechnologies)
                {
                    Debug.Log(tech);
                }
                Queue<string> shuffledTechnologies = new Queue<string>(AllTechnologies);

                int i = 0;
                Debug.Log($"There are {AllTechnologies.Count} items in all techs");
                Debug.Log($"There are {shuffledTechnologies.Count} items in queue");

                Debug.Log("FarmingTech");
Tech tech1 = new Tech("FarmingTech", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                Debug.Log("FineDining");
Tech tech2 = new Tech("FineDining", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("FoodRepurposing");
Tech tech3 = new Tech("FoodRepurposing", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("FinerDining");
Tech tech4 = new Tech("FinerDining", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("Agriculture");
Tech tech5 = new Tech("Agriculture", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("Ranching");
Tech tech6 = new Tech("Ranching", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("AnimalControl");
Tech tech7 = new Tech("AnimalControl", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("AnimalComfort");
Tech tech8 = new Tech("AnimalComfort", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("DairyOperation");
Tech tech9 = new Tech("DairyOperation", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("ImprovedOxygen");
Tech tech10 = new Tech("ImprovedOxygen", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("GasPiping");
Tech tech11 = new Tech("GasPiping", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("ImprovedGasPiping");
Tech tech12 = new Tech("ImprovedGasPiping", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("SpaceGas");
Tech tech13 = new Tech("SpaceGas", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("PressureManagement");
Tech tech14 = new Tech("PressureManagement", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("DirectedAirStreams");
Tech tech15 = new Tech("DirectedAirStreams", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("LiquidFiltering");
Tech tech16 = new Tech("LiquidFiltering", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("MedicineI");
Tech tech17 = new Tech("MedicineI", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("MedicineII");
Tech tech18 = new Tech("MedicineII", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("MedicineIII");
Tech tech19 = new Tech("MedicineIII", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("MedicineIV");
Tech tech20 = new Tech("MedicineIV", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("LiquidPiping");
Tech tech21 = new Tech("LiquidPiping", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("ImprovedLiquidPiping");
Tech tech22 = new Tech("ImprovedLiquidPiping", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("PrecisionPlumbing");
Tech tech23 = new Tech("PrecisionPlumbing", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("SanitationSciences");
Tech tech24 = new Tech("SanitationSciences", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("FlowRedirection");
Tech tech25 = new Tech("FlowRedirection", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("LiquidDistribution");
Tech tech26 = new Tech("LiquidDistribution", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("AdvancedSanitation");
Tech tech27 = new Tech("AdvancedSanitation", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("AdvancedFiltration");
Tech tech28 = new Tech("AdvancedFiltration", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("Distillation");
Tech tech29 = new Tech("Distillation", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("Catalytics");
Tech tech30 = new Tech("Catalytics", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("AdvancedResourceExtraction");
Tech tech31 = new Tech("AdvancedResourceExtraction", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("PowerRegulation");
Tech tech32 = new Tech("PowerRegulation", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("AdvancedPowerRegulation");
Tech tech33 = new Tech("AdvancedPowerRegulation", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("PrettyGoodConductors");
Tech tech34 = new Tech("PrettyGoodConductors", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("RenewableEnergy");
Tech tech35 = new Tech("RenewableEnergy", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("Combustion");
Tech tech36 = new Tech("Combustion", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("ImprovedCombustion");
Tech tech37 = new Tech("ImprovedCombustion", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("InteriorDecor");
Tech tech38 = new Tech("InteriorDecor", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("Artistry");
Tech tech39 = new Tech("Artistry", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("Clothing");
Tech tech40 = new Tech("Clothing", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("Acoustics");
Tech tech41 = new Tech("Acoustics", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("SpacePower");
Tech tech42 = new Tech("SpacePower", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("NuclearRefinement");
Tech tech43 = new Tech("NuclearRefinement", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("FineArt");
Tech tech44 = new Tech("FineArt", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("EnvironmentalAppreciation");
Tech tech45 = new Tech("EnvironmentalAppreciation", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("Luxury");
Tech tech46 = new Tech("Luxury", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("RefractiveDecor");
Tech tech47 = new Tech("RefractiveDecor", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("GlassFurnishings");
Tech tech48 = new Tech("GlassFurnishings", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("Screens");
Tech tech49 = new Tech("Screens", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("RenaissanceArt");
Tech tech50 = new Tech("RenaissanceArt", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("Plastics");
Tech tech51 = new Tech("Plastics", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("ValveMiniaturization");
Tech tech52 = new Tech("ValveMiniaturization", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("HydrocarbonPropulsion");
Tech tech53 = new Tech("HydrocarbonPropulsion", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("BetterHydroCarbonPropulsion");
Tech tech54 = new Tech("BetterHydroCarbonPropulsion", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("CryoFuelPropulsion");
Tech tech55 = new Tech("CryoFuelPropulsion", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("Suits");
Tech tech56 = new Tech("Suits", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("Jobs");
Tech tech57 = new Tech("Jobs", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("AdvancedResearch");
Tech tech58 = new Tech("AdvancedResearch", new List<string>()
            {
                "BetaResearchPoint",//
                "AdvancedResearchCenter",//
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("SpaceProgram");
Tech tech59 = new Tech("SpaceProgram", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("CrashPlan");
Tech tech60 = new Tech("CrashPlan", new List<string>()
            {
                "OrbitalResearchPoint",//
                DequeueAndLog(i++, shuffledTechnologies),
                "OrbitalResearchCenter",//
                "DLC1CosmicResearchCenter"//
            }, __instance);
                
                Debug.Log("DurableLifeSupport");
Tech tech61 = new Tech("", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("NuclearResearch");
Tech tech62 = new Tech("NuclearResearch", new List<string>()
            {
                "DeltaResearchPoint",//
                "NuclearResearchCenter",//
                "ManualHighEnergyParticleSpawner"//
            }, __instance);
                
                Debug.Log("AdvancedNuclearResearch");
Tech tech63 = new Tech("AdvancedNuclearResearch", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("NuclearStorage");
Tech tech64 = new Tech("NuclearStorage", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("NuclearPropulsion");
Tech tech65 = new Tech("NuclearPropulsion", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("NotificationSystems");
Tech tech66 = new Tech("NotificationSystems", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("ArtificialFriends");
Tech tech67 = new Tech("ArtificialFriends", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("BasicRefinement");
Tech tech68 = new Tech("BasicRefinement", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("RefinedObjects");
Tech tech69 = new Tech("RefinedObjects", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("Smelting");
Tech tech70 = new Tech("Smelting", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("HighTempForging");
Tech tech71 = new Tech("HighTempForging", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("HighPressureForging");
Tech tech72 = new Tech("HighPressureForging", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("RadiationProtection");
Tech tech73 = new Tech("RadiationProtection", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("TemperatureModulation");
Tech tech74 = new Tech("TemperatureModulation", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("HVAC");
Tech tech75 = new Tech("HVAC", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("LiquidTemperature");
Tech tech76 = new Tech("LiquidTemperature", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("LogicControl");
Tech tech77 = new Tech("LogicControl", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("GenericSensors");
Tech tech78 = new Tech("GenericSensors", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("LogicCircuits");
Tech tech79 = new Tech("LogicCircuits", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("ParallelAutomation");
Tech tech80 = new Tech("ParallelAutomation", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("DupeTrafficControl");
Tech tech81 = new Tech("DupeTrafficControl", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("Multiplexing");
Tech tech82 = new Tech("Multiplexing", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("SkyDetectors");
Tech tech83 = new Tech("SkyDetectors", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("TravelTubes");
Tech tech84 = new Tech("TravelTubes", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("SmartStorage");
Tech tech85 = new Tech("SmartStorage", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("SolidManagement");
Tech tech86 = new Tech("SolidManagement", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("HighVelocityTransport");
Tech tech87 = new Tech("HighVelocityTransport", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("BasicRocketry");
Tech tech88 = new Tech("BasicRocketry", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("CargoI");
Tech tech89 = new Tech("CargoI", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("CargoII");
Tech tech90 = new Tech("CargoII", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("CargoIII");
Tech tech91 = new Tech("CargoIII", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("EnginesI");
Tech tech92 = new Tech("EnginesI", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("EnginesII");
Tech tech93 = new Tech("EnginesII", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("EnginesIII");
Tech tech94 = new Tech("EnginesIII", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("Jetpacks");
Tech tech95 = new Tech("Jetpacks", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("SolidTransport");
Tech tech96 = new Tech("SolidTransport", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("Monuments");
Tech tech97 = new Tech("Monuments", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("SolidSpace");
Tech tech98 = new Tech("SolidSpace", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("RoboticTools");
Tech tech99 = new Tech("RoboticTools", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("PortableGasses");
Tech tech100 = new Tech("PortableGasses", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);

                
                Debug.Log("Bioengineering");
Tech tech101 = new Tech("Bioengineering", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("SpaceCombustion");
Tech tech102 = new Tech("SpaceCombustion", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("HighVelocityDestruction");
Tech tech103 = new Tech("HighVelocityDestruction", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("GasDistribution");
Tech tech104 = new Tech("GasDistribution", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);
                
                Debug.Log("AdvancedScanners");
Tech tech105 = new Tech("AdvancedScanners", new List<string>()
            {
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
                DequeueAndLog(i++, shuffledTechnologies),
            }, __instance);

                return true;
            }
        }
    }
}

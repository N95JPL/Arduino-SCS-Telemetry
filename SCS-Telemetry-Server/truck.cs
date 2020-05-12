﻿using Newtonsoft.Json.Linq;
using System;
using SCSSdkClient;
using SCSSdkClient.Object;

namespace SCSTelemetryServer
{
    public class TruckVariables
    {

        public JObject truckConstant { get; private set; }
        public JObject truckConstantWarning { get; private set; }
        public JObject truckConstantWheel { get; private set; }
        public JObject truckConstantCapacity { get; private set; }

        public void TruckConstant(SCSTelemetry.Truck data)
        {
            truckConstant = new JObject
            {
                {"TruckValues", new JObject
                {
                    {"Constant", new JObject // The values in this Section should not change often, only on loading & swapping truck!
                    {
                        {"RegPlate", data.ConstantsValues.LicensePlate}, // Current Vehicle Registration
                        {"RegPlateCountryID",data.ConstantsValues.LicensePlateCountryId}, // Registered Country
                        {"RegPlateCountry",data.ConstantsValues.LicensePlateCountry}, // Registered Country ID
                        {"ManufactureID",data.ConstantsValues.Brand}, // Truck Manufacturer ID
                        {"Manufacture",data.ConstantsValues.Brand}, // Truck Manfacturer
                        {"ModelID",data.ConstantsValues.Id}, // Truck Model ID
                        {"Model",data.ConstantsValues.Name} // Truck Model
                    }
                    }
                }
                }
            };
            truckConstantWarning = new JObject
            {
                "TruckValues", new JObject
                {
                    {"Constant", new JObject // The values in this Section should not change often, only on loading & swapping truck!
                    {
                        {"MotorValues", new JObject
                        {
                            {"ForwardGearCount",data.ConstantsValues.MotorValues.ForwardGearCount }, // Forward Gear Count
                            {"ReverseGearCount",data.ConstantsValues.MotorValues.ReverseGearCount }, // Reverse Gear Count
                            {"RetarderStepCount",data.ConstantsValues.MotorValues.RetarderStepCount }, // Retarder Step Count
                            {"SelectorCount",data.ConstantsValues.MotorValues.SelectorCount }, // Selector Count (Range/Splitter Toggles)
                            {"MaxEngineRPM",data.ConstantsValues.MotorValues.EngineRpmMax }, // Maxmium RPM of Engine
                            {"DifferentialRatio",data.ConstantsValues.MotorValues.DifferentialRation }, // Differential Ratio
                            {"GearRatioForward",string.Join(",", data.ConstantsValues.MotorValues.GearRatiosForward) }, // Forward Gear Ratio's
                            {"GearRatioReverse",string.Join(",", data.ConstantsValues.MotorValues.GearRatiosReverse) }, // Reverse Gear Ratios(s)
                            {"ShifterTypeValue",(int)data.ConstantsValues.MotorValues.ShifterTypeValue }, // Enum 0-4 (unknown,arcade,automatic,manual,h-shifter)
                            {"SlotGear",string.Join(",",data.ConstantsValues.MotorValues.SlotGear) }, // Slot selected if H-Shifter Requirements not met
                            {"SlotHandlePosition",string.Join(",",data.ConstantsValues.MotorValues.SlotHandlePosition) }, // Position of H-Shifter Handle - 0 = Neutral
                            {"SlotSelector",string.Join(",",data.ConstantsValues.MotorValues.SlotSelectors) } // Not used, unsure!
                        }
                        }
                    }
                    }
                }
            };
            truckConstantCapacity = new JObject
            {
                "TruckValues", new JObject
                {
                    {"Constant", new JObject // The values in this Section should not change often, only on loading & swapping truck!
                    {
                        {"CapacityValues", new JObject
                        {
                            {"Fuel",(int)data.ConstantsValues.CapacityValues.Fuel}, // Fuel in Litres
                            {"Adblue",(int)data.ConstantsValues.CapacityValues.AdBlue } // Adblue in Litres
                        }
                        }
                    }
                    }
                }
            };
            truckConstantWarning = new JObject
            {
                "TruckValues", new JObject
                {
                    {"Constant", new JObject // The values in this Section should not change often, only on loading & swapping truck!
                    {
                        {"WarningFactors", new JObject
                        {
                            {"Fuel",data.ConstantsValues.WarningFactorValues.Fuel}, // Fuel quantity Warning
                            {"Adblue",data.ConstantsValues.WarningFactorValues.AdBlue }, // Adblue quantity Warning
                            {"AirPressure",data.ConstantsValues.WarningFactorValues.AirPressure }, // Air Pressure Low Warning
                            {"AirPressureEmergency",data.ConstantsValues.WarningFactorValues.AirPressureEmergency }, // Air Pressure Emergency Warning
                            {"OilPressure",data.ConstantsValues.WarningFactorValues.OilPressure }, // Oil Pressure Warning
                            {"WaterTemperature",data.ConstantsValues.WarningFactorValues.WaterTemperature }, // Water Temperature Warning
                            {"BatteryVoltage",data.ConstantsValues.WarningFactorValues.BatteryVoltage } // Battery Voltage Warning
                        }
                        }
                    }
                    }
                }
            };
            truckConstantWheel = new JObject
            {
                "TruckValues", new JObject
                {
                    {"Constant", new JObject // The values in this Section should not change often, only on loading & swapping truck!
                    {
                        {"WheelValues", new JObject
                        {
                            {"Count",(int)data.ConstantsValues.WheelsValues.Count}, // Wheel count
                            {"Radius",string.Join(",", data.ConstantsValues.WheelsValues.Radius) }, // String array: Wheel Radius'
                            {"Simulated",string.Join(",",data.ConstantsValues.WheelsValues.Simulated) }, // String array: Wheel Simulated (Bool)
                            {"Powered",string.Join(",",data.ConstantsValues.WheelsValues.Powered) }, // String array: Wheel Powered (Bool)
                            {"Liftable",string.Join(",", data.ConstantsValues.WheelsValues.Liftable) }, // String array: Wheel Liftable (Bool)
                            {"Steerable",string.Join(",", data.ConstantsValues.WheelsValues.Steerable) } // String array: Wheel Steerbale (Bool)
                        }
                        },
                    }
                    }
                }
            }; // ConstantJSON End
        } //Void End

        //Truck.OnJob = Main.MainData.SpecialEventsValues.OnJob.ToString();

        //Truck Warnings
        /* Truck.Warnings.AirPressure = data.CurrentValues.DashboardValues.WarningValues.AirPressure;
         Truck.Warnings.AirPressureEmergency = data.CurrentValues.DashboardValues.WarningValues.AirPressureEmergency;
         Truck.Warnings.Adblue = data.CurrentValues.DashboardValues.WarningValues.AdBlue;
         Truck.Warnings.BatteryVoltage = data.CurrentValues.DashboardValues.WarningValues.BatteryVoltage;
         Truck.Warnings.Fuel = data.CurrentValues.DashboardValues.WarningValues.FuelW;
         Truck.Warnings.OilPressure = data.CurrentValues.DashboardValues.WarningValues.OilPressure;
         Truck.Warnings.WaterTemperature = data.CurrentValues.DashboardValues.WarningValues.WaterTemperature;

         //Set Variable Values
         Truck.Current.Mileage = (int) (data.CurrentValues.DashboardValues.Odometer* 0.62137); //In miles
         Truck.Current.Speed = (int) data.CurrentValues.DashboardValues.Speed.Mph;
 Truck.Current.Gear =
         Truck.Current.Fuel = (int) data.CurrentValues.DashboardValues.FuelValue.Amount;
 Truck.Current.Range = (int) (data.CurrentValues.DashboardValues.FuelValue.Range* 0.62137); //In Miles
         Truck.Current.CruiseControl = data.CurrentValues.DashboardValues.CruiseControl;
         Truck.Current.CruiseControlSpeed = (int) data.CurrentValues.DashboardValues.CruiseControlSpeed.Mph;
 Truck.Current.AirPressure = (int) data.CurrentValues.MotorValues.BrakeValues.AirPressure;
 Truck.Current.BrakeTemperature = (int) data.CurrentValues.MotorValues.BrakeValues.Temperature;
 Truck.Current.ParkingBrake = data.CurrentValues.MotorValues.BrakeValues.ParkingBrake;
         Truck.Current.EngineBrake = data.CurrentValues.MotorValues.BrakeValues.MotorBrake;
         Truck.Current.RetarderLevel = data.CurrentValues.MotorValues.BrakeValues.RetarderLevel;
         Coord.X = data.CurrentValues.PositionValue.Position.X;
         Coord.Y = data.CurrentValues.PositionValue.Position.Y;
         Coord.Z = data.CurrentValues.PositionValue.Position.Z;

         //Truck Lights
         Truck.Lights.AuxFront = data.CurrentValues.LightsValues.AuxFront.ToString();
         Truck.Lights.AuxRoof = data.CurrentValues.LightsValues.AuxRoof.ToString();
         Truck.Lights.Beacon = data.CurrentValues.LightsValues.Beacon;
         Truck.Lights.BeamHigh = data.CurrentValues.LightsValues.BeamHigh;
         Truck.Lights.BeamLow = data.CurrentValues.LightsValues.BeamLow;
         Truck.Lights.BlinkerLeftOn = data.CurrentValues.LightsValues.BlinkerLeftOn;
         Truck.Lights.BlinkerLeftActive = data.CurrentValues.LightsValues.BlinkerLeftActive;
         Truck.Lights.BlinkerRightOn = data.CurrentValues.LightsValues.BlinkerRightOn;
         Truck.Lights.BlinkerRightActive = data.CurrentValues.LightsValues.BlinkerRightActive;
         Truck.Lights.Brake = data.CurrentValues.LightsValues.Brake;
         Truck.Lights.Parking = data.CurrentValues.LightsValues.Parking;
         Truck.Lights.Reverse = data.CurrentValues.LightsValues.Reverse;*/
    }
}
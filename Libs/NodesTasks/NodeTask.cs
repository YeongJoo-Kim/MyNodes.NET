﻿/*  MyNetSensors 
    Copyright (C) 2015 Derwish <derwish.pro@gmail.com>
    License: http://www.gnu.org/licenses/gpl-3.0.txt  
*/

using System;
using MyNetSensors.Gateways;

namespace MyNetSensors.NodesTasks
{
    public class NodeTask
    {

        public int Id { get; set; }
        public bool enabled { get; set; }
        public bool isCompleted { get; set; }
        public string description { get; set; }
        public int nodeId { get; set; }
        public int sensorId { get; set; }
        public int sensorDbId { get; set; }
        public string sensorDescription { get; set; }
        public DateTime executionDate { get; set; }
        public SensorDataType? dataType { get; set; }
        public string executionValue { get; set; }
        public bool isRepeating { get; set; }
        public int repeatingInterval { get; set; }
        public string repeatingAValue { get; set; }
        public string repeatingBValue { get; set; }
        //if repeatingNeededCount==0, then will run indefinitely
        public int repeatingNeededCount { get; set; }
        public int repeatingDoneCount { get; set; }



     
    }
}
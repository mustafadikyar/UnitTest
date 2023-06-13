﻿using UnitTest.Data;

Console.WriteLine("-----------------    Data Processor  ----------------------");
Console.WriteLine();

List<string> lines = new()
{
    "Espresso;10/27/2022 8:01:16 AM",
    "Latte; 10/27/2022 8:04:12 AM",
    "Cappuccino; 10/27/2022 8:06:04 AM",
    "Espresso; 10/27/2022 8:07:34 AM",
    "Latte; 10/27/2022 8:10:09 AM",
    "Cappuccino; 10/27/2022 8:13:00 AM",
    "Cappuccino; 10/27/2022 8:15:43 AM",
    "Espresso; 10/27/2022 8:17:32 AM",
    "Cappuccino; 10/27/2022 8:19:26 AM",
    "Cappuccino; 10/27/2022 8:22:01 AM"
};

DataItem[] machineDataItems = LineParsers.Parse(lines);

var dataProcessor = new DataProcessor(new ConsoleCoffeeCountStore());
dataProcessor.ProcessItems(machineDataItems);

Console.WriteLine();
Console.WriteLine($"The operation was successfully processed!");

Console.ReadLine();
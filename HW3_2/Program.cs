﻿// See https://aka.ms/new-console-template for more information
const decimal ценакофе = 69;
const decimal суммакофе = 69;
const decimal ценарулет = 70;
const decimal суммарулет = 70;
const decimal НДС18 = 10.53m;
const decimal НДС10 = 6.36m;
const decimal итого = суммакофе + суммарулет;

Console.WriteLine("--------------------------------------------");
Console.WriteLine("№  Название            Цена   Кол.  Сумма");
Console.WriteLine();
Console.WriteLine($"1 КОФЕ стандартный     {ценакофе}     1     {суммакофе} " +
     $"\n  НДС с расчитанной\n  ставкой 18%                       {НДС18}");
Console.WriteLine();
Console.WriteLine("2 РУЛЕТ-СПРИНГ ТВ ИЗ" +
     $"   {ценарулет}     1     {суммарулет}\n   КУ\n " +
     $" НДС с расчитанной стакой\n  ставкой 10%                       {НДС10} ");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();
Console.WriteLine($"Итого:                             {итого}");
Console.WriteLine();
Console.WriteLine("  Электронные средства" +
    $"             139.00\n  НДС итога чека c                 {НДС18}" +
    "\n  с расчитанной ставкой\n  18%");
Console.WriteLine($"  НДС итога чека с                 {НДС10}" +
    "\n  с расчитанной стакой\n  10%");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("--------------------------------------------");
Console.WriteLine("  Вид НАЛОГООБЛОЖЕНИЯ: ОСН" +
    "\n  РЕГ.НОМЕР ККТ :0000143873023483" +
    "\n  ЗАВОД №:" +
    "\n  ФН №: 8710000100265168" +
    "\n  ФД №: 6026" +
    "\n  ФПД №: 3322278314");

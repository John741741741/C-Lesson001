﻿// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите число");//Ввод в консоль
string example = Console.ReadLine();//Создаём переменную example, в которую записываем строковое значение из консоли 
                                    //(Console.RedLine- всегда выводит строковое значение)
int a = Convert.ToInt32(example);//Создаём переменную а, в которую конвертируем из строкового в числовое значение

Console.WriteLine("Вывод:");//Вывод в консоль
int result = a * a;//Возведение в квадрат
Console.WriteLine(result);//Вывод результата
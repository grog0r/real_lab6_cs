using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class FractionDemo
{
    /// <summary>
    /// Запуск демонстрации
    /// </summary>
    public static void RunDemo()
    {
        // Часть 1: Создание дробей и базовые операции
        Console.WriteLine("\n1. Создание дробей:");
        Fraction f1 = new Fraction(1, 3);
        Fraction f2 = new Fraction(2, 3);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(1, -2); // Должно стать -1/2

        Console.WriteLine($"   f1 = {f1}");
        Console.WriteLine($"   f2 = {f2}");
        Console.WriteLine($"   f3 = {f3}");
        Console.WriteLine($"   f4 = {f4} (отрицательный знаменатель обработан)");

        // Часть 2: Арифметические операции
        Console.WriteLine("\n2. Арифметические операции:");

        // Сложение
        Fraction sum = f1.Add(f2);
        Console.WriteLine($"   {f1} + {f2} = {sum}");

        // Вычитание
        Fraction diff = f2.Subtract(f1);
        Console.WriteLine($"   {f2} - {f1} = {diff}");

        // Умножение
        Fraction product = f1.Multiply(f2);
        Console.WriteLine($"   {f1} * {f2} = {product}");

        // Деление
        Fraction quotient = f1.Divide(f2);
        Console.WriteLine($"   {f1} / {f2} = {quotient}");

        // Операции с целыми числами
        Console.WriteLine("\n3. Операции с целыми числами:");
        Console.WriteLine($"   {f1} + 2 = {f1.Add(2)}");
        Console.WriteLine($"   {f1} - 1 = {f1.Subtract(1)}");
        Console.WriteLine($"   {f1} * 3 = {f1.Multiply(3)}");
        Console.WriteLine($"   {f1} / 2 = {f1.Divide(2)}");

        // Часть 3: Сложное выражение
        Console.WriteLine("\n4. Сложное выражение: f1 + f2 / f3 - 5");
            
        // По шагам:
        Fraction step1 = f1.Add(f2);           // f1 + f2
        Fraction step2 = step1.Divide(f3);      // (f1 + f2) / f3
        Fraction step3 = step2.Subtract(5);      // ((f1 + f2) / f3) - 5
            
        Console.WriteLine($"   Шаг 1: {f1} + {f2} = {step1}");
        Console.WriteLine($"   Шаг 2: {step1} / {f3} = {step2}");
        Console.WriteLine($"   Шаг 3: {step2} - 5 = {step3}");
        Console.WriteLine($"   Результат: {step3}");

        // Часть 5: Сравнение дробей
        Console.WriteLine("\n5. Сравнение дробей (по числителю и знаменателю):");
            
        Fraction fa = new Fraction(1, 2);
        Fraction fb = new Fraction(2, 4);  // По значению 1/2, но числитель/знаменатель другие
        Fraction fc = new Fraction(1, 2);  // Такая же как fa
            
        Console.WriteLine($"   fa = {fa}");
        Console.WriteLine($"   fb = {fb} (эквивалент 1/2 по значению)");
        Console.WriteLine($"   fc = {fc}");
            
        Console.WriteLine($"   fa.Equals(fb): {fa.Equals(fb)} - False (разные числа)");
        Console.WriteLine($"   fa.Equals(fc): {fa.Equals(fc)} - True (одинаковые числа)");

        // Часть 6: Клонирование
        Console.WriteLine("\n6. Клонирование дроби:");
            
        Fraction original = new Fraction(3, 7);
        Fraction clone = (Fraction)original.Clone();
            
        Console.WriteLine($"   Оригинал: {original}");
        Console.WriteLine($"   Клон: {clone}");
        Console.WriteLine($"   Оригинал == Клон: {original == clone} (разные объекты)");
        Console.WriteLine($"   Оригинал.Equals(Клон): {original.Equals(clone)} (одинаковые значения)");
    }
}
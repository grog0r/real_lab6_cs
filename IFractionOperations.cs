using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class FractionOperations
{
    /// <summary>
    /// Сложение дроби с другой дробью
    /// </summary>
    public static Fraction Add(this Fraction f1, Fraction f2)
    {
        if (f1 == null || f2 == null)
        {
            throw new ArgumentNullException("Дробь не может быть null");
        }

        int newNumerator = f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator;
        int newDenominator = f1.Denominator * f2.Denominator;
            
        return new Fraction(newNumerator, newDenominator);
    }

    /// <summary>
    /// Сложение дроби с целым числом
    /// </summary>
    public static Fraction Add(this Fraction f, int number)
    {
        return f.Add(new Fraction(number, 1));
    }

    /// <summary>
    /// Вычитание дроби из дроби
    /// </summary>
    public static Fraction Subtract(this Fraction f1, Fraction f2)
    {
        if (f1 == null || f2 == null)
        {
            throw new ArgumentNullException("Дробь не может быть null");
        }

        int newNumerator = f1.Numerator * f2.Denominator - f2.Numerator * f1.Denominator;
        int newDenominator = f1.Denominator * f2.Denominator;
            
        return new Fraction(newNumerator, newDenominator);
    }

    /// <summary>
    /// Вычитание целого числа из дроби
    /// </summary>
    public static Fraction Subtract(this Fraction f, int number)
    {
        return f.Subtract(new Fraction(number, 1));
    }

    /// <summary>
    /// Умножение дроби на другую дробь
    /// </summary>
    public static Fraction Multiply(this Fraction f1, Fraction f2)
    {
        if (f1 == null || f2 == null)
        {
            throw new ArgumentNullException("Дробь не может быть null");
        }

        int newNumerator = f1.Numerator * f2.Numerator;
        int newDenominator = f1.Denominator * f2.Denominator;
            
        return new Fraction(newNumerator, newDenominator);
    }

    /// <summary>
    /// Умножение дроби на целое число
    /// </summary>
    public static Fraction Multiply(this Fraction f, int number)
    {
        return f.Multiply(new Fraction(number, 1));
    }

    /// <summary>
    /// Деление дроби на другую дробь
    /// </summary>
    public static Fraction Divide(this Fraction f1, Fraction f2)
    {
        if (f1 == null || f2 == null)
        {
            throw new ArgumentNullException("Дробь не может быть null");
        }

        if (f2.Numerator == 0)
        {
            throw new DivideByZeroException("Нельзя делить на дробь с числителем 0");
        }

        int newNumerator = f1.Numerator * f2.Denominator;
        int newDenominator = f1.Denominator * f2.Numerator;
            
        return new Fraction(newNumerator, newDenominator);
    }

    /// <summary>
    /// Деление дроби на целое число
    /// </summary>
    public static Fraction Divide(this Fraction f, int number)
    {
        return f.Divide(new Fraction(number, 1));
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Fraction : ICloneable
{
    // Поля класса
    private int _numerator;     // Числитель
    private int _denominator;   // Знаменатель

    /// <summary>
    /// Конструктор класса Fraction
    /// </summary>
    /// <param name="numerator">Числитель</param>
    /// <param name="denominator">Знаменатель (не может быть 0)</param>
    public Fraction(int numerator, int denominator)
    {
        // Проверка знаменателя
        if (denominator == 0)
        {
            throw new ArgumentException("Знаменатель не может быть равен 0");
        }

        // Если знаменатель отрицательный, переносим минус в числитель
        if (denominator < 0)
        {
            numerator = -numerator;
            denominator = -denominator;
        }

        _numerator = numerator;
        _denominator = denominator;
    }

    /// <summary>
    /// Свойство для получения числителя
    /// </summary>
    public int Numerator
    {
        get { return _numerator; }
    }

    /// <summary>
    /// Свойство для получения знаменателя
    /// </summary>
    public int Denominator
    {
        get { return _denominator; }
    }

    /// <summary>
    /// Возвращает строковое представление дроби
    /// </summary>
    public override string ToString()
    {
        return $"{_numerator}/{_denominator}";
    }

    /// <summary>
    /// Сравнение дробей
    /// </summary>
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Fraction other = (Fraction)obj;
        return _numerator == other._numerator && _denominator == other._denominator;
    }

    /// <summary>
    /// Хэш-код дроби
    /// </summary>
    public override int GetHashCode()
    {
        return HashCode.Combine(_numerator, _denominator);
    }

    /// <summary>
    /// Клонирование дроби
    /// </summary>
    public object Clone()
    {
        return new Fraction(_numerator, _denominator);
    }
}
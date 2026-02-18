using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IFraction
{
    /// <summary>
    /// Получить вещественное значение дроби
    /// </summary>
    double GetDoubleValue();
        
    /// <summary>
    /// Установить числитель
    /// </summary>
    void SetNumerator(int numerator);
        
    /// <summary>
    /// Установить знаменатель
    /// </summary>
    void SetDenominator(int denominator);
}
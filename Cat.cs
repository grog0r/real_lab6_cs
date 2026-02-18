/// <summary>
/// Интерфейс для объектов, способных мяукать
/// </summary>
public interface IMeow
{
    /// <summary>
    /// Издать звук "мяу"
    /// </summary>
    void Meow();
    
    /// <summary>
    /// Издать звук "мяу" несколько раз
    /// </summary>
    /// <param name="count">Количество повторений</param>
    void Meow(int count);
    
    /// <summary>
    /// Свойство для получения количества мяуканий
    /// </summary>
    int MeowCount { get; }
}

/// <summary>
/// Класс, представляющий кота
/// </summary>
public class Cat : IMeow
{
    private string _name;
    private int _meowCount;
    
    /// <summary>
    /// Имя кота (только для чтения)
    /// </summary>
    public string Name => _name;
    
    /// <summary>
    /// Количество произведенных мяуканий
    /// </summary>
    public int MeowCount => _meowCount;
    
    /// <summary>
    /// Конструктор класса Cat
    /// </summary>
    /// <param name="name">Имя кота</param>
    /// <exception cref="ArgumentException">Выбрасывается при пустом имени</exception>
    public Cat(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Имя кота не может быть пустым");
        
        _name = name;
        _meowCount = 0;
    }
    
    /// <summary>
    /// Преобразование объекта в строковое представление
    /// </summary>
    /// <returns>Строка в формате "кот: Имя"</returns>
    public override string ToString()
    {
        return $"кот: {_name}";
    }
    
    /// <summary>
    /// Издать однократное мяуканье
    /// </summary>
    public void Meow()
    {
        _meowCount++;
        Console.WriteLine($"{_name}: мяу!");
    }
    
    /// <summary>
    /// Издать многократное мяуканье
    /// </summary>
    /// <param name="count">Количество мяуканий</param>
    /// <exception cref="ArgumentException">Выбрасывается при count ≤ 0</exception>
    public void Meow(int count)
    {
        if (count <= 0)
            throw new ArgumentException("Количество мяуканий должно быть положительным числом");
        
        _meowCount += count;
        var meows = string.Join("-", Enumerable.Repeat("мяу", count));
        Console.WriteLine($"{_name}: {meows}!");
    }
}
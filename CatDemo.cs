/// <summary>
/// Класс для демонстрации работы с котами
/// </summary>
public class CatDemo
{
    /// <summary>
    /// Демонстрация работы с котом Барсик
    /// </summary>
    public static void DemonstrateCat()
    {
        Console.WriteLine("=== Демонстрация работы с котом ===");
        
        // Создаем кота по имени "Барсик"
        Cat barsik = new Cat("Барсик");
        Console.WriteLine($"Создан: {barsik}");
        
        // Мяукаем один раз
        Console.Write("Мяуканье один раз: ");
        barsik.Meow();
        
        // Мяукаем три раза
        Console.Write("Мяуканье три раза: ");
        barsik.Meow(3);
        
        Console.WriteLine($"Всего мяуканий: {barsik.MeowCount}");
        Console.WriteLine();
    }
    
    /// <summary>
    /// Демонстрация работы с интерфейсом IMeowable
    /// </summary>
    public static void DemonstrateMeowable()
    {
        Console.WriteLine("=== Демонстрация работы с интерфейсом IMeowable ===");
        
        // Создаем несколько котов
        List<IMeow> meowables = new List<IMeow>
        {
            new Cat("Барсик"),
            new Cat("Мурзик"),
            new Cat("Васька")
        };
        
        // Вызываем мяуканье у всех
        Console.WriteLine("Все коты мяукают:");
        MeowHelper.MakeAllMeow(meowables);
        
        Console.WriteLine();
    }
    
    /// <summary>
    /// Демонстрация подсчета мяуканий
    /// </summary>
    public static void DemonstrateMeowCounting()
    {
        Console.WriteLine("=== Демонстрация подсчета мяуканий ===");
        
        // Создаем кота
        Cat cat = new Cat("Барсик");
        Console.WriteLine($"Создан кот: {cat}");
        Console.WriteLine($"Начальное количество мяуканий: {cat.MeowCount}");
        
        // Создаем список с одним котом
        List<IMeow> meowables = new List<IMeow> { cat };
        
        // Вызываем метод и получаем количество мяуканий
        int totalMeows = MeowHelper.MakeAllMeowAndCount(meowables);
        
        Console.WriteLine($"После вызова метода кот мяукал {totalMeows} раз");
        Console.WriteLine($"Общее количество мяуканий у кота: {cat.MeowCount}");
        Console.WriteLine();
    }
}
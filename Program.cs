/// <summary>
/// Главный класс программы
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Демонстрация работы с котами
            CatDemo.DemonstrateCat();
            CatDemo.DemonstrateMeowable();
            CatDemo.DemonstrateMeowCounting();
            
            // Демонстрация работы с дробями
            FractionDemo.RunDemo();
            
            Console.WriteLine("=== Все демонстрации завершены ===");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
        
        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
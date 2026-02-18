/// <summary>
/// Класс со вспомогательными методами для работы с мяукающими объектами
/// </summary>
public static class MeowHelper
{
    /// <summary>
    /// Вызывает мяуканье у всех объектов в коллекции
    /// </summary>
    /// <param name="meowables">Коллекция мяукающих объектов</param>
    public static void MakeAllMeow(IEnumerable<IMeow> meowables)
    {
        if (meowables == null)
            throw new ArgumentNullException(nameof(meowables));
        
        foreach (var meowable in meowables)
        {
            meowable.Meow();
        }
    }
    
    /// <summary>
    /// Вызывает мяуканье у всех объектов и возвращает общее количество мяуканий
    /// </summary>
    /// <param name="meowables">Коллекция мяукающих объектов</param>
    /// <returns>Общее количество произведенных мяуканий</returns>
    public static int MakeAllMeowAndCount(IEnumerable<IMeow> meowables)
    {
        if (meowables == null)
            throw new ArgumentNullException(nameof(meowables));
        
        int totalMeows = 0;
        
        foreach (var meowable in meowables)
        {
            // Сохраняем текущее количество мяуканий
            int before = meowable.MeowCount;
            
            // Вызываем мяуканье
            meowable.Meow();
            
            // Вычисляем сколько раз мяукал объект
            int after = meowable.MeowCount;
            totalMeows += (after - before);
        }
        
        return totalMeows;
    }
}
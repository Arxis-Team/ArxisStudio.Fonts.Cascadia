using ArxisStudio.Fonts.Cascadia;

namespace Avalonia;

/// <summary>
/// Подключение Cascadia Code к приложению.
/// </summary>
public static class CascadiaFontApplicationExtensions
{
    /// <summary>
    /// Регистрирует Cascadia Code как коллекцию <c>fonts:Cascadia</c>.
    /// </summary>
    /// <remarks>
    /// Вызывается при сборке приложения, рядом с <c>UsePlatformDetect</c>. Без
    /// него разметка, просящая <c>fonts:Cascadia#Cascadia Code</c>, шрифта не
    /// найдёт и молча возьмёт системный — ошибки не будет, будет другой текст.
    /// </remarks>
    /// <param name="builder">Сборщик приложения.</param>
    /// <returns>Тот же сборщик — для цепочки вызовов.</returns>
    public static AppBuilder WithCascadiaFont(this AppBuilder builder) =>
        builder.ConfigureFonts(manager => manager.AddFontCollection(new CascadiaFontCollection()));
}

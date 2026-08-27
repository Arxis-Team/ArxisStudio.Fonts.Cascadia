using Avalonia.Media.Fonts;

namespace ArxisStudio.Fonts.Cascadia;

/// <summary>
/// Встроенный Cascadia Code: коллекция <c>fonts:Cascadia</c>.
/// </summary>
/// <remarks>
/// Ключ коллекции и адрес ресурсов связаны жёстко: <c>fonts:Cascadia</c> — то,
/// чем шрифт зовут в разметке (<c>fonts:Cascadia#Cascadia Code</c>), а
/// avares-адрес — папка, где лежит сам файл. Переименуете папку — коллекция
/// перестанет находить шрифт, и текст молча уедет на системный.
/// </remarks>
internal sealed class CascadiaFontCollection : EmbeddedFontCollection
{
    /// <summary>Создаёт коллекцию поверх ресурсов этой сборки.</summary>
    public CascadiaFontCollection()
        : base(
            new Uri("fonts:Cascadia", UriKind.Absolute),
            new Uri("avares://ArxisStudio.Fonts.Cascadia/Assets", UriKind.Absolute))
    {
    }
}

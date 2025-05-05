/*
    Archivo principal para metodos internos de la GUI
*/
using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

class Gui : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private static void Main(string[] args)
    {
        BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
    }

    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<Gui>()
                     .UsePlatformDetect()
                     .LogToTrace();
}

/*
    Sistema agenda -- GUI incluida.
    Autor: Ituriel Liebes Saenz
    ID: 554644
    Tech stack: C#,.NET,
*/
// Creando el sistema
using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;


class Program
{
    static void Main(string[] args)
    {
        Gui.BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
    }
}


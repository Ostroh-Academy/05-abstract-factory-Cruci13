using System;

// Абстрактна фабрика
interface IMobileUIFactory
{
    IButton CreateButton();
    ITextField CreateTextField();
}

// Абстрактні продукти
interface IButton
{
    void Render();
}

interface ITextField
{
    void Render();
}

// Конкретна реалізація для світлої теми
class LightButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Render Light Button");
    }
}

class LightTextField : ITextField
{
    public void Render()
    {
        Console.WriteLine("Render Light Text Field");
    }
}

// Конкретна реалізація для темної теми
class DarkButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Render Dark Button");
    }
}

class DarkTextField : ITextField
{
    public void Render()
    {
        Console.WriteLine("Render Dark Text Field");
    }
}

// Фабрика для створення елементів зі світлою темою
class LightMobileUIFactory : IMobileUIFactory
{
    public IButton CreateButton()
    {
        return new LightButton();
    }

    public ITextField CreateTextField()
    {
        return new LightTextField();
    }
}

// Фабрика для створення елементів зі темною темою
class DarkMobileUIFactory : IMobileUIFactory
{
    public IButton CreateButton()
    {
        return new DarkButton();
    }

    public ITextField CreateTextField()
    {
        return new DarkTextField();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Вибір теми
        string theme = "dark"; // можна змінити на "light"

        // Створення фабрики
        IMobileUIFactory factory;
        if (theme == "dark")
            factory = new DarkMobileUIFactory();
        else
            factory = new LightMobileUIFactory();

        // Використання фабрики для створення елементів
        var button = factory.CreateButton();
        var textField = factory.CreateTextField();

        // Відображення елементів
        button.Render();
        textField.Render();
    }
}

[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/UO7VGONk)
# Патерн абстрактна фабрика

Варіант 1
бстрактна фабрика для мобільних додатків з темною та світлою темами — студенти можуть розробити фабрику, яка виробляє елементи інтерфейсу для мобільних додатків у двох різних стилях: темному та світлому. Кожен елемент (наприклад, кнопка, текстове поле) матиме різні візуальні представлення в залежності від теми.
У цьому коді IMobileUIFactory є абстрактною фабрикою, яка описує методи для створення елементів інтерфейсу. Кожен конкретний клас фабрики (LightMobileUIFactory і DarkMobileUIFactory) реалізує цей інтерфейс і створює елементи з відповідною темою. Кожен елемент інтерфейсу реалізує відповідний інтерфейс (IButton або ITextField) і має метод Render, який відображає елемент у вікні консолі.
У Main вибирається тема, створюється відповідна фабрика, і використовуються її методи для створення елементів.
Діаграма класів:
![image](https://github.com/Ostroh-Academy/05-abstract-factory-Cruci13/assets/92023689/7302ed56-19e4-4282-8b12-edce1da6c127)




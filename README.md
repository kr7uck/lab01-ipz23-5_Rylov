1. DRY (Don't Repeat Yourself)
   
Повторне використання коду реалізовано через базові класи та інтерфейси:
Animal.cs: для всіх тварин
Employee.cs: для працівників
Всі похідні класи (Lion, Elephant, Zookeeper...) використовують спільну логіку з базових класів.

2. KISS (Keep It Simple, Stupid) 

Кожен клас і метод має одну відповідальність і не перевантажений логікою:
ZooInventory.cs: лише облік та виведення списку
Lion.cs: описує, як лев їсть і видає звуки

3. S — Принцип єдиної відповідальності

Кожен клас має відповідальність:
Lion.cs, Elephant.cs — опис поведінки конкретних тварин
Veterinarian.cs, Zookeeper.cs — дії працівників
ZooInventory.cs — загальний облік

4. O — Принцип відкритості або закритості 

Нові типи тварин або їжі можна додати без зміни існуючого коду:
Наприклад, можна додати Cat.cs, що наслідує Animal

5. L — Принцип підстановки Лісков (LSP)

Усі підтипи можна використовувати як базовий тип IAnimal:
У ZooInventory додаються Lion, Elephant як IAnimal

6. I — Принцип розділення інтерфейсів (ISP)

Інтерфейси фокусуються лише на потрібному функціоналі:
IAnimal: Eat(), MakeSound()
IEmployee: PerformDuties()

7. D — Принцип інверсії залежностей (DIP)

Високорівневі модулі залежать від абстракцій, а не реалізацій:
Enclosure.cs працює з IAnimal
ZooInventory.cs працює зі списками IAnimal, IEmployee

8. YAGNI (You Aren’t Gonna Need It) 

Код містить функціонал без зайвої складності.

9. (Composition Over Inheritance)

Enclosure містить список тварин (IAnimal), а не наслідує їх.

10. (Program to Interfaces)

Списки у ZooInventory.cs визначені як List<IAnimal>, List<IEmployee>:
List<IAnimal> Animals = new();

11. Fail Fast

Якщо тварина отримує неправильну їжу, вона одразу повідомляє про це:
Метод Eat(IFood food) у Lion.cs та Elephant.cs

# MyCalculator 
Приложение __MyCalculator__, написанное на языке с# с использованием Windows Forms, предоставляет стандартные функции калькулятора, такие как сложение, деление, умножение и вычитание.

![MyCalculator](https://user-images.githubusercontent.com/96730744/197638419-24e94850-41a7-46f9-bd4c-c23a7d48ad52.png)

# Oписанием проекта
Проект содержит в себе следующие классы:
+ `Calculations.cs` в котором реализованны следующие методы:
    + `ProcessStatement` который отвечает за преобразование поступающей в нее строки:
```
try
{
   string result = CalulateStatement(GetOperantA(sign, statement), GetOperantB(statement), GetOperation(statement));
   if(statement.Length > 9)
   {
      return "EXCEEDED";
   }
   else
   {
      return result;
   }
}
catch(Exception)
{
  return "0";
}

```

    + `GetOperantA` который отвечает за обработку первого операнда:
    
```
string[] a = statement.Split('+', '-', '/', '*');
            return sign + a[0];
```
    + `CalulateStatement`;
    
+ `Calculator.cs` который предназначен для работы с Windows Forms и содержащий следующие методы:
    + OperandChange;
    + 
    
    

+ `CalculationsTests.cs` в котором содержатся методы для тестирования программы.

# Инструкция по запуску проекта

+ На вашем компьютере должна быть установлена Windows.
+ Установите последнюю версию Visual Studio.
+ Установите рабочую нагрузку «Разработка универсальной платформы Windows».
+ Установите необязательный компонент «Средства универсальной платформы Windows».
+ Установите последнюю версию Windows SDK.

![startProject](https://user-images.githubusercontent.com/96730744/197644537-27ffa0a6-4350-495f-883b-154ead8c3013.png)

+ Установите расширение для Visual Studio.
+ Клонирование проекта: 
```
    git clone https://github.com/Stanislavcod/MyCalculator.git
```
+ Откройте src\Calculator.sln в Visual Studio, чтобы создать и запустить приложение __MyCalculator__.
+ Для запуска тестов пользовательского интерфейса необходимо убедиться, что установлен драйвер приложения Windows (WinAppDriver).

# Тестирование 
Все написанные методы для выполнения стандартных операций были протестированны.

Для написания юнит-тестов использовались xUnit тесты.

## Пример методов тестирования
```
[Fact]
        public void TestSubtractResultFife()
        {
            Calculations calculation = new();
            string result = calculation.ProcessStatement("", "3+2");
            Assert.Equal("5", result);
        }
        [Fact]
        public void TestSubtractResultMinusOne()
        {
            Calculations calculation = new();
            string result = calculation.ProcessStatement("-", "3+2");
            Assert.Equal("-1", result);
        }
```
Данные методы проверяют работоспособности метода Subtract() (Вычитание).

Остальные методы тестирования сделаны по аналогии.

## Результаты тестирования

![resultTests](https://user-images.githubusercontent.com/96730744/197643735-97b336b1-79e2-4108-aa24-973e408aa759.png)

# Иллюстарация и инструкция по работе с калькулятором
## Илюстрация работы калькулятора

![GifRes](https://user-images.githubusercontent.com/96730744/197640702-ca911174-4dd6-4d31-bab0-1694fa052aef.gif)

## Инструкция по работe с калькулятором

Для выполнения операций (сложение, вычитание, деление и умножение) необходимо выполнить следующие действия:
+ Выбрать первый операнд (нажав необходимую кнопку с числом);
+ Выбрать кнопку знака операции (+, - , * , ÷);
+ Выбрать первый второй (нажав необходимую кнопку с числом);
+ Затем нажать кнопку (=) и результат операции появится в тексовом поле;
### Вспомогательные функции
+ При нажатие на кнопку с изображением (С) текстовое поле отчистится;
+ Для ввода отрицательного числа вам наобходимо нажать кнопку с изображением (+/-);

Рад был вам помочь.😊

Приятного пользования!😉

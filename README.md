HOMEWORK_1_nUNIT

1.	В отдельном проекте создать класс Calculator, содержащий 4 метода: сумма, разность, деление, умножение.
2.	В том же проекте создать несколько тестовых классов, по одному на каждый метод, протестировав наш калькулятор
3.	В тестах использовать аннотации и параметры Nunit. https://docs.nunit.org/articles/nunit/writing-tests/attributes/apartment.html
Обязательные: SetUp, TearDown, TestCase Retry, Random, Values, Range, Description, Category


HOMEWORK_2_SELENIUM_HEROKUAPP

Автоматизировать тесты для приложения: http://the-internet.herokuapp.com/ 

-	Создаем новый проект. Подключаем Nunit, selenium
-	Каждая страница - отдельный класс и тест. 
-	Каждый тест должен включать в себя открытие окна в максимальном размере - driver.Manage().Window.Maximize();
-	Обязательно задать таймаут - driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
A.	Add/Remove Elements - добавить 2 элемента, удалить элемент, проверить количество элементов
  Локаторы xpath:
-	By.XPath ("//button[text()='Add Element']")
-	By.XPath ("//button[text()='Delete']")
B.	Checkboxes - проверить, что первый чекбокс unchecked, отметить первый чекбокс, проверить что он checked. Проверить, что второй чекбокс checked, сделать unheck, проверить, что он unchecked
   Локатор By.CssSelector (“[type=checkbox]”)
C.	Dropdown - Взять все элементы дроп-дауна и проверить их наличие. Выбрать первый, проверить, что он выбран, выбрать второй, проверить, что он выбран
   Локатор By.Id(“dropdown”)
D.	Inputs - Проверить на возможность ввести различные цифровые и нецифровые значения, используя Keys.ARROW_UP  И Keys.ARROW_DOWN 
   Локатор By.TagName(“input”)
E.	Typos - Проверить соответствие параграфа орфографии 
   Локатор By.TagName(“p”)

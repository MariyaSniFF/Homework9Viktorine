// Напишите программу тестирования из 10 вопросов с 4 вариантами ответов, один из которых верный.
Console.WriteLine("Выберите один ответ на каждый вопрос");
Console.WriteLine();
Start();
void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();

        System.Console.WriteLine("1) 1. Какое животное было приручено древним человеком намного раньше других животных?");
        System.Console.WriteLine("2) 2. Какая порода собак считается самой древней?");
        System.Console.WriteLine("3) 3. У какой породы собак на древнем Дальнем Востоке были собственные слуги?");
        System.Console.WriteLine("4) 4. Какой древнегреческий философ считал, что собаки имеют душу философа?");
        System.Console.WriteLine("5) 5. Образ какой собаки является в Японии примером беззаветной любви и преданности?");
        System.Console.WriteLine("6) 6. Каких собак в средние века одевали в доспехи для участия в битве или для защиты караванов вместе с рыцарями?");
        System.Console.WriteLine("7) 7. Какая порода собак считается самой редкой и первоначально была выведена для использования в качестве ездовой собаки?");
        System.Console.WriteLine("8) 8. Какую породу собак вывели первоначально для охоты на барсуков в их норах?");
        System.Console.WriteLine("9) 9. Какая порода собак считается самой высокой?");
        System.Console.WriteLine("10) 10. Какая порода собак считается самой быстрой, потому что развивает максимальную скорость до 72 км/ч?");
        System.Console.WriteLine("0 End");

        int numTask = SetNumber("task");

        int SetNumber(string numberName)
        {
            Console.Write($"Введите номер вопроса {numberName}: ");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }

        switch (numTask)
        {
            case 0: break;
            case 1: QuestionOne(); break;
            case 2: QuestionTwo(); break;
            case 3: QuestionThree(); break;
            case 4: QuestionFour(); break;
            case 5: QuestionFive(); break;
            case 6: QuestionSix(); break;
            case 7: QuestionSeven(); break;
            case 8: QuestionEight(); break;
            case 9: QuestionNine(); break;
            case 10: QuestionTen(); break;
            default: System.Console.WriteLine("Error"); break;
        }

    }

}
void QuestionOne()
{
    Console.WriteLine("1. птица;");
    Console.WriteLine("2. кошка;");
    Console.WriteLine("3. собака");
    Console.WriteLine("4. лошадь;");
    int answer = Convert.ToInt32(Console.ReadLine());
    if (answer==3) Console.WriteLine("Ответ верный");
    else Console.WriteLine("Ответ неверный");
}


void QuestionTwo()
{
    Console.WriteLine("1. сибирская лайка;");
    Console.WriteLine("2. бордер колли;");
    Console.WriteLine("3. доберман;");
    Console.WriteLine("4. такса;");
    int answer = Convert.ToInt32(Console.ReadLine());
    if (answer == 1) Console.WriteLine("Ответ верный");
    else Console.WriteLine("Ответ неверный");
}

void QuestionThree()
{
    Console.WriteLine("1. у русской борзой;");
    Console.WriteLine("2. у спаниеля;");
    Console.WriteLine("3. у ньюфаундленда;");
    Console.WriteLine("4. у пекинеса;");
    int answer = Convert.ToInt32(Console.ReadLine());
    if (answer == 4) Console.WriteLine("Ответ верный");
    else Console.WriteLine("Ответ неверный");
}

void QuestionFour()
{
    Console.WriteLine("1. Сократ;");
    Console.WriteLine("2. Платон;");
    Console.WriteLine("3. Демокрит;");
    Console.WriteLine("4. Аристотель;");
    int answer = Convert.ToInt32(Console.ReadLine());
    if (answer == 2) Console.WriteLine("Ответ верный");
    else Console.WriteLine("Ответ неверный");
}

void QuestionFive()
{
    Console.WriteLine("1. Хатико;");
    Console.WriteLine("2. Балто;");
    Console.WriteLine("3. Лесси;");
    Console.WriteLine("4. Рекс;");
    int answer = Convert.ToInt32(Console.ReadLine());
    if (answer == 1) Console.WriteLine("Ответ верный");
    else Console.WriteLine("Ответ неверный");
}

void QuestionSix()
{
    Console.WriteLine("1. овчарок;");
    Console.WriteLine("2. боксеров;");
    Console.WriteLine("3. мастифов;");
    Console.WriteLine("4. догов;");
    int answer = Convert.ToInt32(Console.ReadLine());
    if (answer == 3) Console.WriteLine("Ответ верный");
    else Console.WriteLine("Ответ неверный");
}

void QuestionSeven()
{
    Console.WriteLine("1. чинук;");
    Console.WriteLine("2. хаски;");
    Console.WriteLine("3. той-терьер;");
    Console.WriteLine("4. хоккайдо;");
    int answer = Convert.ToInt32(Console.ReadLine());
    if (answer == 1) Console.WriteLine("Ответ верный");
    else Console.WriteLine("Ответ неверный");
}
void QuestionEight()
{
    Console.WriteLine("1. болонка;");
    Console.WriteLine("2. такса;");
    Console.WriteLine("3. бульдог;");
    Console.WriteLine("4. терьер;");
    int answer = Convert.ToInt32(Console.ReadLine());
    if (answer == 2) Console.WriteLine("Ответ верный");
    else Console.WriteLine("Ответ неверный");
}

void QuestionNine()
{
    Console.WriteLine("1. борзая;");
    Console.WriteLine("2. шарпей;");
    Console.WriteLine("3. португальская сторожевая;");
    Console.WriteLine("4. ирландский волкодав;");
    int answer = Convert.ToInt32(Console.ReadLine());
    if (answer == 4) Console.WriteLine("Ответ верный");
    else Console.WriteLine("Ответ неверный");
}
void QuestionTen()
{
    Console.WriteLine("1. овчарки;");
    Console.WriteLine("2. терьеры;");
    Console.WriteLine("3. борзые;");
    Console.WriteLine("4. хаски;");
    int answer = Convert.ToInt32(Console.ReadLine());
    if (answer == 3) Console.WriteLine("Ответ верный");
    else Console.WriteLine("Ответ неверный");
}
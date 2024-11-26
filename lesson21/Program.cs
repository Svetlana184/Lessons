//СТРУКТУРЫ И ПЕРЕЧИСЛЕНИЯ

//перечисления - определяемый пользователем целочисленный тип

void PrintMessage(DayTime dayTime)
{
    switch (dayTime)
    {
        case DayTime.Morning:
            Console.WriteLine("Доброе утро!");
            break;
        case DayTime.Evening:
            Console.WriteLine("Добрый вечер!");
            break;
        case DayTime.Night:
            Console.WriteLine("Доброй ночи!");
            break;
        case DayTime.Afternoon:
            Console.WriteLine("Добрый день!");
            break;
    }
}
void DoOperation(double x, double y, Operation Op)
{
    double result = Op switch
    {
        Operation.Add => x + y,
        Operation.Subtract => x - y,
        Operation.Multiply => x * y,
        Operation.Divide => x / y,

    };
    Console.WriteLine(result);
}

DayTime dayTime = DayTime.Morning;
if (dayTime == DayTime.Morning)
    Console.WriteLine("Доброе утро");
else
    Console.WriteLine("Привет");

PrintMessage(dayTime);
PrintMessage(DayTime.Evening);
DoOperation(10,5,Operation.Add);
DoOperation(10, 5, Operation.Multiply); 
DoOperation(10, 5, Operation.Subtract);
DoOperation(10, 5, Operation.Divide);


enum DayTime
{
    Morning,
    Afternoon,
    Evening,
    Night
}

enum Operation
{
    Add,
    Subtract,
    Multiply,
    Divide
}
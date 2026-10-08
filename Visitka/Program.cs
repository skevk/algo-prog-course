// Порог для получения стипендии 
const double StependiaMin = 4.0;

// Переменные разных типов
string fullName = "Измайлов Ярослав Эмильевич";
string groupName = "ИСП-254";
string specialnost = "09.02.07";
            
int course = 2;
int weeksLeft = 16;
            
// Оценки для расчета среднего балла
int grade1 = 5;
int grade2 = 3;
int grade3 = 4;

// Арифметический расчёт : Считаем средний балл
// Суммируем оценки и делим на их количество 
// Приводим к double, чтобы получить дробное число
double averageGrade = (grade1 + grade2 + grade3) / 3.0;

 // Проверяем, есть ли стипендия.
bool isStependia = averageGrade >= StependiaMin;

// Вывод
Console.WriteLine("========================================");
Console.WriteLine("       ВИЗИТНАЯ КАРТОЧКА СТУДЕНТА");
Console.WriteLine("========================================");

Console.WriteLine($"ФИО:           {fullName}");
Console.WriteLine($"Группа:        {groupName}");
Console.WriteLine($"Курс:          {course}");
Console.WriteLine($"Специальность: {specialnost}");
            
Console.WriteLine();
            
// Выводим средний балл
Console.WriteLine($"Средний балл за 3 работы: {averageGrade:F2}");
Console.WriteLine($"Стипендия положена (>= {StependiaMin}): {isStependia}");
            
Console.WriteLine();
            
Console.WriteLine($"Учебных недель осталось в семестре: {weeksLeft}");
Console.WriteLine("========================================");
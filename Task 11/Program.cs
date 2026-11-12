namespace Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Завдання 1
            Для масиву цілих реалізуйте такі запити:
            Отримати весь масив цілих;
            Отримати парні цілі;
            Отримати непарні цілі;
            Отримати значення більше заданого;
            Отримати числа в заданому діапазоні;
            Отримати числа кратні семи. Результат відсортувати за зростанням;
            Отримати числа кратні восьми. Результат відсортувати за спаданням.
            */

            Console.WriteLine("Task 1: ");
            List<int> arr1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 0};

            Console.Write("1: ");
            var t1_1 = arr1.Where(n => true);
            foreach (int i in t1_1) { Console.Write(i + " "); }

            Console.Write("\n2: ");
            var t1_2 = arr1.Where(n => n % 2 == 0);
            foreach (int i in t1_2) { Console.Write(i + " "); }

            Console.Write("\n3: ");
            var t1_3 = arr1.Where(n => n % 2 == 1);
            foreach (int i in t1_3) { Console.Write(i + " "); }

            Console.Write("\nInput number: ");
            int.TryParse(Console.ReadLine(), out int num1);
            Console.Write("4: ");
            var t1_4 = arr1.Where(n => n > num1);
            foreach (int i in t1_4) { Console.Write(i + " "); }

            Console.Write("\nInput number: ");
            int.TryParse(Console.ReadLine(), out int num2);
            Console.Write("Input number: ");
            int.TryParse(Console.ReadLine(), out int num3);
            Console.Write("5: ");
            var t1_5 = arr1.Where(n => num2 <= n && n <= num3);
            foreach (int i in t1_5) { Console.Write(i + " "); }

            Console.Write("\n6: ");
            var t1_6 = arr1.Where(n => n % 7 == 0).OrderBy(u => u).ToList(); ;
            foreach (int i in t1_6) { Console.Write(i + " "); }

            Console.Write("\n7: ");
            var t1_7 = arr1.Where(n => n % 8 == 0).OrderByDescending(u => u).ToList(); ;
            foreach (int i in t1_7) { Console.Write(i + " "); }

            /*
            Завдання 2
            Для масиву рядків, що містять назву міст, реалізуйте такі запити:
            Отримати весь масив міст;
            Отримати міста з довжиною назви, що дорівнює заданій;
            Отримати міста, назви яких починаються з літери A;
            Отримати міста, назви яких закінчуються літерою M;
            Отримати міста, назви яких починаються з літери N і закінчуються літерою K;
            Отримати міста назви яких починаються на Ne. Результат відсортувати за спаданням.
            */

            Console.WriteLine("\n\nTask 2: ");
            List<string> arr2 = new List<string> { "Odessa", "Kyiv", "Berlin", "Helsinki", "Teatm", "nK", "Arma", "Nern", "Nern12" };

            Console.Write("1: ");
            var t2_1 = arr2.Where(n => true);
            foreach (string i in t2_1) { Console.Write(i + " "); }

            Console.Write("\nInput lenght: ");
            int.TryParse(Console.ReadLine(), out int num4);
            Console.Write("2: ");
            var t2_2 = arr2.Where(n => n.Length > num4);
            foreach (string i in t2_2) { Console.Write(i + " "); }

            Console.Write("\n3: ");
            var t2_3 = arr2.Where(n => n[0] == 'A' || n[0] == 'a');
            foreach (string i in t2_3) { Console.Write(i + " "); }

            Console.Write("\n4: ");
            var t2_4 = arr2.Where(n => n[n.Length-1] == 'M' || n[n.Length - 1] == 'm');
            foreach (string i in t2_4) { Console.Write(i + " "); }

            Console.Write("\n5: ");
            var t2_5 = arr2.Where(n => (n[n.Length - 1] == 'k' || n[n.Length - 1] == 'K') && (n[0] == 'n' || n[0] == 'N'));
            foreach (string i in t2_5) { Console.Write(i + " "); }

            Console.Write("\n6: ");
            var t2_6 = arr2.Where(n => (n[0] == 'N' || n[0] == 'n') && (n[1] == 'E' || n[1] == 'e')).OrderByDescending(u => u).ToList();
            foreach (string i in t2_6) { Console.Write(i + " "); }
            /*
            Завдання 3
            Реалізуйте тип користувача "Студент". У ньому має бути інформація про ім'я, прізвище, вік, назву навчального закладу.
            Для масиву студентів реалізуйте такі запити:
            Отримати весь масив студентів;
            Отримати студентів з ім'ям Boris;
            Отримати студентів із прізвищем, яке починається з Bro;
            Отримати студентів, які старші за 19 років;
            Отримати студентів, які старше 20 років і молодше 23 років;
            Отримати студентів, які навчаються в MIT;
            Отримати студентів, які навчаються в Oxford і їхній вік старший за 18 років. Результат відсортувати за віком за спаданням.
            */

            Console.WriteLine("\n\nTask 3: ");
            List<Student> arr3 = new List<Student> { new Student("Boris", "Gman", 21, "MIT"),
                new Student("Artem", "Friman", 26, "Oxford"),
                new Student("Donald", "Tramp", 78, "Oxford") };

            Console.Write("1: ");
            var t3_1 = arr3.Where(n => true);
            foreach (Student i in t3_1) { Console.Write(i.Info() + "; "); }

            Console.Write("\n2: ");
            var t3_2 = arr3.Where(n => n.fName == "Boris");
            foreach (Student i in t3_2) { Console.Write(i.Info() + "; "); }

            Console.Write("\n3: ");
            var t3_3 = arr3.Where(n => n.sName.StartsWith("Bro"));
            foreach (Student i in t3_3) { Console.Write(i.Info() + "; "); }

            Console.Write("\n4: ");
            var t3_4 = arr3.Where(n => n.Age > 19);
            foreach (Student i in t3_4) { Console.Write(i.Info() + "; "); }

            Console.Write("\n5: ");
            var t3_5 = arr3.Where(n => n.Age > 20 && n.Age < 23);
            foreach (Student i in t3_5) { Console.Write(i.Info() + "; "); }

            Console.Write("\n6: ");
            var t3_6 = arr3.Where(n => n.University == "MIT");
            foreach (Student i in t3_6) { Console.Write(i.Info() + "; "); }

            Console.Write("\n7: ");
            var t3_7 = arr3.Where(n => n.University == "Oxford" && n.Age > 18).OrderByDescending(u => u.Age).ToList();
            foreach (Student i in t3_7) { Console.Write(i.Info() + "; "); }

            /*
            Завдання 4
            Для масиву рядків реалізуйте користувацьке сортування. 
            Сортування має працювати за кількістю символів (за зростанням і спаданням). 
            Наприклад, якщо сортування здійснюється за спаданням, потрібно повернути рядки з максимальною довжиною в порядку спадання довжини.
            */

            Console.WriteLine("\n\nTask 4: ");
            UserSort arr4 = new UserSort(new List<string> { "1", "12", "123", "1234" });
            Console.Write("1: ");
            foreach (string i in arr4.DescendingSort()) { Console.Write(i + " "); }
            Console.Write("\n2: ");
            foreach (string i in arr4.Sort()) { Console.Write(i + " "); }
        }
    }
}

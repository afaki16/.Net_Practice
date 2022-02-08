using System;

namespace Proje_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Solutions s = new Solutions();


            Lists lists = new Lists("todo app", "c sharp", 2, 1, 1);
            Lists lists1 = new Lists("contacts app", "c#", 1, 2, 2);
            Lists lists2 = new Lists("coderbyte challange", "c sharp", 1, 2);

            List<Lists> todoList = new List<Lists>();

            todoList.Add(lists);
            todoList.Add(lists1);
            todoList.Add(lists2);

            int operation = 0;
            do
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
                Console.WriteLine("*****************************************");
                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine("(3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak");
                Console.WriteLine("(5) Çıkış yapmak");

                operation = Convert.ToInt16(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        s.ViewTodoList(todoList);
                        break;
                    case 2:
                        s.AddTodo(todoList);
                        break;
                    case 3:
                        s.DeleteTodo(todoList);
                        break;
                    case 4:
                        s.UpdateStatus(todoList);
                        break;
                }
            } while (Convert.ToInt16(operation) != 5);

        }
    }
}

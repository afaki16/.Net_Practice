using System;

namespace Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz :");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı :" + a);
            }
            catch(Exception ex)
            {
                 Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem tamalandı");
            }
        
        }
    }
}

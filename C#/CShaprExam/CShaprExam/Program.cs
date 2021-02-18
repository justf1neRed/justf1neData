using System;

namespace TarasenkoCShaprExam
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Plane TestPlane = new Plane();
                TestPlane.PlaneFly();
            }
            catch (CrushExept e)
            {
                Console.WriteLine(e.Message); // ловим "самолет разбился"
            }
            catch(PenaltyExept e)
            {
                Console.WriteLine(e.Message); // ловим перебор очков штрафа
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message); // ловим любые другие эксепшены
            }
        }
    }
}

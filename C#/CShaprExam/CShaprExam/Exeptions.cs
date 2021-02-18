using System;
using System.Collections.Generic;
using System.Text;

namespace TarasenkoCShaprExam
{
    class CrushExept : Exception // Генерация ошибки "Самолёт разбился"
    {
        public CrushExept(string ShowMessage) : base(ShowMessage) { }
    }

    class PenaltyExept : Exception // Генерация ошибки "Перебор штрафных очков"
    {
        public PenaltyExept(string ShowMessage) : base(ShowMessage) { }
    }
}

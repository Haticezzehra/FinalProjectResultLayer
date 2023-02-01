using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{//Temel voidler için başlangıç.
    public interface IResult
    {
        //işlem sonucu ve kullanıcıyı bilgilendirme mesajı.
        bool Success { get; }
        string Message { get; }
    }
}

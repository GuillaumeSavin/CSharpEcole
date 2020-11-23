using System;

namespace Ecole
{
    //Classe d'Exception personnalisé
    public class ExceptionCustom : Exception
    {
        public class InvalideMoyenneHorsIntervalException : Exception
        {
            public InvalideMoyenneHorsIntervalException(Double fausseMoyenne) : base(string.Format("La moyenne rentré {0} n'est pas compris entre 0 et 20", fausseMoyenne)) { }
        }
        
        public class classePleineException : Exception
        {
            public classePleineException() : base(string.Format("La classe est pleine, vous ne pouvez pas rentré") ) { }
        }
    }
}
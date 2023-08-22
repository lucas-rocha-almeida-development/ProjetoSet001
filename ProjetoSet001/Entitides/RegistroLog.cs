using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSet001.Entitides
{
    internal class RegistroLog
    {
        public string UserName { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }
        public override bool Equals(object obj)
        {//programaçao defensiva, iremos testar se obj e do tipo Registro de log

            if(!(obj is RegistroLog))
            {//caso não seja ira retornar falso
                return false;
            }
               RegistroLog other = obj as RegistroLog;
            return UserName.Equals(other.UserName);
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Classe para padronizar o tipo Usuário
namespace Autentific.Classes
{
    public class Usuario
    {
        public string Id { get; set; }
        public string Nome { get; set; }    
        public string Email { get; set; }
        public string Celular { get; set; }
        public string CPF { get; set; } 
        public string Curso { get; set; }
        public string Periodo { get; set; }
        public string Senha { get; set; }        
        public string Codigo { get; set; }
    }
}

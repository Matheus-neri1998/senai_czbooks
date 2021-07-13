using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZ_Books_Web_API.ViewModels
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Informe o Email do usuário :)")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Informe o Senha do usuário :)")]
        public string Senha { get; set; }
    }
}

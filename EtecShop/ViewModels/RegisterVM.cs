using System.ComponentModel.DataAnnotations;

namespace EtecShop.ViewModels;

    public class RegisterVM
    {
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Por favor, informe o seu nome de usuário")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Por favor, informe o endereço de Email")]
        public string Email { get; set; }


        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "Por favor, informe a sua data de nascimento")]
        public DateTime Birthday { get; set; }


        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Por favor, informe a sua senha")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Senha")]
        [Required(ErrorMessage = "Por favor, confirme a sua senha")]
        public string ConfirmPassword { get; set; }
    }
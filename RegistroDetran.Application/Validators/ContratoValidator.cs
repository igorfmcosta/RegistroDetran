using FluentValidation;
using RegistroDetran.Application.DTOs.Contrato;

namespace RegistroDetran.Application.Validators
{
    public class ContratoValidator : AbstractValidator<Contrato>
    {
        public ContratoValidator()
        {
        }
    }
}

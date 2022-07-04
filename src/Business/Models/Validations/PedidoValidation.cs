using FluentValidation;

namespace Business.Models.Validations;

public class PedidoValidation : AbstractValidator<Pedido>
{
    public PedidoValidation()
    {
        RuleFor(c => c.UsuarioId)
            .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
            .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
    }
}

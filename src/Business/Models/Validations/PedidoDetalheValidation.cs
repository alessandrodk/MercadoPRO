using FluentValidation;

namespace Business.Models.Validations;

public class PedidoDetalheValidation : AbstractValidator<PedidoDetalhe>
{
    public PedidoDetalheValidation()
    {
        RuleFor(c => c.PedidoId)
            .GreaterThan(0).WithMessage("O campo {PropertyName} precisa ser fornecido");
         
    }
}

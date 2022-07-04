﻿using FluentValidation;

namespace Business.Models.Validations;

public class CategoriaValidation : AbstractValidator<Categoria>
{
    public CategoriaValidation()
    {
        RuleFor(c => c.Descricao)
            .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
            .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
    }
}

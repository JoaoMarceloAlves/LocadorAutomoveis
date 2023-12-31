﻿namespace LocadorAutomoveis.Dominio.ModuloAutomovel
{
    public class ValidadorAutomovel : AbstractValidator<Automovel>, IValidadorAutomovel
    {
        public ValidadorAutomovel()
        {
            RuleFor(x => x.Marca)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3);

            RuleFor(x => x.Modelo)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3);

            RuleFor(x => x.Cor)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3);

            RuleFor(x => x.Quilometragem)
                .GreaterThanOrEqualTo(0);

            RuleFor(x => x.Ano)
                .GreaterThan(0);

            RuleFor(x => x.Capacidade)
                .GreaterThan(0);

            RuleFor(x => x.Placa)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3);
        }
    }
}
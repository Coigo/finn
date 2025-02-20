using Movimentacoes.Models;

namespace Movimentacoes.DTOS;

public record BuscarPorPeriodoDTO (string inicio, string fim);

public record ListaMovimentacoesDTO (
    float valor,
    MovimentacaoTipo tipo,
    int categoria_id,
    DateTime criadoEm,
    DateTime? vencimento
);
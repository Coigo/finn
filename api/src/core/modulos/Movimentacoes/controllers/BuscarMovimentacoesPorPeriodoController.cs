using Microsoft.AspNetCore.Mvc;
using Movimentacoes.DTOS;
using Movimentacoes.Models;
using Movimentacoes.UseCases;

namespace Movimentacoes.Routes ;

[ApiController]
[Route("movimentacoes")]
public class BuscarMovimentacoesPorPeriodoController : ControllerBase {

    private readonly BuscarMovimentacoesUseCase UseCase;

    public BuscarMovimentacoesPorPeriodoController(BuscarMovimentacoesUseCase useCase) {
        UseCase = useCase;
    }

    [HttpGet]
    public async Task<List<ListaMovimentacoesDTO>> handle ([FromQuery] BuscarPorPeriodoDTO query) {
        
        var mov = await UseCase.Execute(query);
        return mov;
    }

}
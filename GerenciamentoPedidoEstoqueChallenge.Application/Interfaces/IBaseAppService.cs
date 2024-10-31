namespace GerenciamentoPedidoEstoqueChallenge.Application.Interfaces
{
    public interface IBaseAppService<TRequestModel, TResponseModel>
        where TRequestModel : class
    {
        TResponseModel Inserir(TRequestModel entity);
        TResponseModel Atualizar(int id, TRequestModel entity);
        TResponseModel Excluir(int id);
        List<TResponseModel> Listar();
        TResponseModel? Obter(int id);
    }
}

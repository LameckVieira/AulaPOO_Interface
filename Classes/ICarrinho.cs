namespace Classes
{
    public interface ICarrinho
    {
        // CRUD

        // CREATE - CADASTRAR
        void Cadastrar(Produto produto);

        // READ
        void Listar();

        //update
        void Alterar( int cod, Produto produto);

        //Deletar - Delete
        void Deletar(Produto produto);
    }
}
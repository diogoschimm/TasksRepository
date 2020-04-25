using TrabalhandoComTasks.Domain.Shared.Entities;
using TrabalhandoComTasks.Domain.ValueObjects;

namespace TrabalhandoComTasks.Domain.Entities
{
    public class Pessoa : Entity 
    {
        public Pessoa(string nomePessoa, Documento documento)
        {
            this.NomePessoa = nomePessoa;
            this.Documento = documento;

            this.Validar();
        }

        protected Pessoa() { }

        public int IdPessoa { get; private set; }
        public string NomePessoa { get; private set; }
        public Documento Documento { get; private set; }

        public int IdGrupoPessoa { get; private set; }
        public GrupoPessoa GrupoPessoa { get; private set; }


        public void SetIdPessoa(int idPessoa)
        {
            this.IdPessoa = idPessoa;
        }

        public void SetGrupoPessoa(GrupoPessoa grupo)
        {
            this.GrupoPessoa = grupo;
            this.IdGrupoPessoa = grupo.IdGrupoPessoa;
        }

        public void ModificarNome(string nomePessoa)
        {
            this.NomePessoa = nomePessoa;
        }

        public void ModificarDocumento(Documento documento)
        {
            this.Documento = documento;
        }

        public bool Validar()
        {
            return true;
        }
    }
}

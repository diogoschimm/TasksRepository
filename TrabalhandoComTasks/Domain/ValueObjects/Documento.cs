using TrabalhandoComTasks.Domain.Shared.ValueObjects;

namespace TrabalhandoComTasks.Domain.ValueObjects
{
    public class Documento : ValueObject
    {
        public Documento(string tipoDocumento, string numeroDocumento)
        {
            this.TipoDocumento = tipoDocumento;
            this.NumeroDocumento = numeroDocumento;

            this.Validar();
        }

        public string TipoDocumento { get; private set; }
        public string NumeroDocumento { get; private set; }

        public bool Validar()
        {
            return true;
        }
    }
}

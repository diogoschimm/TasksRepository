using TrabalhandoComTasks.Domain.Contracts.Repositories;

namespace TrabalhandoComTasks.UI
{
    public class GrupoPessoaUI
    {
        private readonly IGrupoPessoaRepository _grupoPessoaRepository;

        public GrupoPessoaUI(IGrupoPessoaRepository grupoPessoaRepository)
        {
            this._grupoPessoaRepository = grupoPessoaRepository;
        }

        public void Show()
        {
            var opcao = "";
            while (opcao != "X")
            {
                opcao = GenericUI.ShowOpcoes("Grupo de Pessoas");
                switch (opcao)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                }
            } 
        }
    }
}

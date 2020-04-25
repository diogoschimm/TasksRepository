using TrabalhandoComTasks.Domain.Contracts.Repositories;

namespace TrabalhandoComTasks.UI
{
    public class PessoaUI
    { 
        private readonly IPessoaRepository pessoaRepository;

        public PessoaUI(IPessoaRepository pessoaRepository)
        {
            this.pessoaRepository = pessoaRepository;
        }

        public void Show()
        {
            var opcao = "";
            while (opcao != "X")
            {
                opcao = GenericUI.ShowOpcoes("Pessoas");
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

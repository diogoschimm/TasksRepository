using System;
using System.Collections.Generic;
using System.Text;
using TrabalhandoComTasks.Domain.Shared.Entities;

namespace TrabalhandoComTasks.Domain.Entities
{
    public class GrupoPessoa : Entity
    {
        public GrupoPessoa(string nomeGrupo)
        {
            this.NomeGrupo = nomeGrupo;

            this.Validar();
        }

        public int IdGrupoPessoa { get; private set; }
        public string NomeGrupo { get; private set; }

        public ICollection<Pessoa> Pessoas { get;private set; }

        public void SetId(int id)
        {
            this.IdGrupoPessoa = id;
        } 

        public bool Validar()
        {
            return true;
        }
    }
}

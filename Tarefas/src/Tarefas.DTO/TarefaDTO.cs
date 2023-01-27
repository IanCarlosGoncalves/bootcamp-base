using System;

namespace Tarefas.DTO
{


    public class UsuarioDTO
    {
        public string Email {get; set;}
        public string Senha {get; set;}
        public string Nome {get; set;}
        public bool Ativo {get; set;}
    }

    public class TarefaDTO
    {
        public int Id { get; set; }

        public string? Titulo { get; set; }        

        public string? Descricao { get; set; }  

        public bool Concluida { get; set; }
    }
}

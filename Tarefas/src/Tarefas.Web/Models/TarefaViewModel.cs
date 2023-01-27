using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Tarefas.Web.Models;

public class TarefaViewModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "A descrição da tarefa deve ser preenchida.")]
    [MinLength(5,ErrorMessage = "A descrição deve ter no minimo 5 caracteres.")]
    [DisplayName("Título")]    

    public string? Titulo { get; set; }        
    [Required(ErrorMessage = "A descrição da tarefa deve ser preenchida.")]
    [MinLength(5,ErrorMessage = "A descrição deve ter no minimo 5 caracteres.")]
    [DisplayName("Descrição")]   

    public string? Descricao { get; set; }  
    [Required(ErrorMessage = "A descrição da tarefa deve ser preenchida.")]
    [MinLength(5,ErrorMessage = "A descrição deve ter no minimo 5 caracteres.")]
    [DisplayName("Concluída")]

    public bool Concluida { get; set; }
}
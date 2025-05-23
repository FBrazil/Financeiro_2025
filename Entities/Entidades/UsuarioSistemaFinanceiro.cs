﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entidades;

public class UsuarioSistemaFinanceiro : Base
{
    public int Id { get; set; }
    public string EmailUsuario { get; set; }    
    public bool Administrador { get; set; }
    public bool SistemaAtual {  get; set; }
   

    [ForeignKey("SistemaFinanceiro")]
    [Column(Order =1)]
    public int IdSistema { get; set; }
    public virtual SistemaFinanceiro SistemaFinanceiro { get; set; }
}

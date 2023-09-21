using System;  //Por causa da notação Flags

namespace DomainLayer.Models.Enums
{
    [Flags]  // 1 para n 

    public enum Habilidade
    {
        Desenvolvimento,
        Infraestrutura,
        BancoDeDados,
        SoftSkils
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosApp.Domain.Entities
{
    /// <summary>
    ///  Representa um pedido no sistema de pedidos.
    /// </summary>
    public class Pedido
    {
        public required Guid Id { get; set; }
        public required string Solicitante { get; set; }
        public required DateTime DataHora { get; set; }
        public required decimal Valor { get; set; }
        public required string Detalhes { get; set; }
        public required bool Ativo { get; set; }
    }

    /// <summary>
    /// Representa o status de um pedido.
    /// </summary>
    public enum Status
    {
        Pendente = 1,   
        Aprovado = 2,
        Rejeitado = 3,
    }
}

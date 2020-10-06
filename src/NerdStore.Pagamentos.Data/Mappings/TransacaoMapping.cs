using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NerdStore.Pagamentos.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Pagamentos.Data.Mappings
{
    public class TransacaoMapping : IEntityTypeConfiguration<Transacao>
    {
        public void Configure(EntityTypeBuilder<Transacao> builder)
        {
            builder.HasKey(c => c.Id);

            builder.ToTable("Transacoes");
        }
    }
}

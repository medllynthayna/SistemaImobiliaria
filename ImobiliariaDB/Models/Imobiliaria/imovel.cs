using System;
using System.Collections.Generic;

namespace ImobiliariaDB.Models.Imobiliaria
{
    public partial class imovel
    {
        public int idimovel { get; set; }
        public string? descricao { get; set; }
        public string? ds_estado { get; set; }
        public string? ds_cidade { get; set; }
        public string? ds_bairro { get; set; }
        public string? ds_logradouro { get; set; }
        public string? nr_endereco { get; set; }
        public string? ds_complemento { get; set; }
        public string? ds_nome_proprietario { get; set; }
        public string? ds_email { get; set; }
        public string? nr_cep { get; set; }
        public string? nr_telefone { get; set; }
        public decimal? vl_aluguel { get; set; }
    }
}

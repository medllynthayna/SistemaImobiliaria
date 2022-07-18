namespace SistemaImobiliaria.DTO
{
    public class ImovelDTO
    {
        public int ID_IMOVEL { get; set; }
        public string DESCRICAO { get; set; }
        public string DS_ESTADO { get; set; }
        public string DS_CIDADE { get; set; }
        public string DS_BAIRRO { get; set; }
        public string DS_LOGRADOURO { get; set; }
        public string NR_ENDERECO { get; set; }
        public string DS_COMPLEMENTO { get; set; }
        public string DS_NOME_PROPRIETARIO { get; set; }
        public string DS_EMAIL { get; set; }
        public string NR_CEP { get; set; }
        public string NR_TELEFONE { get; set; }
        public decimal? VL_ALUGUEL { get; set; }
    }
}

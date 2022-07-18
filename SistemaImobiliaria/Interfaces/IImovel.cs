using SistemaImobiliaria.DTO;

namespace SistemaImobiliaria.Interfaces
{
    public interface IImovel
    {
        public List<ImovelDTO> GetImovel();
        public void InsereImovel(ImovelDTO imovel);
        public ResponseViaCepDTO GetCep(string strCep);
        public void UpdateImovel(ImovelDTO imovel);
        public void DeleteImovel(int idImovel);
    }
}

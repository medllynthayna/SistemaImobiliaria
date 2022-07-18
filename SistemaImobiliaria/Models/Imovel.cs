using ImobiliariaDB.Models.Contexts;
using ImobiliariaDB.Models.Imobiliaria;
using SistemaImobiliaria.DTO;
using System;
using RestSharp;
using Newtonsoft.Json;

namespace SistemaImobiliaria.Models
{
    public class Imovel
    {
        //Conforme os métodos de padrão de projetos, vamos respeitar o padrão Pascal case.
        private dbimovelContext dbimovel = new dbimovelContext();

        public List<ImovelDTO> GetImovel()
        {
            try
            {
                List<ImovelDTO> imovel = (from i in dbimovel.imovels
                                          select new ImovelDTO
                                          {
                                              ID_IMOVEL = i.idimovel,
                                              DESCRICAO = i.descricao,
                                              DS_ESTADO = i.ds_estado,
                                              DS_CIDADE = i.ds_cidade,
                                              DS_BAIRRO = i.ds_bairro,
                                              DS_LOGRADOURO = i.ds_logradouro,
                                              NR_ENDERECO = i.nr_endereco,
                                              DS_COMPLEMENTO = i.ds_complemento,
                                              DS_NOME_PROPRIETARIO = i.ds_nome_proprietario,
                                              DS_EMAIL = i.ds_email,
                                              NR_CEP = i.nr_cep,
                                              NR_TELEFONE = i.nr_telefone,
                                              VL_ALUGUEL = i.vl_aluguel
                                          }).ToList();
                return imovel;
            }
            catch (Exception)
            {
                throw new Exception("Ops! Algo deu errado.");
            }
        }

        public void InsereImovel(ImovelDTO imovel)
        {
            try
            {
                imovel imove = new imovel();
                dbimovel = new dbimovelContext();
                imove.descricao = imovel.DESCRICAO;
                imove.ds_estado = imovel.DS_ESTADO;
                imove.ds_cidade = imovel.DS_CIDADE;
                imove.ds_bairro = imovel.DS_BAIRRO;
                imove.ds_logradouro = imovel.DS_LOGRADOURO;
                imove.nr_endereco = imovel.NR_ENDERECO;
                imove.ds_complemento = imovel.DS_COMPLEMENTO;
                imove.ds_nome_proprietario = imovel.DS_NOME_PROPRIETARIO;
                imove.ds_email = imovel.DS_EMAIL;
                imove.nr_cep = imovel.NR_CEP;
                imove.nr_telefone = imovel.NR_TELEFONE;
                imove.vl_aluguel = imovel.VL_ALUGUEL;
                dbimovel.imovels.Add(imove);
                dbimovel.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Ops! Algo deu errado");
            }

        }

        public void UpdateImovel(ImovelDTO imovel)
        {
            try
            {
                imovel imove = new imovel();
                dbimovel = new dbimovelContext();
                imove = dbimovel.imovels.Where(x => x.idimovel == imovel.ID_IMOVEL).FirstOrDefault();
                imove.descricao = imovel.DESCRICAO;
                imove.ds_estado = imovel.DS_ESTADO;
                imove.ds_cidade = imovel.DS_CIDADE;
                imove.ds_bairro = imovel.DS_BAIRRO;
                imove.ds_logradouro = imovel.DS_LOGRADOURO;
                imove.nr_endereco = imovel.NR_ENDERECO;
                imove.ds_complemento = imovel.DS_COMPLEMENTO;
                imove.ds_nome_proprietario = imovel.DS_NOME_PROPRIETARIO;
                imove.ds_email = imovel.DS_EMAIL;
                imove.nr_cep = imovel.NR_CEP;
                imove.nr_telefone = imovel.NR_TELEFONE;
                imove.vl_aluguel = imovel.VL_ALUGUEL;
                dbimovel.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Ops! Algo deu errado");
            }

        }

        public void DeleteImovel(int idImovel)
        {
            try
            {
                imovel imovel = new imovel();
                dbimovel = new dbimovelContext();
                imovel = dbimovel.imovels.Find(idImovel);
                dbimovel.imovels.Remove(imovel);
                dbimovel.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Ops! Algo deu errado");
            }

        }
        public ResponseViaCepDTO GetCep(string strCep)
        {
            try
            {

                RestClient client = new RestClient($"https://viacep.com.br/ws/{strCep}/json/");
                RestRequest request = new RestRequest();
                RestResponse responseAPI = client.Get(request);
                if(responseAPI.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return JsonConvert.DeserializeObject<ResponseViaCepDTO>(responseAPI.Content.ToString());
                }
                else
                {
                    throw new Exception($"Não foi possivel consultar o CEP: {strCep}, API Via Cep retornou com Status {responseAPI.StatusCode}, Response: {responseAPI.Content.ToString()} ");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }


    }
}

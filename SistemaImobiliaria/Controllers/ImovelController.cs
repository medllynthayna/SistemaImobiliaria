
using ImobiliariaDB.Models.Contexts;
using ImobiliariaDB.Models.Imobiliaria;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using SistemaImobiliaria.DTO;
using SistemaImobiliaria.Models;
using ResponseViaCepDTO = SistemaImobiliaria.DTO.ResponseViaCepDTO;

//using SistemaImobiliaria.Models;

namespace SistemaImobiliaria.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImovelController : ControllerBase
    {


        private dbimovelContext dbimovel = new dbimovelContext();

        [HttpGet]
        public ActionResult GetImovel()

        {
            try
            {
                Imovel imovel = new Imovel();
                List<ImovelDTO> imovelDTO = imovel.GetImovel();
                return StatusCode(200, imovelDTO);
            }
            catch (Exception)
            {
                return StatusCode(400, "Ops!Algo deu errado.");
            }


        }
        [HttpGet("GetCep")]
        public ActionResult GetCep(string strCep)
        {
            try
            {
                Imovel imovel = new Imovel();
                ResponseViaCepDTO response = imovel.GetCep(strCep);
                return StatusCode(200, response);
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }

        [HttpPost("InsereImovel")]
        public ActionResult InsereImovel(ImovelDTO imovelDTO)
        {
            try
            {
                Imovel imovel = new Imovel();
                imovel.InsereImovel(imovelDTO);

                return StatusCode(200, new { message = "Imovel criado com sucesso" });
            }
            catch (Exception)
            {
                return StatusCode(400, "Ops!Algo deu errado.");
            }
        }

        [HttpPut("UpdateImovel")]
        public ActionResult UpdateImovel(ImovelDTO imovelDTO)
        {
            try
            {
                Imovel imovel = new Imovel();
                imovel.UpdateImovel(imovelDTO);

                return StatusCode(200, new { message = "Imóvel  atualizado com sucesso." });
            }
            catch (Exception)
            {
                return StatusCode(400, "Ops!Algo deu errado.");
            }
        }
        [HttpDelete("DeletaImovel")]
        public ActionResult DeleteImovel(int IdImovel)
        {
            try
            {


                Imovel imovel = new Imovel();
                imovel.DeleteImovel(IdImovel);

                return StatusCode(200, new { message = "Imovel deletado com sucesso." });
            }
            catch (Exception)
            {
                return StatusCode(400, "Ops!Algo deu errado.");
            }
        }

    }

}
using ApiEnvio.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.ServiceBus;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Text;
using System.Threading.Tasks;

namespace ApiEnvio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EnvioController : ControllerBase
    {
        private readonly IOptions<ParametroConfig> configuration;
        public EnvioController(IOptions<ParametroConfig> configuration)
        {
            this.configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> Send([FromBody]Compra request)
        {
            string ruta = configuration.Value.BusUrl;
            string topicRuta = configuration.Value.BusTopic;

            string data = JsonConvert.SerializeObject(request);
            Message message = new Message(Encoding.UTF8.GetBytes(data));
            TopicClient client = new TopicClient(ruta, topicRuta);

            try
            {
                await client.SendAsync(message);
                return Ok(new { msje = "Datos procesados" });
            }
            catch (Exception ex)
            {
                //ex
                return Ok(new { msje = "Error al procesar " + ex.Message });
            }

        }
    }
}
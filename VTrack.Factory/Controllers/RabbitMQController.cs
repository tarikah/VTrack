using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;
using System.Text;

namespace VTrack.Factory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RabbitMQController : ControllerBase
    {
        [HttpGet]
        public ActionResult PublishEvent()
        {
            var factory = new ConnectionFactory() { HostName = "localhost", Port = 5672 };

            try
            {
                using (  var conn = factory.CreateConnection())
                using (var _channel=conn.CreateModel())
                {
                    _channel.ExchangeDeclare(exchange: "trigger", type: ExchangeType.Fanout);

                    conn.ConnectionShutdown += RabbitMQ_ConnectionShutdown;

                    Console.WriteLine("--> Connected to MessageBus");
                    var body = Encoding.UTF8.GetBytes("test");

                    _channel.BasicPublish(exchange: "trigger",
                                    routingKey: "",
                                    basicProperties: null,
                                    body: body);

                    Console.WriteLine($"--> We have sent message");

                }
                
            }
            catch (Exception)
            {

                throw;
            }
            return Ok();
        }
        private void RabbitMQ_ConnectionShutdown(object sender, ShutdownEventArgs e)
        {
            Console.WriteLine("--> RabbitMQ Connection Shutdown");
        }
    }
}

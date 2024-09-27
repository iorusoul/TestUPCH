using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace upch.test
{
    //maneja respuestas con el patron de respuesta generica
    public class RespuestaJson
    {

        public async Task<IActionResult> Error(Exception ex,int statusError, string functionName = "Error")
        {
            var respuesta = new RespuestaGenerica<object>();

            respuesta.TieneError = true;
            respuesta.CodigoError = "error"; //Deberiamos guardar en el logger el detalle - TO-DO
//#if DEBUG //solo mostramos el stack trace en depuracion...
            respuesta.MensajeError = ex.Message;
//#endif
            //return respuesta.ToOkObjectResult();
            return new ContentResult
            {
                Content = JsonSerializer.Serialize(respuesta),
                StatusCode = 200,
                ContentType = "application/json"
            };
        }

        public IActionResult Ok<T>(T value)
        {
            return new ContentResult
            {
                Content = JsonSerializer.Serialize(value),
                StatusCode = 200,
                ContentType = "application/json"
            };
        }

        public IActionResult Ok()
        {
            return new ContentResult
            {
                Content = "OK",
                StatusCode = 200,
                ContentType = "application/json"
            };
        }
    }
}

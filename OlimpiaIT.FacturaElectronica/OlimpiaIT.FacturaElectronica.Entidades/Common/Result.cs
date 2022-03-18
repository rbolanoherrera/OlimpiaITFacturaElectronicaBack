using System.Net;

namespace OlimpiaIT.FacturaElectronica.Entidades.Common
{
    public partial class Result<T>
    {
        /// <summary>
        /// Status Code of a logic process.
        /// </summary>
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;
        /// <summary>
        /// Message of a logic process.
        /// </summary>
        public string MessageCode { get; set; }
        public string Message { get; set; }

        public string JWTToken { get; set; }

        /// <summary>
        /// Data of a logic process.
        /// </summary>
        public T Data { get; set; }
    }
}

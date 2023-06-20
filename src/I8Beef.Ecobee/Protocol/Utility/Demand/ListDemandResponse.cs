using System.Collections.Generic;
using I8Beef.Ecobee.Protocol.Objects;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Utility.Demand
{
    /// <summary>
    /// Ecobee API list demand response.
    /// </summary>
    public class ListDemandResponse : Response
    {
        /// <summary>
        /// list of demand responses which have not yet expired.
        /// </summary>
        [JsonPropertyName("drList")]
        public IList<DemandResponse> DrList { get; set; }
    }
}

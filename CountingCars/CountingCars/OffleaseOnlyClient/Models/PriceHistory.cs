﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace OffleaseOnly.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class PriceHistory
    {
        /// <summary>
        /// Initializes a new instance of the PriceHistory class.
        /// </summary>
        public PriceHistory() { }

        /// <summary>
        /// Initializes a new instance of the PriceHistory class.
        /// </summary>
        public PriceHistory(string vin = default(string), IList<Price> prices = default(IList<Price>))
        {
            Vin = vin;
            Prices = prices;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "vin")]
        public string Vin { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "prices")]
        public IList<Price> Prices { get; set; }

    }
}

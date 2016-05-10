﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mollie.Api.Models.Mandate
{
    public class MandateResponse
    {
        /// <summary>
        /// Unique identifier of you mandate.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Current status of mandate.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public MandateStatus Status { get; set; }

        /// <summary>
        /// DateTime when mandate was created.
        /// </summary>
        public DateTime? CreatedDatetime { get; set; }

    }
}

using System;
using Newtonsoft.Json;
using SignNow.Net.Internal.Helpers.Converters;

namespace SignNow.Net.Internal.Model.FieldTypes
{
    /// <summary>
    /// Represents SignNow field types: `Hyperlink`
    /// </summary>
    internal class HyperlinkField : BaseField
    {
        /// <summary>
        /// Hyperlink label.
        /// </summary>
        [JsonProperty("label")]
        public string Label {get; set; }

        /// <summary>
        /// Hyperlink field value <see cref="Uri"/>
        /// </summary>
        [JsonProperty("data")]
        [JsonConverter(typeof(StringToUriJsonConverter))]
        public Uri Data { get; set; }

        /// <summary>
        /// Returns Hyperlink content as <see cref="Uri"/> string.
        /// </summary>
        public override string ToString() => Data.OriginalString;
    }
}

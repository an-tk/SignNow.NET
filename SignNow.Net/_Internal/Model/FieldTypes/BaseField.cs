using Newtonsoft.Json;

namespace SignNow.Net.Internal.Model.FieldTypes
{
    /// <summary>
    /// Basic SignNow field.
    /// </summary>
    internal abstract class BaseField
    {
        /// <summary>
        /// Identity of field.
        /// </summary>
        [JsonProperty("id")]
        public string Id  {get; set; }

        /// <summary>
        /// Identity of User which fulfilled the field.
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}

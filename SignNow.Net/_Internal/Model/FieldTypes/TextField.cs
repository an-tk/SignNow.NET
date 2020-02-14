using Newtonsoft.Json;

namespace SignNow.Net.Internal.Model.FieldTypes
{
    /// <summary>
    /// Represents SignNow field types: `Text box`, `Dropdown box`, `Date-Time picker`
    /// </summary>
    internal class TextField : BaseField
    {
        /// <summary>
        /// Email of user who fulfilled the field.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Raw text value of the field.
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }

        /// <summary>
        /// Returns field value of <see cref="Data"/>
        /// </summary>
        public override string ToString() => Data;
    }
}

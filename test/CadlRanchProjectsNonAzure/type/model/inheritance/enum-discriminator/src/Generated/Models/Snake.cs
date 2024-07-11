// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Scm._Type.Model.Inheritance.EnumDiscriminator.Models
{
    /// <summary>
    /// Test fixed enum type for discriminator
    /// Please note <see cref="Snake"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="Cobra"/>.
    /// </summary>
    public abstract partial class Snake
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="Snake"/>. </summary>
        /// <param name="length"> Length of the snake. </param>
        protected Snake(int length)
        {
            Length = length;
        }

        /// <summary> Initializes a new instance of <see cref="Snake"/>. </summary>
        /// <param name="kind"> discriminator property. </param>
        /// <param name="length"> Length of the snake. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Snake(SnakeKind kind, int length, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Kind = kind;
            Length = length;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="Snake"/> for deserialization. </summary>
        internal Snake()
        {
        }

        /// <summary> discriminator property. </summary>
        internal SnakeKind Kind { get; set; }
        /// <summary> Length of the snake. </summary>
        public int Length { get; set; }
    }
}

namespace sdc5
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class SdhlDezClass
    {
        [JsonProperty("UID", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        [JsonProperty("LAG", NullValueHandling = NullValueHandling.Ignore)]
        public string Lag { get; set; }

        [JsonProperty("DESCRIPTION", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("LOCATION", NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        [JsonProperty("TID", NullValueHandling = NullValueHandling.Ignore)]
        public string Tid { get; set; }

        [JsonProperty("DTEND", NullValueHandling = NullValueHandling.Ignore)]
        public string Dtend { get; set; }

        [JsonProperty("DTSTAMP", NullValueHandling = NullValueHandling.Ignore)]
        public Dtstamp? Dtstamp { get; set; }

        [JsonProperty("URL", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("GEO", NullValueHandling = NullValueHandling.Ignore)]
        public Geo? Geo { get; set; }
    }

    public enum Dtstamp { The20190620T103825Z };

    public enum Geo { The5778737714232277, The584174156356, The5929468718081672, The6069095617132535, The6073500814986417, The6328377618724952, The6559780722148331 };

    public partial class SdhlDezClass
    {
        public static SdhlDezClass[] FromJson(string json) => JsonConvert.DeserializeObject<SdhlDezClass[]>(json, sdc5.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this SdhlDezClass[] self) => JsonConvert.SerializeObject(self, sdc5.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                DtstampConverter.Singleton,
                GeoConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class DtstampConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Dtstamp) || t == typeof(Dtstamp?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "20190620T103825Z")
            {
                return Dtstamp.The20190620T103825Z;
            }
            throw new Exception("Cannot unmarshal type Dtstamp");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Dtstamp)untypedValue;
            if (value == Dtstamp.The20190620T103825Z)
            {
                serializer.Serialize(writer, "20190620T103825Z");
                return;
            }
            throw new Exception("Cannot marshal type Dtstamp");
        }

        public static readonly DtstampConverter Singleton = new DtstampConverter();
    }

    internal class GeoConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Geo) || t == typeof(Geo?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "57.787377;14.232277":
                    return Geo.The5778737714232277;
                case "58.4174;15.6356":
                    return Geo.The584174156356;
                case "59.294687;18.081672":
                    return Geo.The5929468718081672;
                case "60.690956;17.132535":
                    return Geo.The6069095617132535;
                case "60.735008;14.986417":
                    return Geo.The6073500814986417;
                case "63.283776;18.724952":
                    return Geo.The6328377618724952;
                case "65.597807;22.148331":
                    return Geo.The6559780722148331;
            }
            throw new Exception("Cannot unmarshal type Geo");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Geo)untypedValue;
            switch (value)
            {
                case Geo.The5778737714232277:
                    serializer.Serialize(writer, "57.787377;14.232277");
                    return;
                case Geo.The584174156356:
                    serializer.Serialize(writer, "58.4174;15.6356");
                    return;
                case Geo.The5929468718081672:
                    serializer.Serialize(writer, "59.294687;18.081672");
                    return;
                case Geo.The6069095617132535:
                    serializer.Serialize(writer, "60.690956;17.132535");
                    return;
                case Geo.The6073500814986417:
                    serializer.Serialize(writer, "60.735008;14.986417");
                    return;
                case Geo.The6328377618724952:
                    serializer.Serialize(writer, "63.283776;18.724952");
                    return;
                case Geo.The6559780722148331:
                    serializer.Serialize(writer, "65.597807;22.148331");
                    return;
            }
            throw new Exception("Cannot marshal type Geo");
        }

        public static readonly GeoConverter Singleton = new GeoConverter();
    }
}

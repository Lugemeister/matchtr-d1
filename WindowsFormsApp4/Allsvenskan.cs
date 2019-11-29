namespace sdc4
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AllsvenskanDezClass
    {
        [JsonProperty("UID", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        [JsonProperty("LAG", NullValueHandling = NullValueHandling.Ignore)]
        public string Lag { get; set; }

        [JsonProperty("DESCRIPTION", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("LOCATION", NullValueHandling = NullValueHandling.Ignore)]
        public Location? Location { get; set; }

        [JsonProperty("TID", NullValueHandling = NullValueHandling.Ignore)]
        public string Tid { get; set; }

        [JsonProperty("DTEND", NullValueHandling = NullValueHandling.Ignore)]
        public string Dtend { get; set; }

        [JsonProperty("DTSTAMP", NullValueHandling = NullValueHandling.Ignore)]
        public Dtstamp? Dtstamp { get; set; }

        [JsonProperty("URL", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }

        [JsonProperty("GEO", NullValueHandling = NullValueHandling.Ignore)]
        public Geo? Geo { get; set; }
    }

    public enum Dtstamp { The20190523T142247Z };

    public enum Geo { The585878161403, The5929468718081672, The6100014550, The625058331735, The6328377618724952, The6381543020242025 };

    public enum Location { A3Arena, AbbArena, FjällrävenCenter, Gränbyhallen, Himmelstalundshallen, Hovet, JalasArena, KristianstadsIshall, NelsonGardenArena, NhkArena, NktArenaKarlskrona, Nobelhallen, PlivitArena, Scaniarinken };

    public partial class AllsvenskanDezClass
    {
        public static AllsvenskanDezClass[] FromJson(string json) => JsonConvert.DeserializeObject<AllsvenskanDezClass[]>(json, sdc4.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this AllsvenskanDezClass[] self) => JsonConvert.SerializeObject(self, sdc4.Converter.Settings);
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
                LocationConverter.Singleton,
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
            if (value == "20190523T142247Z")
            {
                return Dtstamp.The20190523T142247Z;
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
            if (value == Dtstamp.The20190523T142247Z)
            {
                serializer.Serialize(writer, "20190523T142247Z");
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
                case "58.5878;16.1403":
                    return Geo.The585878161403;
                case "59.294687;18.081672":
                    return Geo.The5929468718081672;
                case "61.000;14.550":
                    return Geo.The6100014550;
                case "62.505833;17.35":
                    return Geo.The625058331735;
                case "63.283776;18.724952":
                    return Geo.The6328377618724952;
                case "63.815430;20.242025":
                    return Geo.The6381543020242025;
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
                case Geo.The585878161403:
                    serializer.Serialize(writer, "58.5878;16.1403");
                    return;
                case Geo.The5929468718081672:
                    serializer.Serialize(writer, "59.294687;18.081672");
                    return;
                case Geo.The6100014550:
                    serializer.Serialize(writer, "61.000;14.550");
                    return;
                case Geo.The625058331735:
                    serializer.Serialize(writer, "62.505833;17.35");
                    return;
                case Geo.The6328377618724952:
                    serializer.Serialize(writer, "63.283776;18.724952");
                    return;
                case Geo.The6381543020242025:
                    serializer.Serialize(writer, "63.815430;20.242025");
                    return;
            }
            throw new Exception("Cannot marshal type Geo");
        }

        public static readonly GeoConverter Singleton = new GeoConverter();
    }

    internal class LocationConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Location) || t == typeof(Location?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "A3 Arena":
                    return Location.A3Arena;
                case "ABB Arena":
                    return Location.AbbArena;
                case "Fjällräven Center":
                    return Location.FjällrävenCenter;
                case "Gränbyhallen":
                    return Location.Gränbyhallen;
                case "Himmelstalundshallen":
                    return Location.Himmelstalundshallen;
                case "Hovet":
                    return Location.Hovet;
                case "JALAS Arena":
                    return Location.JalasArena;
                case "Kristianstads Ishall":
                    return Location.KristianstadsIshall;
                case "NHK Arena":
                    return Location.NhkArena;
                case "NKT Arena Karlskrona":
                    return Location.NktArenaKarlskrona;
                case "Nelson Garden Arena":
                    return Location.NelsonGardenArena;
                case "Nobelhallen":
                    return Location.Nobelhallen;
                case "Plivit Arena":
                    return Location.PlivitArena;
                case "Scaniarinken":
                    return Location.Scaniarinken;
            }
            throw new Exception("Cannot unmarshal type Location");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Location)untypedValue;
            switch (value)
            {
                case Location.A3Arena:
                    serializer.Serialize(writer, "A3 Arena");
                    return;
                case Location.AbbArena:
                    serializer.Serialize(writer, "ABB Arena");
                    return;
                case Location.FjällrävenCenter:
                    serializer.Serialize(writer, "Fjällräven Center");
                    return;
                case Location.Gränbyhallen:
                    serializer.Serialize(writer, "Gränbyhallen");
                    return;
                case Location.Himmelstalundshallen:
                    serializer.Serialize(writer, "Himmelstalundshallen");
                    return;
                case Location.Hovet:
                    serializer.Serialize(writer, "Hovet");
                    return;
                case Location.JalasArena:
                    serializer.Serialize(writer, "JALAS Arena");
                    return;
                case Location.KristianstadsIshall:
                    serializer.Serialize(writer, "Kristianstads Ishall");
                    return;
                case Location.NhkArena:
                    serializer.Serialize(writer, "NHK Arena");
                    return;
                case Location.NktArenaKarlskrona:
                    serializer.Serialize(writer, "NKT Arena Karlskrona");
                    return;
                case Location.NelsonGardenArena:
                    serializer.Serialize(writer, "Nelson Garden Arena");
                    return;
                case Location.Nobelhallen:
                    serializer.Serialize(writer, "Nobelhallen");
                    return;
                case Location.PlivitArena:
                    serializer.Serialize(writer, "Plivit Arena");
                    return;
                case Location.Scaniarinken:
                    serializer.Serialize(writer, "Scaniarinken");
                    return;
            }
            throw new Exception("Cannot marshal type Location");
        }

        public static readonly LocationConverter Singleton = new LocationConverter();
    }
}

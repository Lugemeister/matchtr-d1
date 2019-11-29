
namespace sdc3
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class ShlDezClass
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
        public string Url { get; set; }

        [JsonProperty("GEO", NullValueHandling = NullValueHandling.Ignore)]
        public Geo? Geo { get; set; }
    }

    public enum Dtstamp { The20190923T165014Z };

    public enum Geo { The5556412975, The5622583312845, The5687946814772491, The576774421193583, The576989511987928, The5778737714232277, The584174156356, The5926620915226142, The592933518083131, The5929468718081672, The594075313500652, The6069095617132535, The6073500814986417, The6476112720967386, The6559780722148331 };

    public enum Location { BeGeHockeyCenter, BehrnArena, CatenaArena, CoopNorrbottenArena, EricssonGlobe, FrölundaborgsIsstadion, Hovet, KinnarpsArena, LöfbergsArena, MalmöArena, MonitorErpArena, SaabArena, Scandinavium, SkellefteåKraftArena, TegeraArena, VidaArena };

    public partial class ShlDezClass
    {
        public static ShlDezClass[] FromJson(string json) => JsonConvert.DeserializeObject<ShlDezClass[]>(json, sdc3.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this ShlDezClass[] self) => JsonConvert.SerializeObject(self, sdc3.Converter.Settings);
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
            if (value == "20190923T165014Z")
            {
                return Dtstamp.The20190923T165014Z;
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
            if (value == Dtstamp.The20190923T165014Z)
            {
                serializer.Serialize(writer, "20190923T165014Z");
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
                case "55.564;12.975":
                    return Geo.The5556412975;
                case "56.225833;12.845":
                    return Geo.The5622583312845;
                case "56.879468;14.772491":
                    return Geo.The5687946814772491;
                case "57.677442;11.93583":
                    return Geo.The576774421193583;
                case "57.69895;11.987928":
                    return Geo.The576989511987928;
                case "57.787377;14.232277":
                    return Geo.The5778737714232277;
                case "58.4174;15.6356":
                    return Geo.The584174156356;
                case "59.266209;15.226142":
                    return Geo.The5926620915226142;
                case "59.29335;18.083131":
                    return Geo.The592933518083131;
                case "59.294687;18.081672":
                    return Geo.The5929468718081672;
                case "59.40753;13.500652":
                    return Geo.The594075313500652;
                case "60.690956;17.132535":
                    return Geo.The6069095617132535;
                case "60.735008;14.986417":
                    return Geo.The6073500814986417;
                case "64.761127;20.967386":
                    return Geo.The6476112720967386;
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
                case Geo.The5556412975:
                    serializer.Serialize(writer, "55.564;12.975");
                    return;
                case Geo.The5622583312845:
                    serializer.Serialize(writer, "56.225833;12.845");
                    return;
                case Geo.The5687946814772491:
                    serializer.Serialize(writer, "56.879468;14.772491");
                    return;
                case Geo.The576774421193583:
                    serializer.Serialize(writer, "57.677442;11.93583");
                    return;
                case Geo.The576989511987928:
                    serializer.Serialize(writer, "57.69895;11.987928");
                    return;
                case Geo.The5778737714232277:
                    serializer.Serialize(writer, "57.787377;14.232277");
                    return;
                case Geo.The584174156356:
                    serializer.Serialize(writer, "58.4174;15.6356");
                    return;
                case Geo.The5926620915226142:
                    serializer.Serialize(writer, "59.266209;15.226142");
                    return;
                case Geo.The592933518083131:
                    serializer.Serialize(writer, "59.29335;18.083131");
                    return;
                case Geo.The5929468718081672:
                    serializer.Serialize(writer, "59.294687;18.081672");
                    return;
                case Geo.The594075313500652:
                    serializer.Serialize(writer, "59.40753;13.500652");
                    return;
                case Geo.The6069095617132535:
                    serializer.Serialize(writer, "60.690956;17.132535");
                    return;
                case Geo.The6073500814986417:
                    serializer.Serialize(writer, "60.735008;14.986417");
                    return;
                case Geo.The6476112720967386:
                    serializer.Serialize(writer, "64.761127;20.967386");
                    return;
                case Geo.The6559780722148331:
                    serializer.Serialize(writer, "65.597807;22.148331");
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
                case "Be-Ge Hockey Center":
                    return Location.BeGeHockeyCenter;
                case "Behrn Arena":
                    return Location.BehrnArena;
                case "Catena Arena":
                    return Location.CatenaArena;
                case "Coop Norrbotten Arena":
                    return Location.CoopNorrbottenArena;
                case "Ericsson Globe":
                    return Location.EricssonGlobe;
                case "Frölundaborgs Isstadion":
                    return Location.FrölundaborgsIsstadion;
                case "Hovet":
                    return Location.Hovet;
                case "Kinnarps Arena":
                    return Location.KinnarpsArena;
                case "Löfbergs Arena":
                    return Location.LöfbergsArena;
                case "Malmö Arena":
                    return Location.MalmöArena;
                case "Monitor ERP Arena":
                    return Location.MonitorErpArena;
                case "Saab Arena":
                    return Location.SaabArena;
                case "Scandinavium":
                    return Location.Scandinavium;
                case "Skellefteå Kraft Arena":
                    return Location.SkellefteåKraftArena;
                case "Tegera Arena":
                    return Location.TegeraArena;
                case "Vida Arena":
                    return Location.VidaArena;
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
                case Location.BeGeHockeyCenter:
                    serializer.Serialize(writer, "Be-Ge Hockey Center");
                    return;
                case Location.BehrnArena:
                    serializer.Serialize(writer, "Behrn Arena");
                    return;
                case Location.CatenaArena:
                    serializer.Serialize(writer, "Catena Arena");
                    return;
                case Location.CoopNorrbottenArena:
                    serializer.Serialize(writer, "Coop Norrbotten Arena");
                    return;
                case Location.EricssonGlobe:
                    serializer.Serialize(writer, "Ericsson Globe");
                    return;
                case Location.FrölundaborgsIsstadion:
                    serializer.Serialize(writer, "Frölundaborgs Isstadion");
                    return;
                case Location.Hovet:
                    serializer.Serialize(writer, "Hovet");
                    return;
                case Location.KinnarpsArena:
                    serializer.Serialize(writer, "Kinnarps Arena");
                    return;
                case Location.LöfbergsArena:
                    serializer.Serialize(writer, "Löfbergs Arena");
                    return;
                case Location.MalmöArena:
                    serializer.Serialize(writer, "Malmö Arena");
                    return;
                case Location.MonitorErpArena:
                    serializer.Serialize(writer, "Monitor ERP Arena");
                    return;
                case Location.SaabArena:
                    serializer.Serialize(writer, "Saab Arena");
                    return;
                case Location.Scandinavium:
                    serializer.Serialize(writer, "Scandinavium");
                    return;
                case Location.SkellefteåKraftArena:
                    serializer.Serialize(writer, "Skellefteå Kraft Arena");
                    return;
                case Location.TegeraArena:
                    serializer.Serialize(writer, "Tegera Arena");
                    return;
                case Location.VidaArena:
                    serializer.Serialize(writer, "Vida Arena");
                    return;
            }
            throw new Exception("Cannot marshal type Location");
        }

        public static readonly LocationConverter Singleton = new LocationConverter();
    }
}

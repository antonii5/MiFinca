using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiFinca.Clases
{
    public class GoogleGeocodeResponseApi
    {
        public string Status { get; set; }
        public List<Result> Results { get; set; }

        public class AddressComponent
        {
            [JsonProperty("longName")]
            public string LongName { get; set; }

            [JsonProperty("shortName")]
            public string ShortName { get; set; }

            [JsonProperty("types")]
            public List<string> Types { get; set; }

            [JsonProperty("additionalProperties")]
            public Dictionary<string, object> AdditionalProperties { get; set; }
        }

        public class Bounds
        {
            [JsonProperty("northeast")]
            public Northeast Northeast { get; set; }

            [JsonProperty("southwest")]
            public Southwest Southwest { get; set; }

            [JsonProperty("additionalProperties")]
            public Dictionary<string, object> AdditionalProperties { get; set; }
        }

        public class Geometry
        {
            [JsonProperty("bounds")]
            public Bounds Bounds;

            [JsonProperty("location")]
            public Location Location;

            [JsonProperty("location_type")]
            public string LocationType;

            [JsonProperty("viewport")]
            public Viewport Viewport;

            [JsonProperty("additionalProperties")]
            public Dictionary<string, object> AdditionalProperties { get; set; }
        }

        public class GoogleGeocodeResponse
        {
            [JsonProperty("results")]
            public List<Result> Results { get; set; }

            [JsonProperty("status")]
            public string Status { get; set; }

            [JsonProperty("additionalProperties")]
            public Dictionary<string, object> AdditionalProperties { get; set; }
        }

        public class Location
        {
            [JsonProperty("lat")]
            public double Lat { get; set; }

            [JsonProperty("lng")]
            public double Lng { get; set; }

            [JsonProperty("additionalProperties")]
            public Dictionary<string, object> AdditionalProperties { get; set; }
        }

        public class Northeast
        {
            [JsonProperty("lat")]
            public double Lat { get; set; }

            [JsonProperty("lng")]
            public double Lng { get; set; }

            [JsonProperty("additionalProperties")]
            public Dictionary<string, object> AdditionalProperties { get; set; }
        }

        public class Northeast_
        {
            [JsonProperty("lat")]
            public double Lat { get; set; }

            [JsonProperty("lng")]
            public double Lng { get; set; }

            [JsonProperty("additionalProperties")]
            public Dictionary<string, object> AdditionalProperties { get; set; }
        }

        public class Result
        {
            [JsonProperty("address_components")]
            public List<AddressComponent> AddressComponents { get; set; }

            [JsonProperty("formatted_address")]
            public string FormattedAddress { get; set; }

            [JsonProperty("geometry")]
            public Geometry Geometry { get; set; }

            [JsonProperty("place_id")]
            public string PlaceId { get; set; }

            [JsonProperty("types")]
            public List<string> Types { get; set; }

            [JsonProperty("additionalProperties")]
            public Dictionary<string, object> AdditionalProperties { get; set; }
        }

        public class Southwest
        {
            [JsonProperty("lat")]
            public double Lat { get; set; }

            [JsonProperty("lng")]
            public double Lng { get; set; }

            [JsonProperty("additionalProperties")]
            public Dictionary<string, object> AdditionalProperties { get; set; }
        }

        public class Southwest_
        {
            [JsonProperty("lat")]
            public double Lat { get; set; }

            [JsonProperty("lng")]
            public double Lng { get; set; }

            [JsonProperty("additionalProperties")]
            public Dictionary<string, object> AdditionalProperties { get; set; }
        }

        public class Viewport
        {
            [JsonProperty("northeast")]
            public Northeast_ Northeast { get; set; }

            [JsonProperty("southwest")]
            public Southwest_ Southwest { get; set; }

            [JsonProperty("additionalProperties")]
            public Dictionary<string, object> AdditionalProperties { get; set; }
        }
    }
}

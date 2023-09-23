﻿using DJIControlClient.Exceptions;
using System.Text.Json.Serialization;

namespace DJIControlClient
{
    public partial class CommandCompleted
    {
        [JsonPropertyName("completed")]
        public bool Completed { get; set; }

        [JsonPropertyName("errorDescription")]
        public string? ErrorDescription { get; set; }
    }

    public partial class CommandCompleted
    {
        public Exception ParseError()
        {
            // case isnt consistent in errors so i'm force lowering them
            string err = ErrorDescription?.ToLower() ?? string.Empty;

            return err switch
            {
                { } when err.StartsWith("not available") => new NotAvailableException(ErrorDescription),
                { } when err.StartsWith("reboot error: ") => new RebootException(ErrorDescription[14..]),
                { } when err.StartsWith("invalid value for interval") => new ArgumentException(ErrorDescription),
                { } when err.Contains("no") && err.Contains("provided") => new ArgumentException(ErrorDescription),
                { } when err.Contains("missing") && err.Contains("value") => new ArgumentException(ErrorDescription),
                { } when err.StartsWith("profile must be either") => new ArgumentException(ErrorDescription),
                { } when err.StartsWith("pitch angle must be between") => new ArgumentException(ErrorDescription),
                { } when err.Contains("unable to fetch") => new FetchException(ErrorDescription),
                _ => new Exception(ErrorDescription),
            };
        }
    }
}

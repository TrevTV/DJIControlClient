﻿using DJIControlClient.Converters;
using DJIControlClient.Exceptions;
using DJIControlClient.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace DJIControlClient
{
    // Root
    public partial class Drone
    {
        internal HttpClient _httpClient;

        internal readonly JsonSerializerOptions _jsonOptions = new()
        {
            Converters =
            {
                new ControlModeConverter(),
                new VelocityProfileConverter()
            }
        };

        public Drone(string ipPort)
        {
            if (!ipPort.EndsWith('/'))
                ipPort += '/';

            ipPort = "http://" + ipPort;

            _httpClient = new()
            {
                BaseAddress = new Uri(ipPort)
            };
        }

        internal async Task<CommandCompleted> Call(string endpoint)
        {
            try
            {
                CommandCompleted? result = await _httpClient.GetFromJsonAsync<CommandCompleted>(endpoint, _jsonOptions) ?? throw new NotConnectedException();
                return result;
            }
            catch (HttpRequestException)
            {
                throw new NotConnectedException();
            }
        }

        internal async Task<CommandCompleted<T>> Call<T>(string endpoint)
        {
            try
            {
                CommandCompleted<T>? result = await _httpClient.GetFromJsonAsync<CommandCompleted<T>>(endpoint, _jsonOptions) ?? throw new NotConnectedException();
                return result;
            }
            catch (HttpRequestException)
            {
                throw new NotConnectedException();
            }
        }
    }

    // "Properties"
    public partial class Drone
    {
        #region Landing Protection
        public async Task<bool> IsLandingProtectionEnabled()
        {
            CommandCompleted<bool?> result = await Call<bool?>("isLandingProtectionEnabled");
            if (!result.Completed)
                throw result.ParseError();

            return result.State != null && result.State.Value;
        }

        public async Task SetLandingProtection(bool enabled)
        {
            string endpoint = enabled ? "enableLandingProtection" : "disableLandingProtection";

            CommandCompleted result = await Call(endpoint);
            if (!result.Completed)
                throw result.ParseError();
        }

        #endregion

        #region Control Mode

        public async Task<ControlMode> GetControlMode()
        {
            CommandCompleted<ControlMode> result = await Call<ControlMode>("getControlMode");
            if (!result.Completed)
                throw result.ParseError();

            return result.State;
        }

        public async Task SetControlMode(ControlMode mode)
        {
            CommandCompleted result = await Call($"setControlMode/{mode}");
            if (!result.Completed)
                throw result.ParseError();
        }

        #endregion

        #region Max Speed

        public async Task<float> GetMaxSpeed()
        {
            CommandCompleted<float> result = await Call<float>("getMaxSpeed");
            if (!result.Completed)
                throw result.ParseError();

            return result.State;
        }

        public async Task SetMaxSpeed(float speed)
        {
            CommandCompleted result = await Call($"setMaxSpeed/{speed}");
            if (!result.Completed)
                throw result.ParseError();
        }

        #endregion

        #region Max Angular Speed

        public async Task<float> GetMaxAngularSpeed()
        {
            CommandCompleted<float> result = await Call<float>("getMaxAngularSpeed");
            if (!result.Completed)
                throw result.ParseError();

            return result.State;
        }

        public async Task SetMaxAngularSpeed(float speed)
        {
            CommandCompleted result = await Call($"setMaxAngularSpeed/{speed}");
            if (!result.Completed)
                throw result.ParseError();
        }

        #endregion

        #region Velocity Profile

        public async Task<VelocityProfile> GetVelocityProfile()
        {
            CommandCompleted<VelocityProfile> result = await Call<VelocityProfile>("getVelocityProfile");
            if (!result.Completed)
                throw result.ParseError();

            return result.State;
        }

        public async Task SetVelocityProfile(VelocityProfile profile)
        {
            CommandCompleted result = await Call($"setVelocityProfile/{profile}");
            if (!result.Completed)
                throw result.ParseError();
        }

        #endregion
    }

    // Methods
    public partial class Drone
    {
        public async Task<bool> IsConnected()
        {
            try
            {
                string? connected = await _httpClient.GetStringAsync("");
                return connected != null;
            }
            catch (HttpRequestException)
            {
                return false;
            }
        }

        #region Takeoff and Landing

        public async Task Takeoff()
        {
            CommandCompleted result = await Call("takeoff");
            if (!result.Completed)
                throw result.ParseError();
        }

        public async Task Land()
        {
            CommandCompleted result = await Call("land");
            if (!result.Completed)
                throw result.ParseError();
        }

        public async Task ConfirmLanding()
        {
            CommandCompleted result = await Call("confirmLanding");
            if (!result.Completed)
                throw result.ParseError();
        }

        #endregion
    }
}
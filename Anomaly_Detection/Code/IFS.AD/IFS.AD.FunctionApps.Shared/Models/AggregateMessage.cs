﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace IFS.AD.FunctionApps.Shared.Models
{
    public class AggregateMessage
    {
        public string DeviceId { get; set; }
        public IEnumerable<ThermostatDeviceMessage> DeviceMessages { get; set; }
    }
}

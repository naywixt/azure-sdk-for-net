// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Administration.Models
{
    public partial class PhonePlanGroup
    {
        internal static PhonePlanGroup DeserializePhonePlanGroup(JsonElement element)
        {
            string phonePlanGroupId = default;
            Optional<PhoneNumberType> phoneNumberType = default;
            string localizedName = default;
            string localizedDescription = default;
            Optional<CarrierDetails> carrierDetails = default;
            Optional<RateInformation> rateInformation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("phonePlanGroupId"))
                {
                    phonePlanGroupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phoneNumberType"))
                {
                    phoneNumberType = new PhoneNumberType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("localizedName"))
                {
                    localizedName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("localizedDescription"))
                {
                    localizedDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("carrierDetails"))
                {
                    carrierDetails = CarrierDetails.DeserializeCarrierDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("rateInformation"))
                {
                    rateInformation = RateInformation.DeserializeRateInformation(property.Value);
                    continue;
                }
            }
            return new PhonePlanGroup(phonePlanGroupId, Optional.ToNullable(phoneNumberType), localizedName, localizedDescription, carrierDetails.Value, rateInformation.Value);
        }
    }
}

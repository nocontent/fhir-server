﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;
using EnsureThat;

namespace Microsoft.Health.Fhir.Core.Features.SecretStore
{
    /// <summary>
    /// Implementation of <see cref="ISecretStore"/> to be used for local tests and deployments.
    /// </summary>
    public class InMemorySecretStore : ISecretStore
    {
        private Dictionary<string, string> _secrets = new Dictionary<string, string>();

        public Task<SecretWrapper> GetSecretAsync(string secretName)
        {
            EnsureArg.IsNotNullOrWhiteSpace(secretName);

            SecretWrapper wrapper = null;
            if (_secrets.TryGetValue(secretName, out string secretValue))
            {
                wrapper = new SecretWrapper(secretName, secretValue);
            }

            return Task.FromResult(wrapper);
        }

        public Task<SecretWrapper> SetSecretAsync(string secretName, string secretValue)
        {
            EnsureArg.IsNotNullOrWhiteSpace(secretName);
            EnsureArg.IsNotNullOrWhiteSpace(secretValue);

            _secrets.Add(secretName, secretValue);

            return Task.FromResult(new SecretWrapper(secretName, secretValue));
        }

        public Task<SecretWrapper> DeleteSecretAsync(string secretName)
        {
            EnsureArg.IsNotNullOrWhiteSpace(secretName);

            SecretWrapper wrapper = null;
            if (_secrets.TryGetValue(secretName, out string secretValue))
            {
                wrapper = new SecretWrapper(secretName, secretValue);
                _secrets.Remove(secretName);
            }

            return Task.FromResult(wrapper);
        }
    }
}
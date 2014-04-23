#region Copyright 2014 Exceptionless

// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// 
//     http://www.apache.org/licenses/LICENSE-2.0

#endregion

using System;

namespace Exceptionless.Configuration {
    /// <summary>
    /// An attribute to configure the client
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly)]
    public class ExceptionlessAttribute : Attribute {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionlessAttribute" /> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        public ExceptionlessAttribute(string apiKey)
            : this(null, apiKey) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionlessAttribute" /> class.
        /// </summary>
        /// <param name="serverUrl">The server URL.</param>
        /// <param name="apiKey">The API key.</param>
        public ExceptionlessAttribute(string serverUrl, string apiKey)
            : this(serverUrl, apiKey, true) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionlessAttribute" /> class.
        /// </summary>
        /// <param name="serverUrl">The server URL.</param>
        /// <param name="apiKey">The API key.</param>
        /// <param name="sslEnabled">sslEnabled.</param>
        public ExceptionlessAttribute(string serverUrl, string apiKey, bool sslEnabled) {
            ServerUrl = serverUrl;
            ApiKey = apiKey;
            SslEnabled = sslEnabled;
            Enabled = true;
        }

        /// <summary>
        /// Gets or sets the server URL.
        /// </summary>
        /// <value>The server URL.</value>
        public string ServerUrl { get; set; }

        /// <summary>
        /// Gets or sets the API key.
        /// </summary>
        /// <value>The API key.</value>
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets or sets if SSL should be used.
        /// </summary>
        /// ///
        /// <value><c>true</c> to enable SSL; otherwise, <c>false</c>.</value>
        public bool SslEnabled { get; set; }

        /// <summary>
        /// Gets or sets if reporting is enabled.
        /// </summary>
        /// ///
        /// <value><c>true</c> to enable reporting; otherwise, <c>false</c>.</value>
        public bool Enabled { get; set; }
    }
}
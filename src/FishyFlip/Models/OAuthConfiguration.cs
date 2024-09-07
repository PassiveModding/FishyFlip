// <copyright file="OAuthConfiguration.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;

namespace FishyFlip.Models;

/// <summary>
/// Represents the OAuth configuration.
/// </summary>
public class OAuthConfiguration
{
    /// <summary>
    /// Gets or sets the issuer.
    /// </summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>
    /// Gets or sets the supported scopes.
    /// </summary>
    [JsonPropertyName("scopes_supported")]
    public List<string>? ScopesSupported { get; set; }

    /// <summary>
    /// Gets or sets the supported subject types.
    /// </summary>
    [JsonPropertyName("subject_types_supported")]
    public List<string>? SubjectTypesSupported { get; set; }

    /// <summary>
    /// Gets or sets the supported response types.
    /// </summary>
    [JsonPropertyName("response_types_supported")]
    public List<string>? ResponseTypesSupported { get; set; }

    /// <summary>
    /// Gets or sets the supported response modes.
    /// </summary>
    [JsonPropertyName("response_modes_supported")]
    public List<string>? ResponseModesSupported { get; set; }

    /// <summary>
    /// Gets or sets the supported grant types.
    /// </summary>
    [JsonPropertyName("grant_types_supported")]
    public List<string>? GrantTypesSupported { get; set; }

    /// <summary>
    /// Gets or sets the supported code challenge methods.
    /// </summary>
    [JsonPropertyName("code_challenge_methods_supported")]
    public List<string>? CodeChallengeMethodsSupported { get; set; }

    /// <summary>
    /// Gets or sets the supported UI locales.
    /// </summary>
    [JsonPropertyName("ui_locales_supported")]
    public List<string>? UiLocalesSupported { get; set; }

    /// <summary>
    /// Gets or sets the supported display values.
    /// </summary>
    [JsonPropertyName("display_values_supported")]
    public List<string>? DisplayValuesSupported { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the authorization response iss parameter is supported.
    /// </summary>
    [JsonPropertyName("authorization_response_iss_parameter_supported")]
    public bool AuthorizationResponseIssParameterSupported { get; set; }

    /// <summary>
    /// Gets or sets the supported request object signing algorithm values.
    /// </summary>
    [JsonPropertyName("request_object_signing_alg_values_supported")]
    public List<string>? RequestObjectSigningAlgValuesSupported { get; set; }

    /// <summary>
    /// Gets or sets the supported request object encryption algorithm values.
    /// </summary>
    [JsonPropertyName("request_object_encryption_alg_values_supported")]
    public List<string>? RequestObjectEncryptionAlgValuesSupported { get; set; }

    /// <summary>
    /// Gets or sets the supported request object encryption encryption values.
    /// </summary>
    [JsonPropertyName("request_object_encryption_enc_values_supported")]
    public List<string>? RequestObjectEncryptionEncValuesSupported { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the request parameter is supported.
    /// </summary>
    [JsonPropertyName("request_parameter_supported")]
    public bool RequestParameterSupported { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the request URI parameter is supported.
    /// </summary>
    [JsonPropertyName("request_uri_parameter_supported")]
    public bool RequestUriParameterSupported { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the request URI registration is required.
    /// </summary>
    [JsonPropertyName("require_request_uri_registration")]
    public bool RequireRequestUriRegistration { get; set; }

    /// <summary>
    /// Gets or sets the JWKS URI.
    /// </summary>
    [JsonPropertyName("jwks_uri")]
    public string? JwksUri { get; set; }

    /// <summary>
    /// Gets or sets the authorization endpoint.
    /// </summary>
    [JsonPropertyName("authorization_endpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>
    /// Gets or sets the token endpoint.
    /// </summary>
    [JsonPropertyName("token_endpoint")]
    public string? TokenEndpoint { get; set; }

    /// <summary>
    /// Gets or sets the supported token endpoint authentication methods.
    /// </summary>
    [JsonPropertyName("token_endpoint_auth_methods_supported")]
    public List<string>? TokenEndpointAuthMethodsSupported { get; set; }

    /// <summary>
    /// Gets or sets the supported token endpoint authentication signing algorithm values.
    /// </summary>
    [JsonPropertyName("token_endpoint_auth_signing_alg_values_supported")]
    public List<string>? TokenEndpointAuthSigningAlgValuesSupported { get; set; }

    /// <summary>
    /// Gets or sets the revocation endpoint.
    /// </summary>
    [JsonPropertyName("revocation_endpoint")]
    public string? RevocationEndpoint { get; set; }

    /// <summary>
    /// Gets or sets the introspection endpoint.
    /// </summary>
    [JsonPropertyName("introspection_endpoint")]
    public string? IntrospectionEndpoint { get; set; }

    /// <summary>
    /// Gets or sets the pushed authorization request endpoint.
    /// </summary>
    [JsonPropertyName("pushed_authorization_request_endpoint")]
    public string? PushedAuthorizationRequestEndpoint { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether pushed authorization requests are required.
    /// </summary>
    [JsonPropertyName("require_pushed_authorization_requests")]
    public bool RequirePushedAuthorizationRequests { get; set; }

    /// <summary>
    /// Gets or sets the supported DPoP signing algorithm values.
    /// </summary>
    [JsonPropertyName("dpop_signing_alg_values_supported")]
    public List<string>? DpopSigningAlgValuesSupported { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the client ID metadata document is supported.
    /// </summary>
    [JsonPropertyName("client_id_metadata_document_supported")]
    public bool ClientIdMetadataDocumentSupported { get; set; }
}

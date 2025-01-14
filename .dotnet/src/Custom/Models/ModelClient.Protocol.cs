﻿using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.ComponentModel;
using System.Threading.Tasks;

namespace OpenAI.Models;

[CodeGenSuppress("GetModelsAsync", typeof(RequestOptions))]
[CodeGenSuppress("GetModels", typeof(RequestOptions))]
[CodeGenSuppress("RetrieveAsync", typeof(string), typeof(RequestOptions))]
[CodeGenSuppress("Retrieve", typeof(string), typeof(RequestOptions))]
[CodeGenSuppress("DeleteAsync", typeof(string), typeof(RequestOptions))]
[CodeGenSuppress("Delete", typeof(string), typeof(RequestOptions))]
public partial class ModelClient
{
    /// <summary>
    /// [Protocol Method] Lists the currently available models, and provides basic information about each one such as the
    /// owner and availability.
    /// <description>
    /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
    /// </description>
    /// </summary>
    /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
    /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
    /// <returns> The response returned from the service. </returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual async Task<ClientResult> GetModelsAsync(RequestOptions options)
    {
        using PipelineMessage message = CreateGetModelsRequest(options);
        return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
    }

    /// <summary>
    /// [Protocol Method] Lists the currently available models, and provides basic information about each one such as the
    /// owner and availability.
    /// <description>
    /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
    /// </description>
    /// </summary>
    /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
    /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
    /// <returns> The response returned from the service. </returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual ClientResult GetModels(RequestOptions options)
    {
        using PipelineMessage message = CreateGetModelsRequest(options);
        return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
    }

    /// <summary>
    /// [Protocol Method] Retrieves a model instance, providing basic information about the model such as the owner and
    /// permissioning.
    /// <description>
    /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
    /// </description>
    /// </summary>
    /// <param name="model"> The ID of the model to use for this request. </param>
    /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
    /// <exception cref="ArgumentNullException"> <paramref name="model"/> is null. </exception>
    /// <exception cref="ArgumentException"> <paramref name="model"/> is an empty string, and was expected to be non-empty. </exception>
    /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
    /// <returns> The response returned from the service. </returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual async Task<ClientResult> GetModelAsync(string model, RequestOptions options)
    {
        Argument.AssertNotNullOrEmpty(model, nameof(model));

        using PipelineMessage message = CreateRetrieveRequest(model, options);
        return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
    }

    /// <summary>
    /// [Protocol Method] Retrieves a model instance, providing basic information about the model such as the owner and
    /// permissioning.
    /// <description>
    /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
    /// </description>
    /// </summary>
    /// <param name="model"> The ID of the model to use for this request. </param>
    /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
    /// <exception cref="ArgumentNullException"> <paramref name="model"/> is null. </exception>
    /// <exception cref="ArgumentException"> <paramref name="model"/> is an empty string, and was expected to be non-empty. </exception>
    /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
    /// <returns> The response returned from the service. </returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual ClientResult GetModel(string model, RequestOptions options)
    {
        Argument.AssertNotNullOrEmpty(model, nameof(model));

        using PipelineMessage message = CreateRetrieveRequest(model, options);
        return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
    }

    /// <summary>
    /// [Protocol Method] Delete a fine-tuned model. You must have the Owner role in your organization to delete a model.
    /// <description>
    /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
    /// </description>
    /// </summary>
    /// <param name="model"> The model to delete. </param>
    /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
    /// <exception cref="ArgumentNullException"> <paramref name="model"/> is null. </exception>
    /// <exception cref="ArgumentException"> <paramref name="model"/> is an empty string, and was expected to be non-empty. </exception>
    /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
    /// <returns> The response returned from the service. </returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual async Task<ClientResult> DeleteModelAsync(string model, RequestOptions options)
    {
        Argument.AssertNotNullOrEmpty(model, nameof(model));

        using PipelineMessage message = CreateDeleteRequest(model, options);
        return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
    }

    /// <summary>
    /// [Protocol Method] Delete a fine-tuned model. You must have the Owner role in your organization to delete a model.
    /// <description>
    /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
    /// </description>
    /// </summary>
    /// <param name="model"> The model to delete. </param>
    /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
    /// <exception cref="ArgumentNullException"> <paramref name="model"/> is null. </exception>
    /// <exception cref="ArgumentException"> <paramref name="model"/> is an empty string, and was expected to be non-empty. </exception>
    /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
    /// <returns> The response returned from the service. </returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual ClientResult Delete(string model, RequestOptions options)
    {
        Argument.AssertNotNullOrEmpty(model, nameof(model));

        using PipelineMessage message = CreateDeleteRequest(model, options);
        return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
    }
}

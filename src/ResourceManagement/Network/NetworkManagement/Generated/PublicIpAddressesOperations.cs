namespace Microsoft.Azure.Management.Network
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using Microsoft.Azure;
    using Models;

    internal partial class PublicIpAddressesOperations : IServiceOperations<NetworkResourceProviderClient>, IPublicIpAddressesOperations
    {
        /// <summary>
        /// Initializes a new instance of the PublicIpAddressesOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal PublicIpAddressesOperations(NetworkResourceProviderClient client)
        {
            this.Client = client;
        }

        /// <summary>
        /// Gets a reference to the NetworkResourceProviderClient
        /// </summary>
        public NetworkResourceProviderClient Client { get; private set; }

        /// <summary>
        /// The delete publicIpAddress operation deletes the specified publicIpAddress.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>    
        /// <param name='publicIpAddressName'>
        /// The name of the subnet.
        /// </param>    
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public async Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string publicIpAddressName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            // Send request
            AzureOperationResponse response = await BeginDeleteWithHttpMessagesAsync(
                resourceGroupName, publicIpAddressName, customHeaders, cancellationToken);
            return await this.Client.GetPostOrDeleteOperationResultAsync(response, customHeaders, cancellationToken);
        }

        /// <summary>
        /// The delete publicIpAddress operation deletes the specified publicIpAddress.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>    
        /// <param name='publicIpAddressName'>
        /// The name of the subnet.
        /// </param>    
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public async Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string publicIpAddressName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (resourceGroupName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "resourceGroupName");
            }
            if (publicIpAddressName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "publicIpAddressName");
            }
            // Tracing
            bool shouldTrace = ServiceClientTracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("publicIpAddressName", publicIpAddressName);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(invocationId, this, "BeginDelete", tracingParameters);
            }
            // Construct URL
            string url = this.Client.BaseUri.AbsoluteUri + 
                         "//subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPAddresses/{publicIpAddressName}/";
            if (this.Client.Credentials == null)
            {
                throw new ArgumentNullException("Credentials", "SubscriptionCloudCredentials are missing from the client.");
            }
            url = url.Replace("{subscriptionId}", Uri.EscapeDataString(this.Client.Credentials.SubscriptionId));
            url = url.Replace("{resourceGroupName}", Uri.EscapeDataString(resourceGroupName));
            url = url.Replace("{publicIpAddressName}", Uri.EscapeDataString(publicIpAddressName));
            List<string> queryParameters = new List<string>();
            queryParameters.Add(string.Format("api-version={0}", Uri.EscapeDataString(this.Client.ApiVersion)));
            if (queryParameters.Count > 0)
            {
                url += "?" + string.Join("&", queryParameters);
            }
            // trim all duplicate forward slashes in the url
            url = Regex.Replace(url, "([^:]/)/+", "$1");
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = new HttpRequestMessage();
            httpRequest.Method = new HttpMethod("DELETE");
            httpRequest.RequestUri = new Uri(url);
            // Set Headers
            if (customHeaders != null)
            {
                foreach(var header in customHeaders)
                {
                    httpRequest.Headers.Add(header.Key, header.Value);
                }
            }

            // Set Credentials
            cancellationToken.ThrowIfCancellationRequested();
            await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            // Send Request
            if (shouldTrace)
            {
                ServiceClientTracing.SendRequest(invocationId, httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            HttpResponseMessage httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            if (shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(invocationId, httpResponse);
            }
            HttpStatusCode statusCode = httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (!(statusCode == (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), "Accepted") || statusCode == (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), "NoContent") || statusCode == (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), "OK")))
            {
                var ex = new CloudException(string.Format("Operation returned an invalid status code '{0}'", statusCode));
                ex.Request = httpRequest;
                ex.Response = httpResponse;
                if (shouldTrace)
                {
                    ServiceClientTracing.Error(invocationId, ex);
                }
                throw ex;
            }
            // Create Result
            var result = new AzureOperationResponse();
            result.Request = httpRequest;
            result.Response = httpResponse;
            if (shouldTrace)
            {
                ServiceClientTracing.Exit(invocationId, result);
            }
            return result;
        }

        /// <summary>
        /// The Get publicIpAddress operation retreives information about the
        /// specified pubicIpAddress
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>    
        /// <param name='publicIpAddressName'>
        /// The name of the subnet.
        /// </param>    
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public async Task<AzureOperationResponse<PublicIpAddress>> GetWithHttpMessagesAsync(string resourceGroupName, string publicIpAddressName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (resourceGroupName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "resourceGroupName");
            }
            if (publicIpAddressName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "publicIpAddressName");
            }
            // Tracing
            bool shouldTrace = ServiceClientTracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("publicIpAddressName", publicIpAddressName);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(invocationId, this, "Get", tracingParameters);
            }
            // Construct URL
            string url = this.Client.BaseUri.AbsoluteUri + 
                         "//subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPAddresses/{publicIpAddressName}/";
            if (this.Client.Credentials == null)
            {
                throw new ArgumentNullException("Credentials", "SubscriptionCloudCredentials are missing from the client.");
            }
            url = url.Replace("{subscriptionId}", Uri.EscapeDataString(this.Client.Credentials.SubscriptionId));
            url = url.Replace("{resourceGroupName}", Uri.EscapeDataString(resourceGroupName));
            url = url.Replace("{publicIpAddressName}", Uri.EscapeDataString(publicIpAddressName));
            List<string> queryParameters = new List<string>();
            queryParameters.Add(string.Format("api-version={0}", Uri.EscapeDataString(this.Client.ApiVersion)));
            if (queryParameters.Count > 0)
            {
                url += "?" + string.Join("&", queryParameters);
            }
            // trim all duplicate forward slashes in the url
            url = Regex.Replace(url, "([^:]/)/+", "$1");
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = new HttpRequestMessage();
            httpRequest.Method = new HttpMethod("GET");
            httpRequest.RequestUri = new Uri(url);
            // Set Headers
            if (customHeaders != null)
            {
                foreach(var header in customHeaders)
                {
                    httpRequest.Headers.Add(header.Key, header.Value);
                }
            }

            // Set Credentials
            cancellationToken.ThrowIfCancellationRequested();
            await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            // Send Request
            if (shouldTrace)
            {
                ServiceClientTracing.SendRequest(invocationId, httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            HttpResponseMessage httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            if (shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(invocationId, httpResponse);
            }
            HttpStatusCode statusCode = httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (!(statusCode == (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), "OK")))
            {
                var ex = new CloudException(string.Format("Operation returned an invalid status code '{0}'", statusCode));
                CloudError errorBody = JsonConvert.DeserializeObject<CloudError>(responseContent, this.Client.DeserializationSettings);
                if (errorBody != null)
                {
                    ex = new CloudException(errorBody.Message);
                    ex.Body = errorBody;
                }
                ex.Request = httpRequest;
                ex.Response = httpResponse;
                if (shouldTrace)
                {
                    ServiceClientTracing.Error(invocationId, ex);
                }
                throw ex;
            }
            // Create Result
            var result = new AzureOperationResponse<PublicIpAddress>();
            result.Request = httpRequest;
            result.Response = httpResponse;
            // Deserialize Response
            if (statusCode == (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), "OK"))
            {
                result.Body = JsonConvert.DeserializeObject<PublicIpAddress>(responseContent, this.Client.DeserializationSettings);
            }
            if (shouldTrace)
            {
                ServiceClientTracing.Exit(invocationId, result);
            }
            return result;
        }

        /// <summary>
        /// The Put PublicIPAddress operation creates/updates a stable/dynamic
        /// PublicIP address
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>    
        /// <param name='publicIpAddressName'>
        /// The name of the publicIpAddress.
        /// </param>    
        /// <param name='parameters'>
        /// Parameters supplied to the create/update PublicIPAddress operation
        /// </param>    
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>    
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public async Task<AzureOperationResponse<PublicIpAddress>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string publicIpAddressName, PublicIpAddress parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            // Send Request
            AzureOperationResponse<PublicIpAddress> response = await BeginCreateOrUpdateWithHttpMessagesAsync(
                resourceGroupName, publicIpAddressName, parameters, customHeaders, cancellationToken);
            return await this.Client.GetPutOperationResultAsync<PublicIpAddress>(response, 
                () => GetWithHttpMessagesAsync(resourceGroupName: resourceGroupName, publicIpAddressName: publicIpAddressName, customHeaders: customHeaders, cancellationToken: cancellationToken),
                customHeaders, 
                cancellationToken);
        }

        /// <summary>
        /// The Put PublicIPAddress operation creates/updates a stable/dynamic
        /// PublicIP address
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>    
        /// <param name='publicIpAddressName'>
        /// The name of the publicIpAddress.
        /// </param>    
        /// <param name='parameters'>
        /// Parameters supplied to the create/update PublicIPAddress operation
        /// </param>    
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public async Task<AzureOperationResponse<PublicIpAddress>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string publicIpAddressName, PublicIpAddress parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (resourceGroupName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "resourceGroupName");
            }
            if (publicIpAddressName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "publicIpAddressName");
            }
            if (parameters == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "parameters");
            }
            if (parameters != null)
            {
                parameters.Validate();
            }
            // Tracing
            bool shouldTrace = ServiceClientTracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("publicIpAddressName", publicIpAddressName);
                tracingParameters.Add("parameters", parameters);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(invocationId, this, "BeginCreateOrUpdate", tracingParameters);
            }
            // Construct URL
            string url = this.Client.BaseUri.AbsoluteUri + 
                         "//subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPAddresses/{publicIpAddressName}/";
            if (this.Client.Credentials == null)
            {
                throw new ArgumentNullException("Credentials", "SubscriptionCloudCredentials are missing from the client.");
            }
            url = url.Replace("{subscriptionId}", Uri.EscapeDataString(this.Client.Credentials.SubscriptionId));
            url = url.Replace("{resourceGroupName}", Uri.EscapeDataString(resourceGroupName));
            url = url.Replace("{publicIpAddressName}", Uri.EscapeDataString(publicIpAddressName));
            List<string> queryParameters = new List<string>();
            queryParameters.Add(string.Format("api-version={0}", Uri.EscapeDataString(this.Client.ApiVersion)));
            if (queryParameters.Count > 0)
            {
                url += "?" + string.Join("&", queryParameters);
            }
            // trim all duplicate forward slashes in the url
            url = Regex.Replace(url, "([^:]/)/+", "$1");
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = new HttpRequestMessage();
            httpRequest.Method = new HttpMethod("PUT");
            httpRequest.RequestUri = new Uri(url);
            // Set Headers
            if (customHeaders != null)
            {
                foreach(var header in customHeaders)
                {
                    httpRequest.Headers.Add(header.Key, header.Value);
                }
            }

            // Set Credentials
            cancellationToken.ThrowIfCancellationRequested();
            await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            // Serialize Request  
            string requestContent = JsonConvert.SerializeObject(parameters, this.Client.SerializationSettings);
            httpRequest.Content = new StringContent(requestContent, Encoding.UTF8);
            httpRequest.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
            // Send Request
            if (shouldTrace)
            {
                ServiceClientTracing.SendRequest(invocationId, httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            HttpResponseMessage httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            if (shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(invocationId, httpResponse);
            }
            HttpStatusCode statusCode = httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (!(statusCode == (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), "OK") || statusCode == (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), "Created")))
            {
                var ex = new CloudException(string.Format("Operation returned an invalid status code '{0}'", statusCode));
                CloudError errorBody = JsonConvert.DeserializeObject<CloudError>(responseContent, this.Client.DeserializationSettings);
                if (errorBody != null)
                {
                    ex = new CloudException(errorBody.Message);
                    ex.Body = errorBody;
                }
                ex.Request = httpRequest;
                ex.Response = httpResponse;
                if (shouldTrace)
                {
                    ServiceClientTracing.Error(invocationId, ex);
                }
                throw ex;
            }
            // Create Result
            var result = new AzureOperationResponse<PublicIpAddress>();
            result.Request = httpRequest;
            result.Response = httpResponse;
            // Deserialize Response
            if (statusCode == (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), "OK"))
            {
                result.Body = JsonConvert.DeserializeObject<PublicIpAddress>(responseContent, this.Client.DeserializationSettings);
            }
            // Deserialize Response
            if (statusCode == (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), "Created"))
            {
                result.Body = JsonConvert.DeserializeObject<PublicIpAddress>(responseContent, this.Client.DeserializationSettings);
            }
            if (shouldTrace)
            {
                ServiceClientTracing.Exit(invocationId, result);
            }
            return result;
        }

        /// <summary>
        /// The List publicIpAddress opertion retrieves all the publicIpAddresses in a
        /// subscription.
        /// </summary>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public async Task<AzureOperationResponse<PublicIpAddressListResult>> ListAllWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            // Tracing
            bool shouldTrace = ServiceClientTracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(invocationId, this, "ListAll", tracingParameters);
            }
            // Construct URL
            string url = this.Client.BaseUri.AbsoluteUri + 
                         "//subscriptions/{subscriptionId}/providers/Microsoft.Network/publicIPAddresses";
            if (this.Client.Credentials == null)
            {
                throw new ArgumentNullException("Credentials", "SubscriptionCloudCredentials are missing from the client.");
            }
            url = url.Replace("{subscriptionId}", Uri.EscapeDataString(this.Client.Credentials.SubscriptionId));
            List<string> queryParameters = new List<string>();
            queryParameters.Add(string.Format("api-version={0}", Uri.EscapeDataString(this.Client.ApiVersion)));
            if (queryParameters.Count > 0)
            {
                url += "?" + string.Join("&", queryParameters);
            }
            // trim all duplicate forward slashes in the url
            url = Regex.Replace(url, "([^:]/)/+", "$1");
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = new HttpRequestMessage();
            httpRequest.Method = new HttpMethod("GET");
            httpRequest.RequestUri = new Uri(url);
            // Set Headers
            if (customHeaders != null)
            {
                foreach(var header in customHeaders)
                {
                    httpRequest.Headers.Add(header.Key, header.Value);
                }
            }

            // Set Credentials
            cancellationToken.ThrowIfCancellationRequested();
            await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            // Send Request
            if (shouldTrace)
            {
                ServiceClientTracing.SendRequest(invocationId, httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            HttpResponseMessage httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            if (shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(invocationId, httpResponse);
            }
            HttpStatusCode statusCode = httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (!(statusCode == (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), "OK")))
            {
                var ex = new CloudException(string.Format("Operation returned an invalid status code '{0}'", statusCode));
                CloudError errorBody = JsonConvert.DeserializeObject<CloudError>(responseContent, this.Client.DeserializationSettings);
                if (errorBody != null)
                {
                    ex = new CloudException(errorBody.Message);
                    ex.Body = errorBody;
                }
                ex.Request = httpRequest;
                ex.Response = httpResponse;
                if (shouldTrace)
                {
                    ServiceClientTracing.Error(invocationId, ex);
                }
                throw ex;
            }
            // Create Result
            var result = new AzureOperationResponse<PublicIpAddressListResult>();
            result.Request = httpRequest;
            result.Response = httpResponse;
            // Deserialize Response
            if (statusCode == (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), "OK"))
            {
                result.Body = JsonConvert.DeserializeObject<PublicIpAddressListResult>(responseContent, this.Client.DeserializationSettings);
            }
            if (shouldTrace)
            {
                ServiceClientTracing.Exit(invocationId, result);
            }
            return result;
        }

        /// <summary>
        /// The List publicIpAddress opertion retrieves all the publicIpAddresses in a
        /// resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>    
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public async Task<AzureOperationResponse<PublicIpAddressListResult>> ListWithHttpMessagesAsync(string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (resourceGroupName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "resourceGroupName");
            }
            // Tracing
            bool shouldTrace = ServiceClientTracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(invocationId, this, "List", tracingParameters);
            }
            // Construct URL
            string url = this.Client.BaseUri.AbsoluteUri + 
                         "//subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPAddresses";
            if (this.Client.Credentials == null)
            {
                throw new ArgumentNullException("Credentials", "SubscriptionCloudCredentials are missing from the client.");
            }
            url = url.Replace("{subscriptionId}", Uri.EscapeDataString(this.Client.Credentials.SubscriptionId));
            url = url.Replace("{resourceGroupName}", Uri.EscapeDataString(resourceGroupName));
            List<string> queryParameters = new List<string>();
            queryParameters.Add(string.Format("api-version={0}", Uri.EscapeDataString(this.Client.ApiVersion)));
            if (queryParameters.Count > 0)
            {
                url += "?" + string.Join("&", queryParameters);
            }
            // trim all duplicate forward slashes in the url
            url = Regex.Replace(url, "([^:]/)/+", "$1");
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = new HttpRequestMessage();
            httpRequest.Method = new HttpMethod("GET");
            httpRequest.RequestUri = new Uri(url);
            // Set Headers
            if (customHeaders != null)
            {
                foreach(var header in customHeaders)
                {
                    httpRequest.Headers.Add(header.Key, header.Value);
                }
            }

            // Set Credentials
            cancellationToken.ThrowIfCancellationRequested();
            await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            // Send Request
            if (shouldTrace)
            {
                ServiceClientTracing.SendRequest(invocationId, httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            HttpResponseMessage httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            if (shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(invocationId, httpResponse);
            }
            HttpStatusCode statusCode = httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (!(statusCode == (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), "OK")))
            {
                var ex = new CloudException(string.Format("Operation returned an invalid status code '{0}'", statusCode));
                CloudError errorBody = JsonConvert.DeserializeObject<CloudError>(responseContent, this.Client.DeserializationSettings);
                if (errorBody != null)
                {
                    ex = new CloudException(errorBody.Message);
                    ex.Body = errorBody;
                }
                ex.Request = httpRequest;
                ex.Response = httpResponse;
                if (shouldTrace)
                {
                    ServiceClientTracing.Error(invocationId, ex);
                }
                throw ex;
            }
            // Create Result
            var result = new AzureOperationResponse<PublicIpAddressListResult>();
            result.Request = httpRequest;
            result.Response = httpResponse;
            // Deserialize Response
            if (statusCode == (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), "OK"))
            {
                result.Body = JsonConvert.DeserializeObject<PublicIpAddressListResult>(responseContent, this.Client.DeserializationSettings);
            }
            if (shouldTrace)
            {
                ServiceClientTracing.Exit(invocationId, result);
            }
            return result;
        }

        /// <summary>
        /// The List publicIpAddress opertion retrieves all the publicIpAddresses in a
        /// subscription.
        /// </summary>
        /// <param name='nextLink'>
        /// NextLink from the previous successful call to List operation.
        /// </param>    
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public async Task<AzureOperationResponse<PublicIpAddressListResult>> ListAllNextWithHttpMessagesAsync(string nextLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (nextLink == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "nextLink");
            }
            // Tracing
            bool shouldTrace = ServiceClientTracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("nextLink", nextLink);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(invocationId, this, "ListAllNext", tracingParameters);
            }
            // Construct URL
            string url = "{nextLink}";       
            url = url.Replace("{nextLink}", nextLink);
            List<string> queryParameters = new List<string>();
            if (queryParameters.Count > 0)
            {
                url += "?" + string.Join("&", queryParameters);
            }
            // trim all duplicate forward slashes in the url
            url = Regex.Replace(url, "([^:]/)/+", "$1");
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = new HttpRequestMessage();
            httpRequest.Method = new HttpMethod("GET");
            httpRequest.RequestUri = new Uri(url);
            // Set Headers
            if (customHeaders != null)
            {
                foreach(var header in customHeaders)
                {
                    httpRequest.Headers.Add(header.Key, header.Value);
                }
            }

            // Set Credentials
            cancellationToken.ThrowIfCancellationRequested();
            await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            // Send Request
            if (shouldTrace)
            {
                ServiceClientTracing.SendRequest(invocationId, httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            HttpResponseMessage httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            if (shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(invocationId, httpResponse);
            }
            HttpStatusCode statusCode = httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (!(statusCode == (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), "OK")))
            {
                var ex = new CloudException(string.Format("Operation returned an invalid status code '{0}'", statusCode));
                CloudError errorBody = JsonConvert.DeserializeObject<CloudError>(responseContent, this.Client.DeserializationSettings);
                if (errorBody != null)
                {
                    ex = new CloudException(errorBody.Message);
                    ex.Body = errorBody;
                }
                ex.Request = httpRequest;
                ex.Response = httpResponse;
                if (shouldTrace)
                {
                    ServiceClientTracing.Error(invocationId, ex);
                }
                throw ex;
            }
            // Create Result
            var result = new AzureOperationResponse<PublicIpAddressListResult>();
            result.Request = httpRequest;
            result.Response = httpResponse;
            // Deserialize Response
            if (statusCode == (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), "OK"))
            {
                result.Body = JsonConvert.DeserializeObject<PublicIpAddressListResult>(responseContent, this.Client.DeserializationSettings);
            }
            if (shouldTrace)
            {
                ServiceClientTracing.Exit(invocationId, result);
            }
            return result;
        }

        /// <summary>
        /// The List publicIpAddress opertion retrieves all the publicIpAddresses in a
        /// resource group.
        /// </summary>
        /// <param name='nextLink'>
        /// NextLink from the previous successful call to List operation.
        /// </param>    
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public async Task<AzureOperationResponse<PublicIpAddressListResult>> ListNextWithHttpMessagesAsync(string nextLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (nextLink == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "nextLink");
            }
            // Tracing
            bool shouldTrace = ServiceClientTracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("nextLink", nextLink);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(invocationId, this, "ListNext", tracingParameters);
            }
            // Construct URL
            string url = "{nextLink}";       
            url = url.Replace("{nextLink}", nextLink);
            List<string> queryParameters = new List<string>();
            if (queryParameters.Count > 0)
            {
                url += "?" + string.Join("&", queryParameters);
            }
            // trim all duplicate forward slashes in the url
            url = Regex.Replace(url, "([^:]/)/+", "$1");
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = new HttpRequestMessage();
            httpRequest.Method = new HttpMethod("GET");
            httpRequest.RequestUri = new Uri(url);
            // Set Headers
            if (customHeaders != null)
            {
                foreach(var header in customHeaders)
                {
                    httpRequest.Headers.Add(header.Key, header.Value);
                }
            }

            // Set Credentials
            cancellationToken.ThrowIfCancellationRequested();
            await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            // Send Request
            if (shouldTrace)
            {
                ServiceClientTracing.SendRequest(invocationId, httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            HttpResponseMessage httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            if (shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(invocationId, httpResponse);
            }
            HttpStatusCode statusCode = httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (!(statusCode == (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), "OK")))
            {
                var ex = new CloudException(string.Format("Operation returned an invalid status code '{0}'", statusCode));
                CloudError errorBody = JsonConvert.DeserializeObject<CloudError>(responseContent, this.Client.DeserializationSettings);
                if (errorBody != null)
                {
                    ex = new CloudException(errorBody.Message);
                    ex.Body = errorBody;
                }
                ex.Request = httpRequest;
                ex.Response = httpResponse;
                if (shouldTrace)
                {
                    ServiceClientTracing.Error(invocationId, ex);
                }
                throw ex;
            }
            // Create Result
            var result = new AzureOperationResponse<PublicIpAddressListResult>();
            result.Request = httpRequest;
            result.Response = httpResponse;
            // Deserialize Response
            if (statusCode == (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), "OK"))
            {
                result.Body = JsonConvert.DeserializeObject<PublicIpAddressListResult>(responseContent, this.Client.DeserializationSettings);
            }
            if (shouldTrace)
            {
                ServiceClientTracing.Exit(invocationId, result);
            }
            return result;
        }

    }
}

using System;
using System.Net.Http;
using Polly;
using Polly.CircuitBreaker;
using Polly.Timeout;
using Polly.Retry;
using Polly.Wrap;
using Polly.Bulkhead;
using Polly.Fallback;

namespace FaultTolerance.Policies
{
    public interface IPollyPolicies
    {
        /// <summary>
        /// Creates a retry policy with the specified number of retries.
        /// </summary>
        IAsyncPolicy<HttpResponseMessage> GetRetryPolicy(int retryCount);

        /// <summary>
        /// Creates a circuit breaker policy.
        /// </summary>
        IAsyncPolicy<HttpResponseMessage> GetCircuitBreakerPolicy(int handledEventsAllowedBeforeBreaking, TimeSpan durationOfBreak);

        /// <summary>
        /// Creates a timeout policy.
        /// </summary>
        IAsyncPolicy<HttpResponseMessage> GetTimeoutPolicy(TimeSpan timeout);
    }
}

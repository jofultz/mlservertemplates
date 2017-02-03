// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TechReady
{
    using System.Threading.Tasks;
   using Models;

    /// <summary>
    /// Extension methods for LoanPredictService1484637430.
    /// </summary>
    public static partial class LoanPredictService1484637430Extensions
    {
            /// <summary>
            /// Logs the user in
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='loginRequest'>
            /// </param>
            public static AccessTokenResponse Login(this ILoanPredictService1484637430 operations, LoginRequest loginRequest)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ILoanPredictService1484637430)s).LoginAsync(loginRequest), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Logs the user in
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='loginRequest'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<AccessTokenResponse> LoginAsync(this ILoanPredictService1484637430 operations, LoginRequest loginRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.LoginWithHttpMessagesAsync(loginRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The user renews access token and refresh token
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='renewTokenRequest'>
            /// </param>
            public static AccessTokenResponse RenewToken(this ILoanPredictService1484637430 operations, RenewTokenRequest renewTokenRequest)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ILoanPredictService1484637430)s).RenewTokenAsync(renewTokenRequest), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The user renews access token and refresh token
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='renewTokenRequest'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<AccessTokenResponse> RenewTokenAsync(this ILoanPredictService1484637430 operations, RenewTokenRequest renewTokenRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.RenewTokenWithHttpMessagesAsync(renewTokenRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The user revokes a refresh token
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='refreshToken'>
            /// The refresh token to be revoked
            /// </param>
            public static AccessTokenResponse RevokeRefreshToken(this ILoanPredictService1484637430 operations, string refreshToken)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ILoanPredictService1484637430)s).RevokeRefreshTokenAsync(refreshToken), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The user revokes a refresh token
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='refreshToken'>
            /// The refresh token to be revoked
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<AccessTokenResponse> RevokeRefreshTokenAsync(this ILoanPredictService1484637430 operations, string refreshToken, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.RevokeRefreshTokenWithHttpMessagesAsync(refreshToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Consume the loanPredictService1484637430 web service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='webServiceParameters'>
            /// Input parameters to the web service.
            /// </param>
            public static WebServiceResult LoanPredictService(this ILoanPredictService1484637430 operations, InputParameters webServiceParameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ILoanPredictService1484637430)s).LoanPredictServiceAsync(webServiceParameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Consume the loanPredictService1484637430 web service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='webServiceParameters'>
            /// Input parameters to the web service.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<WebServiceResult> LoanPredictServiceAsync(this ILoanPredictService1484637430 operations, InputParameters webServiceParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.LoanPredictServiceWithHttpMessagesAsync(webServiceParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Consume the loanPredictService1484637430 web service asynchronously.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='batchWebServiceParameters'>
            /// Input parameters to the web service.
            /// </param>
            /// <param name='parallelCount'>
            /// Number of threads used to process entries in the batch. Default value is
            /// 10. Please make sure not to use too high of a number because it might
            /// negatively impact performance.
            /// </param>
            public static StartBatchExecutionResponse StartBatchExecution(this ILoanPredictService1484637430 operations, System.Collections.Generic.IList<InputParameters> batchWebServiceParameters, int? parallelCount = default(int?))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ILoanPredictService1484637430)s).StartBatchExecutionAsync(batchWebServiceParameters, parallelCount), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Consume the loanPredictService1484637430 web service asynchronously.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='batchWebServiceParameters'>
            /// Input parameters to the web service.
            /// </param>
            /// <param name='parallelCount'>
            /// Number of threads used to process entries in the batch. Default value is
            /// 10. Please make sure not to use too high of a number because it might
            /// negatively impact performance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<StartBatchExecutionResponse> StartBatchExecutionAsync(this ILoanPredictService1484637430 operations, System.Collections.Generic.IList<InputParameters> batchWebServiceParameters, int? parallelCount = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.StartBatchExecutionWithHttpMessagesAsync(batchWebServiceParameters, parallelCount, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all batch executions for loanPredictService1484637430.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static System.Collections.Generic.IList<string> GetBatchExecutions(this ILoanPredictService1484637430 operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ILoanPredictService1484637430)s).GetBatchExecutionsAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all batch executions for loanPredictService1484637430.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<System.Collections.Generic.IList<string>> GetBatchExecutionsAsync(this ILoanPredictService1484637430 operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetBatchExecutionsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all batch executions for loanPredictService1484637430.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='executionId'>
            /// Execution id of the execution
            /// </param>
            /// <param name='showPartialResults'>
            /// Returns the already processed results of the batch execution even if it
            /// hasn't been fully completed.
            /// </param>
            public static BatchWebServiceResult GetBatchExecutionStatus(this ILoanPredictService1484637430 operations, string executionId, bool? showPartialResults = default(bool?))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ILoanPredictService1484637430)s).GetBatchExecutionStatusAsync(executionId, showPartialResults), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all batch executions for loanPredictService1484637430.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='executionId'>
            /// Execution id of the execution
            /// </param>
            /// <param name='showPartialResults'>
            /// Returns the already processed results of the batch execution even if it
            /// hasn't been fully completed.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<BatchWebServiceResult> GetBatchExecutionStatusAsync(this ILoanPredictService1484637430 operations, string executionId, bool? showPartialResults = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetBatchExecutionStatusWithHttpMessagesAsync(executionId, showPartialResults, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Cancels and deletes all batch executions for loanPredictService1484637430.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='executionId'>
            /// Execution id of the execution.
            /// </param>
            public static System.Collections.Generic.IList<string> CancelAndDeleteBatchExecution(this ILoanPredictService1484637430 operations, string executionId)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ILoanPredictService1484637430)s).CancelAndDeleteBatchExecutionAsync(executionId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancels and deletes all batch executions for loanPredictService1484637430.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='executionId'>
            /// Execution id of the execution.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<System.Collections.Generic.IList<string>> CancelAndDeleteBatchExecutionAsync(this ILoanPredictService1484637430 operations, string executionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CancelAndDeleteBatchExecutionWithHttpMessagesAsync(executionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all files from an individual execution in
            /// loanPredictService1484637430.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='executionId'>
            /// Execution id of the execution
            /// </param>
            /// <param name='index'>
            /// Index of the execution in the batch.
            /// </param>
            public static System.Collections.Generic.IList<string> GetBatchExecutionFiles(this ILoanPredictService1484637430 operations, string executionId, int index)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ILoanPredictService1484637430)s).GetBatchExecutionFilesAsync(executionId, index), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all files from an individual execution in
            /// loanPredictService1484637430.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='executionId'>
            /// Execution id of the execution
            /// </param>
            /// <param name='index'>
            /// Index of the execution in the batch.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<System.Collections.Generic.IList<string>> GetBatchExecutionFilesAsync(this ILoanPredictService1484637430 operations, string executionId, int index, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetBatchExecutionFilesWithHttpMessagesAsync(executionId, index, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a specific file from an execution in loanPredictService1484637430.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='executionId'>
            /// Execution id of the execution
            /// </param>
            /// <param name='index'>
            /// Index of the execution in the batch.
            /// </param>
            /// <param name='fileName'>
            /// Name of the file to be returned.
            /// </param>
            public static System.IO.Stream GetBatchExecutionFile(this ILoanPredictService1484637430 operations, string executionId, int index, string fileName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ILoanPredictService1484637430)s).GetBatchExecutionFileAsync(executionId, index, fileName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a specific file from an execution in loanPredictService1484637430.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='executionId'>
            /// Execution id of the execution
            /// </param>
            /// <param name='index'>
            /// Index of the execution in the batch.
            /// </param>
            /// <param name='fileName'>
            /// Name of the file to be returned.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<System.IO.Stream> GetBatchExecutionFileAsync(this ILoanPredictService1484637430 operations, string executionId, int index, string fileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                var _result = await operations.GetBatchExecutionFileWithHttpMessagesAsync(executionId, index, fileName, null, cancellationToken).ConfigureAwait(false);
                _result.Request.Dispose();
                return _result.Body;
            }

    }
}

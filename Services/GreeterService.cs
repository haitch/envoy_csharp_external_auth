using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using Envoy.Service.Auth.V3;
using Greeter;
using ggrpc = Google.Rpc;

namespace envoy_proto_api
{
    public class EnvoyAuthorizationService : Envoy.Service.Auth.V3.Authorization.AuthorizationBase
    {
        private readonly ILogger<EnvoyAuthorizationService> _logger;
        public EnvoyAuthorizationService(ILogger<EnvoyAuthorizationService> logger)
        {
            _logger = logger;
        }

        public override Task<CheckResponse> Check(CheckRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"Check called for {request.Attributes.Request.Http.Method} {request.Attributes.Request.Http.Path} from {request.Attributes.Source.Address}");
            var res = new CheckResponse();
            res.Status = new ggrpc.Status();
            res.Status.Code = 0;
            res.OkResponse = new OkHttpResponse();
            if (request.Attributes.Request.Http.Path.Contains("envoy=notallowed"))
            {
                res.Status.Code = 7;
                res.DeniedResponse = new DeniedHttpResponse()
                {
                    Status = new Envoy.Type.V3.HttpStatus()
                    {
                        Code = Envoy.Type.V3.StatusCode.Forbidden
                    }
                };
            }
            if (request.Attributes.Request.Http.Path.Contains("envoy=redirect"))
            {
                res.Status.Code = 5;
                res.DeniedResponse = new DeniedHttpResponse()
                {
                    Status = new Envoy.Type.V3.HttpStatus()
                    {
                        Code = Envoy.Type.V3.StatusCode.MovedPermanently
                    }
                };
                res.DeniedResponse.Headers.Add(new Envoy.Config.Core.V3.HeaderValueOption()
                {
                    Header = new Envoy.Config.Core.V3.HeaderValue()
                    {
                        Key = "Location",
                        Value = "https://www.google.com"
                    }
                });
            }
            return Task.FromResult(res);
        }
    }

    public class GreeterService : Greeter.Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }
    }

}

/*
        //
        // Summary:
        //     Not an error; returned on success.
        OK = 0,
        //
        // Summary:
        //     The operation was cancelled (typically by the caller).
        Cancelled = 1,
        //
        // Summary:
        //     Unknown error. An example of where this error may be returned is if a Status
        //     value received from another address space belongs to an error-space that is not
        //     known in this address space. Also errors raised by APIs that do not return enough
        //     error information may be converted to this error.
        Unknown = 2,
        //
        // Summary:
        //     Client specified an invalid argument. Note that this differs from FAILED_PRECONDITION.
        //     INVALID_ARGUMENT indicates arguments that are problematic regardless of the state
        //     of the system (e.g., a malformed file name).
        InvalidArgument = 3,
        //
        // Summary:
        //     Deadline expired before operation could complete. For operations that change
        //     the state of the system, this error may be returned even if the operation has
        //     completed successfully. For example, a successful response from a server could
        //     have been delayed long enough for the deadline to expire.
        DeadlineExceeded = 4,
        //
        // Summary:
        //     Some requested entity (e.g., file or directory) was not found.
        NotFound = 5,
        //
        // Summary:
        //     Some entity that we attempted to create (e.g., file or directory) already exists.
        AlreadyExists = 6,
        //
        // Summary:
        //     The caller does not have permission to execute the specified operation. PERMISSION_DENIED
        //     must not be used for rejections caused by exhausting some resource (use RESOURCE_EXHAUSTED
        //     instead for those errors). PERMISSION_DENIED must not be used if the caller can
        //     not be identified (use UNAUTHENTICATED instead for those errors).
        PermissionDenied = 7,
        //
        // Summary:
        //     Some resource has been exhausted, perhaps a per-user quota, or perhaps the entire
        //     file system is out of space.
        ResourceExhausted = 8,
        //
        // Summary:
        //     Operation was rejected because the system is not in a state required for the
        //     operation's execution. For example, directory to be deleted may be non-empty,
        //     an rmdir operation is applied to a non-directory, etc.
        FailedPrecondition = 9,
        //
        // Summary:
        //     The operation was aborted, typically due to a concurrency issue like sequencer
        //     check failures, transaction aborts, etc.
        Aborted = 10,
        //
        // Summary:
        //     Operation was attempted past the valid range. E.g., seeking or reading past end
        //     of file.
        OutOfRange = 11,
        //
        // Summary:
        //     Operation is not implemented or not supported/enabled in this service.
        Unimplemented = 12,
        //
        // Summary:
        //     Internal errors. Means some invariants expected by underlying system has been
        //     broken. If you see one of these errors, something is very broken.
        Internal = 13,
        //
        // Summary:
        //     The service is currently unavailable. This is a most likely a transient condition
        //     and may be corrected by retrying with a backoff. Note that it is not always safe
        //     to retry non-idempotent operations.
        Unavailable = 14,
        //
        // Summary:
        //     Unrecoverable data loss or corruption.
        DataLoss = 15,
        //
        // Summary:
        //     The request does not have valid authentication credentials for the operation.
        Unauthenticated = 16
*/
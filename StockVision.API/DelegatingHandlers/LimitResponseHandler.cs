using System.Web;

namespace StockVision.API.DelegatingHandlers;

public class LimitResponseHandler(int limit) : DelegatingHandler
{
    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        var requestUri = request.RequestUri ?? throw new NullReferenceException("Request URI is null");
        var uriBuilder = new UriBuilder(requestUri);
        var query = HttpUtility.ParseQueryString(uriBuilder.Query);

        query["limit"] = limit.ToString();
        uriBuilder.Query = query.ToString();
        request.RequestUri = uriBuilder.Uri;

        return base.SendAsync(request, cancellationToken);
    }
}
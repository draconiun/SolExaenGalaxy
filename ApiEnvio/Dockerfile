FROM microsoft/dotnet:2.2-aspnetcore-runtime
WORKDIR /app

COPY ./bin/Release/netcoreapp2.2/publish/ /app

ENV ASPNETCORE_URLS=http://+:8080
ENV UrlSeguridad="http://23.102.34.16:9013/"
ENV ApiNameSeguridad="apisender"
ENV BusUrl="Endpoint=sb://busexamenayma.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=JWfQUoBUVCb2VbYbly/UMqTPG461QKd6hPAG+nnpfdc="
ENV BusTopic="topiccompra"

EXPOSE 8080

ENTRYPOINT ["dotnet", "/app/ApiEnvio.dll"]
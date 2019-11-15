FROM microsoft/dotnet:2.2-aspnetcore-runtime
WORKDIR /app

COPY ./bin/Release/netcoreapp2.2/publish/ /app

ENV ASPNETCORE_URLS=http://+:8080
ENV CnnBd="Server=tcp:servexamayma.database.windows.net,1433;Initial Catalog=dbVentas;Persist Security Info=False;User ID=galaxy;Password=A123456789123$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
ENV UrlSeguridad="http://23.102.34.16:9013/"
ENV ApiNameSeguridad="apicompra"
ENV BusUrl="Endpoint=sb://busexamenayma.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=JWfQUoBUVCb2VbYbly/UMqTPG461QKd6hPAG+nnpfdc="
ENV BusTopic="topiccompra"
ENV BusSuscriptor="comprasql"

EXPOSE 8080

ENTRYPOINT ["dotnet", "/app/ApiSQL.dll"]
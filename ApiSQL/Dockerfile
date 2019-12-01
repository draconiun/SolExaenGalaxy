FROM microsoft/dotnet:2.2-aspnetcore-runtime
WORKDIR /app

COPY ./bin/Release/netcoreapp2.2/publish/ /app

ENV ASPNETCORE_URLS=http://+:8080
ENV CnnBd="Data Source=serexamayma.database.windows.net;Initial Catalog=dbVentas;User ID=galaxy;Password = A123456789123$;"
ENV UrlSeguridad="http://65.52.230.194:9013/"
ENV ApiNameSeguridad="apicompra"
ENV BusUrl="Endpoint=sb://busexamenayma2.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=zoAyh6Lo8tMIPGKyIVfRx9ASqnDZ70mFJvkhPCoeuwc="
ENV BusTopic="topiccompra"
ENV BusSuscriptor="comprasql"

EXPOSE 8080

ENTRYPOINT ["dotnet", "/app/ApiSQL.dll"]
FROM microsoft/dotnet:2.2-aspnetcore-runtime
WORKDIR /app

COPY ./bin/Release/netcoreapp2.2/publish/ /app

ENV ASPNETCORE_URLS=http://+:8080
ENV UrlSeguridad="http://65.52.230.194:9013/"
ENV ApiNameSeguridad="apisender"
ENV BusUrl="Endpoint=sb://busexamenayma2.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=zoAyh6Lo8tMIPGKyIVfRx9ASqnDZ70mFJvkhPCoeuwc="
ENV BusTopic="topiccompra"

EXPOSE 8080

ENTRYPOINT ["dotnet", "/app/ApiEnvio.dll"]
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# העתקת כל הקבצים מהתיקייה הנוכחית לתוך ה-Docker
COPY . .

# הרצת ה-Restore על הקובץ שנמצא בתיקייה הנוכחית
RUN dotnet restore "Association.API.csproj"

# בנייה ופרסום
RUN dotnet publish "Association.API.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# הגדרת פורט ל-Render
ENV ASPNETCORE_URLS=http://+:10000
EXPOSE 10000

ENTRYPOINT ["dotnet", "Association.API.dll"]
